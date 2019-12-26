using Graffiti.MST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Graffiti.MST.ComponentsTools;

namespace KittingMst_2
{
    public class ComponentsFromGraffiti
    {
        public static Dictionary<string, List<string>> qrCodesInLocations = new Dictionary<string, List<string>>();
        public static List<ComponentStruct> GetComponentsDataInLocation(string location)
        {
            if (!qrCodesInLocations.ContainsKey(location)) return null;
            return Graffiti.MST.ComponentsTools.GetDbData.GetComponentDataWithAttributes(qrCodesInLocations[location]).ToList();
        }

        public static void RefreshDataFromDc()
        {
            qrCodesInLocations = Graffiti.MST.ComponentsTools.GetDbData.GetComponentsInLocations("EL:");
            var componentsLedDiodes =
                qrCodesInLocations.SelectMany(c => c.Value.Select(i => i))
                .Where(i => i.StartsWith("4010460"))
                .Where(i => i.StartsWith("4010560"))
                .ToList();
            var componentData = Graffiti.MST.ComponentsTools.GetDbData.GetComponentDataWithAttributes(componentsLedDiodes);
        }
    }
}
