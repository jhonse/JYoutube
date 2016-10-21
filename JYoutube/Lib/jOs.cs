using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYoutube.Lib
{
    class jOs
    {
        private static jThread jthread;

        public static void init(ListBox jlbLogList)
        {
            jthread = new jThread(jlbLogList);
        }
        public static void start() {
            jthread.start();
        }
        public static void stop()
        {
            jthread.stop();
        }
    }
}
