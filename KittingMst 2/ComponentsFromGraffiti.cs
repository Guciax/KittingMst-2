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
        public static IEnumerable<ComponentStruct> componentsInProductionEl2;
        public static IEnumerable<ComponentStruct> componentsInClimateChamber;
        public static IEnumerable<ComponentStruct> allComponents;
        
        public static List<ComponentStruct> GetComponentsDataInLocationPrefix(string location)
        {
            if (!qrCodesInLocations.ContainsKey(location)) return new List<ComponentStruct>();
            return allComponents.Where(c => c.Location.StartsWith(location)).ToList();
        }

        public static List<ComponentStruct> GetComponentsDataInLocation(string location)
        {
            if (!qrCodesInLocations.ContainsKey(location)) return new List<ComponentStruct>();
            return allComponents.Where(c => c.Location == location).ToList();
        }

        public static async Task RefreshDataFromDb()
        {
            qrCodesInLocations = Graffiti.MST.ComponentsTools.GetDbData.GetComponentsInLocations("EL2.");
            if (!qrCodesInLocations.Any()) return;
            var componentsLedDiodes =
                qrCodesInLocations.SelectMany(c => c.Value.Select(i => i))
                .Where(i => i.StartsWith("4010460"))
                .Where(i => i.StartsWith("4010560"))
                .ToList();
            var componentData = Graffiti.MST.ComponentsTools.GetDbData.GetComponentDataWithAttributes(componentsLedDiodes);
            componentsInProductionEl2 = componentData.Where(c => !c.Location.StartsWith(Graffiti.MST.ComponentsLocations.ClimateChanberPrefix));
            componentsInClimateChamber = componentData.Where(c => c.Location.StartsWith(Graffiti.MST.ComponentsLocations.ClimateChanberPrefix));
        }
    }
}
