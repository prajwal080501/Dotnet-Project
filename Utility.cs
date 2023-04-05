using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePassGenerator
{
    internal class Utility

    {
        //check for entered input is digit or not
        public static void onlynumber(KeyPressEventArgs e)
        {
           if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static String getUniqueId(String prefix)
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return prefix + nano;
        }

        public static object getImageStorePath(String imageName)
        {
            return Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) +"\\images\\" + imageName + ".jpg";
        }
    }
}
