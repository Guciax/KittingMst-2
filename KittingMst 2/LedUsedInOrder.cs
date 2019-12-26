using BrightIdeasSoftware;
using KittingMst_2.Forms;
using MST.MES.Data_structures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KittingMst_2.SelectedOrder;

namespace KittingMst_2
{
    class LedUsedInOrder
    {
        public class LedsUsedInCurrentOrderContainer
        {
            public static List<Graffiti.MST.ComponentsTools.ComponentStruct> ledReelsForCurrentOrderList = new List<Graffiti.MST.ComponentsTools.ComponentStruct>();
            public static Dictionary<string, string> nc12RankToBinLetter()
            {
                return Graffiti.MST.KittingTools.ListNc12RankToBinLetter(ledReelsForCurrentOrderList);
            }
        }
        public static ObjectListView lvLedUsedForOrder;
        public static ObjectListView lvLedsSummary;
        private static List<ListViewColumns> ledSummarySource = new List<ListViewColumns>();

        public static IEnumerable<Graffiti.MST.ComponentsTools.ComponentStruct> ledsInClimateChamber { get; set; }
        
        public class AllowedLedsForSelectedOrder
        {
            public static bool AllBinsHaveCollective()
            {
                return true; //graffiti
                foreach (var bin12Nc in Bins12NcForOrder)
                {
                    if (!LedCollectiveDb.nc12ToCollective.ContainsKey(bin12Nc)) return false;
                }
                return true;
            }

            public static string[] Bins12NcForOrder { get { return SelectedOrder.selectedOrder.ledsChoosenByPlanner; } }
            public static  string GetBinLetter(string bin12Nc)
            {
                Char binLetter = 'A';
                if (Bins12NcForOrder != null)
                {
                    foreach (var nc in Bins12NcForOrder)
                    {
                        if (bin12Nc == nc) return binLetter.ToString();
                        binLetter++;
                    }
                }
                return null;
            }

            public static List<string> GetListOfMembersSameCollective(string col12Nc)
            {
                return selectedOrder.ledCol12NcGraffitiOnly.Where(l => l == col12Nc).ToList();
            }

            public static int NumberOfBinsForMember12Nc(string member12Nc)
            {
                if (!AllBinsHaveCollective()) return 0;

                int result = 0;
                string col = LedCollectiveDb.nc12ToCollective[member12Nc].collective;

                foreach (var bin in Bins12NcForOrder)
                {
                    if (LedCollectiveDb.nc12ToCollective[bin].collective == col) result++;
                }
                return result;
            }

            public static int GetNumberOfLedForMember12Nc(string col12Nc_Rank, MST.MES.Data_structures.DevToolsModelStructure dtModel)
            {
                var splitted = col12Nc_Rank.Split(' ');
                string nc12 = splitted[0];
                string rank = splitted[1];
                //if (!LedCollectiveDb.nc12ToCollective.ContainsKey(member12Nc)) return 0;
                var colQty = MST.MES.DtTools.GetLedCountOfSpecific12Nc(dtModel, nc12);
                var binsWithSameCollective = selectedOrder.LedChoosenStructList.Where(l => l.Nc12 == nc12).ToList();
                var indexOfMember = 0;
                for (int i = 0; i < binsWithSameCollective.Count; i++)
                {
                    if(binsWithSameCollective[i].Rank == rank)
                    {
                        indexOfMember = i;
                        break;
                    }
                }

                if (colQty == 0) return 0;

                if ((indexOfMember + 1) % 2 == 0)
                {
                    return (int)Math.Floor(colQty / binsWithSameCollective.Count); //BIN B
                }
                else
                {
                    return (int)Math.Ceiling(colQty / binsWithSameCollective.Count); //BIN A
                }
            }
        }

        

        public static void AddLedReel(Graffiti.MST.ComponentsTools.ComponentStruct compData)
        {
            LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList.Add(compData);

            lvLedUsedForOrder.SetObjects(LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList);
            UpdateLedSummary();
        }

