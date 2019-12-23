using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittingMst_2
{
    public class GlobalParameters
    {
        public static string domainCurrentUserName;

        public static string[] superDomainUsers = new string[] { "MST/piotr.dabrowski@mstechnology.pl", "MST/wojciech.komor@mstechnology.pl", "MST/katarzyna.kustra@mstechnology.pl" };

        public static bool IsSuperUserLogged { get
            {
                return superDomainUsers.Contains(domainCurrentUserName);
            } }

        public static bool release = true;
    }
}
