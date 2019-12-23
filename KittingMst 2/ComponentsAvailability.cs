using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittingMst_2
{
    public class ComponentsAvailability
    {
        public static DataGridView dgv;
        public static void FillOutGrid()
        {
            var components = MST.MES.DtTools.GetOtherComp12Nc(DevTools.dtModel00);
            
            
            
        }
    }
}
