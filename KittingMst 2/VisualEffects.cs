using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KittingMst_2
{
    public class VisualEffects
    {
        public static Timer loadingTransitionTimer;
        private static Color colorTranstion = Color.LightSteelBlue;

        public static void MakeLoadingColorTransition(Button btn)
        {
            if (btn.Tag == null) btn.Tag = "0";

        }
        
    }
}
