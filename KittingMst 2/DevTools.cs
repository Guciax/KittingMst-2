using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittingMst_2
{
    public class DevTools
    {
        public static List<MST.MES.Data_structures.DevToolsModelStructure> dtDb = new List<MST.MES.Data_structures.DevToolsModelStructure>();

        public static MST.MES.Data_structures.DevToolsModelStructure dtModel00
        {
            get { return MST.MES.DtTools.GetDtModel00(SelectedOrder.selectedOrder.modelId, dtDb); }
            }
        public static MST.MES.Data_structures.DevToolsModelStructure dtModel46
        {
            get
            { return MST.MES.DtTools.GetDtModel46(SelectedOrder.selectedOrder.modelId, dtDb); }
        }

        public static void LoadDtDb()
        {
            dtDb = MST.MES.Data_structures.DevTools.DevToolsLoader.LoadDevToolsModels();
        }
    }
}
