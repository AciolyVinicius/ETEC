using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set
{
    class ClasseAcesso
    {
        private static String str1 = "";
        private static String str2 = "";

        public static string Str1
        {
            get
            {
                return str1;
            }

            set
            {
                str1 = value;
            }
        }

        public static string Str2
        {
            get
            {
                return str2;
            }

            set
            {
                str2 = value;
            }
        }

        /* public static void setstr1(String x)
        {
            str1 = x;
        }
        public static string getstr1()
        {
            return str1;
        }
        */
    }
}