        public static void ShowAllowedLeds()
        {
            lvLedsSummary.Items.Clear();
            ledSummarySource.Clear();
            if (SelectedOrder.selectedOrder.ledsChoosenByPlanner != null)
            {
                ledSummarySource.Add(new ListViewColumns
                {
                    first = "Dozwolone diody:"
                });
                Char binLetter = 'A';
                foreach (var nc in SelectedOrder.selectedOrder.ledsChoosenByPlanner)
                {
                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = $"Bin{binLetter}",
                        second = nc.Insert(4, " ").Insert(8, " "),
                    });
                    binLetter++;
                }
                lvLedsSummary.SetObjects(ledSummarySource);
            }
        }

        public static void UpdateLedSummary()
        {
            lvLedsSummary.Items.Clear();
            ledSummarySource.Clear();
            if (SelectedOrder.selectedOrder.ledsChoosenByPlanner!= null)
            {
                ledSummarySource.Add(new ListViewColumns
                {
                    first = "Dozwolone diody:"
                });

                foreach (var binEntry in LedsUsedInCurrentOrderContainer.nc12RankToBinLetter())
                {
                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = $"Bin{binEntry.Value}",
                        second = binEntry.Key,
                    });
                }
            }

            ledSummarySource.Add(new ListViewColumns
            {

            });
            ledSummarySource.Add(new ListViewColumns
            {
                first = "Wymagana ilość",
            });
            foreach (var nc in AllowedLedsForSelectedOrder.Bins12NcForOrder)
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string qtyFormatted = (AllowedLedsForSelectedOrder.GetNumberOfLedForMember12Nc(nc, DevTools.dtModel00) * selectedOrder.orderedQty).ToString("#,0", nfi); // "1 234 897.11"

                ledSummarySource.Add(new ListViewColumns
                {
                    first = nc.Insert(4, " ").Insert(8, " "),
                    second = qtyFormatted
                });
            }

            ledSummarySource.Add(new ListViewColumns
            {
                
            });
            ledSummarySource.Add(new ListViewColumns
            {
                first = "Wczytane diody:",
                second = "Ilość"
            });
            var grByLed12Nc = LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList.GroupBy(l => l.Nc12_Formated_Rank);
            foreach (var nc in grByLed12Nc)
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string qtyFormatted = (nc.Select(x => x.Quantity).Sum()).ToString("#,0", nfi); // "1 234 897.11"

                ledSummarySource.Add(new ListViewColumns
                {
                    first = nc.Key,
                    second = qtyFormatted
                });
            }
            
            var ledInClimateChamberMatchingThisOrder = ledsInClimateChamber.Where(x => AllowedLedsForSelectedOrder.Bins12NcForOrder.Contains(x.Nc12_Formated_Rank));
            if (ledInClimateChamberMatchingThisOrder.Count() > 0)
            {
                ledSummarySource.Add(new ListViewColumns
                {
                    
                });
                ledSummarySource.Add(new ListViewColumns
                {
                    first = "Szafa klimatyczna",
                    second = ""
                });

                foreach (var led in ledInClimateChamberMatchingThisOrder)
                {
                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = led.Nc12_Formated,
                        second = $"{ led.Quantity}szt. {led.Location} "
                    });
                    ledSummarySource.Add(new ListViewColumns
                    {
                        first = "",
                        second = $"zlecenie: {led.ConnectedToOrder}"
                    });
                }
            }

            var currentMb = MST.MES.DtTools.GetMb12NC(DevTools.dtModel00);
            var mbInfo = MST.MES.SqlOperations.SparingLedInfo.GetCurrentDataFor12NC(new string[] { currentMb.Replace(" ", "") });
            var mbOnProd = mbInfo.Where(c => c.Z_PodMag == "KZ40" & c.Qty > 0).GroupBy(c=>c.Z_RegSeg);
            ledSummarySource.Add(new ListViewColumns
            {
                first = "",
                second = ""
            });
            ledSummarySource.Add(new ListViewColumns
            {
                first = "Płyta MB:",
                second = currentMb
            });
            foreach (var locationEntry in mbOnProd)
            {
                ledSummarySource.Add(new ListViewColumns
                {
                    first = locationEntry.Key,
                    second = $"{locationEntry.Select(c=>c.Qty).Sum()} szt."
                });
            }
            
            ProductionStock.CheckProdStock(ref ledSummarySource);
            lvLedsSummary.SetObjects(ledSummarySource);
        }

        public static async Task LoadLeds(string orderNo)
        {
            List<Task> tasksList = new List<Task>();
            //tasksList.Add(Task.Run(() => GetReelsForLotFromDb(orderNo)));
            tasksList.Add(Task.Run(() => GetReelsForLotFromGraffiti(orderNo)));
            tasksList.Add(Task.Run(() => LoadLedsFromClimateChamber()));
            await Task.WhenAll(tasksList);
            //MakeGrpupsForBins();

            FillOutLedsForOrder();
        }

        private static void LoadLedsFromClimateChamber()
        {
            var componentsInClimateChamber = Graffiti.MST.ComponentsTools.GetDbData.GetComponentsInLocations(Graffiti.MST.ComponentsLocations.ClimateChanberPrefix);
            var qrList = componentsInClimateChamber.SelectMany(c => c.Value);
            var componentsData = Graffiti.MST.ComponentsTools.GetDbData.GetComponentDataWithAttributes(qrList.ToList());
            ledsInClimateChamber = componentsData;
        }

        private static void MakeGrpupsForBins()
        {
            lvLedUsedForOrder.Groups.Clear();
            if(SelectedOrder.selectedOrder.ledsChoosenByPlanner == null)
            {
                //MessageBox.Show("Brak BINów przypisanych przez planistę do tego zlecenia.");
                if (GlobalParameters.IsSuperUserLogged)
                {
                    AddBins addBinsForm = new AddBins();
                    if (addBinsForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                return;
            }

            foreach (var led12Nc in SelectedOrder.selectedOrder.ledsChoosenByPlanner) 
            {
                ListViewGroup newGroup = new ListViewGroup();
                newGroup.Name = led12Nc.Replace(" ", "").Insert(4, " ").Insert(8, " ");
                newGroup.Header = led12Nc.Insert(4," ").Insert(8," ");
                lvLedUsedForOrder.Groups.Add(newGroup);
            }
        }

        private static void FillOutLedsForOrder()
        {
            if (lvLedUsedForOrder.Groups.Count == 0)
            {
                var unique12Nc = LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList.Select(i => i.Nc12_Formated_Rank).Distinct();
                foreach (var nc in unique12Nc)
                {
                    lvLedUsedForOrder.Groups.Add(nc, nc);
                }
            }
            lvLedUsedForOrder.SetObjects(LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList);
        }

        //private static void GetReelsForLotFromDb(string orderNo)
        //{
        //    ledReelsForCurrentOrderList.Clear();
        //    DataTable sqlTable = MST.MES.SqlOperations.SparingLedInfo.GetReelsForLot(orderNo);
        //    List<LedInfo> led12NcIdList = new List<LedInfo>();

        //    foreach (DataRow row in sqlTable.Rows)
        //    {
        //        string nc12 = row["NC12"].ToString();
        //        string id = row["ID"].ToString();
        //        if (led12NcIdList.Select(i => i.Id + i.Nc12).Contains(id + nc12)) continue;

        //        led12NcIdList.Add(new LedInfo(nc12, id));

        //        ledReelsForCurrentOrderList.Add(new LedReelsInCurrentOrderStruct
        //        {
        //            Id = id,
        //            Nc12 = nc12
        //        });
        //    }

        //    var detailedLedInfo = MST.MES.SqlOperations.SparingLedInfo.GetInfoForMultiple12NC_ID(led12NcIdList.ToArray());
        //    //Tara,NC12,ID,Ilosc,ZlecenieString,Data_Czas,Tara,Partia,Z_RegSeg

        //    for (int r = detailedLedInfo.Rows.Count - 1; r >= 0; r--) 
        //    {
        //        string nc12 = detailedLedInfo.Rows[r]["NC12"].ToString();
        //        string id = detailedLedInfo.Rows[r]["ID"].ToString();
        //        var ledFromList = ledReelsForCurrentOrderList.Where(l => l.Nc12 == nc12 & l.Id == id).First();
        //        if (!string.IsNullOrWhiteSpace(ledFromList.BinLetter)) continue;

        //        string currentOrderNo = detailedLedInfo.Rows[r]["ZlecenieString"].ToString();
        //        int qty = int.Parse(detailedLedInfo.Rows[r]["Ilosc"].ToString());
        //        string binLetter = detailedLedInfo.Rows[r]["Tara"].ToString();

        //        ledFromList.Qty = qty;
        //        ledFromList.CurrentOrder = currentOrderNo;
        //        ledFromList.BinLetter = binLetter;
        //    }


        //}

        private static void GetReelsForLotFromGraffiti(string orderNo)
        {
            LedsUsedInCurrentOrderContainer. ledReelsForCurrentOrderList.Clear();
            List<LedInfo> led12NcIdList = new List<LedInfo>();

            var componentsOnElec = ComponentsFromGraffiti.GetComponentsDataInLocation("EL:");
            var reelForThisOrder = 
                componentsOnElec.Where(r => r.ConnectedToOrder.ToString() == orderNo)
                .Where(c=>c.Nc12.StartsWith("4010460") || c.Nc12.StartsWith("4010560"));

            LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList = reelForThisOrder.ToList();

            //foreach (var reel in reelForThisOrder)
            //{
            //    led12NcIdList.Add(new LedInfo(reel.Nc12, reel.Id));
            //    LedsUsedInCurrentOrderContainer.ledReelsForCurrentOrderList.Add(new LedReelsInCurrentOrderStruct
            //    {
            //        Id = reel.Id,
            //        Nc12 = reel.Nc12_Formated_Rank,
            //        Collective = reel.Nc12,
            //        Qty = (int)reel.Quantity,
            //        CurrentOrder = reel.ConnectedToOrder.ToString()
            //    });
            //}
        }

        public static string GenerateLedName(string member12Nc)
        {
            if (!LedCollectiveDb.nc12ToCollective.ContainsKey(member12Nc)) return member12Nc;
            var collective = LedCollectiveDb.nc12ToCollective[member12Nc];
            
            var dtModels = DevTools.dtDb.Where(x => x.nc12 == collective.collective);
            if (dtModels.Count() == 0)
            {
                MessageBox.Show($"Brak danych DevTools dla komponentu: {member12Nc} collective 12NC:{collective.collective}");
                return collective.name;
            }
            var dtModel = dtModels.First();
            
            string cct = "";
            string cri = "";
            string package = "";

            if (!dtModel.atributes.TryGetValue("Obudowa", out package)) return collective.name;
            if (!dtModel.atributes.TryGetValue("CH1 CCT", out cct)) return collective.name;
            if (!dtModel.atributes.TryGetValue("CH1 CRI (Ra)", out cri)) return collective.name;

            return $"Dioda LED {package.Split(' ')[0]} {cct}K CRI{cri}";
        }
    }
}
