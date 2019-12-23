using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittingMst_2
{
    public class ProductStructureTree
    {
        public static TreeListView treeProductStructure;
        List<TreeStructure> treeViewSource = new List<TreeStructure>();
        class TreeStructure
        {
            public string nc_entity_id { get; set; }
            public string nc12 { get; set; }
            public string parentId { get; set; }
        }

        public static void MakeTreeViewSource(MST.MES.Data_structures.DevToolsModelStructure dtModel)
        {

            treeProductStructure.Objects = null;
            if (dtModel != null)
            {
                treeProductStructure.CanExpandGetter = delegate (object x) { return ((MST.MES.Data_structures.DevToolsModelStructure)x).children.Count > 0; };
                treeProductStructure.ChildrenGetter = delegate (object x) { return ((MST.MES.Data_structures.DevToolsModelStructure)x).children; };
                treeProductStructure.AddObject(dtModel);

                treeProductStructure.ExpandAll();
            }
        }

        public static IEnumerable<MST.MES.Data_structures.DevToolsModelStructure> GetNodes(MST.MES.Data_structures.DevToolsModelStructure dtModel)
        {
            if (dtModel == null)
            {
                yield break;
            }
            yield return dtModel;
            foreach (var n in dtModel.children)
            {
                foreach (var innerN in GetNodes(n))
                {
                    yield return innerN;
                }
            }
        }

    }
}
