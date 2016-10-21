using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYoutube.Lib
{
    class jThread
    {
        private static ListBox lbLogList = null;

        private int status = 0;

        System.Timers.Timer t_collect = null;
        System.Timers.Timer t_send = null;

        public jThread(ListBox jlbLogList)
        {
            lbLogList = jlbLogList;

            t_collect = new System.Timers.Timer(1000);
            t_collect.Elapsed += t_collect_Elapsed;
            t_collect.AutoReset = true;
            t_collect.Enabled = false;

            t_send = new System.Timers.Timer(1000);
            t_send.Elapsed += t_send_Elapsed;
            t_send.AutoReset = true;
            t_send.Enabled = false;
        }

        public void start()
        {
            t_collect.Enabled = true;
            t_send.Enabled = true;
        }

        public void stop()
        {
            t_collect.Enabled = false;
            t_send.Enabled = false;
        }

        public static void insertLog(string log)
        {
            try
            {
                if (lbLogList != null)
                {
                    if (lbLogList.Items.Count > 50)
                    {
                        lbLogList.Items.Clear();
                    }
                    lbLogList.Items.Insert(0, "-------------- " + DateTime.Now.ToString() + " --------------");
                    lbLogList.Items.Insert(1, "");
                    lbLogList.Items.Insert(2, log);
                    lbLogList.Items.Insert(3, "");
                }
            }
            catch (Exception)
            {
                lbLogList.Items.Clear();
            }
        }

        void t_collect_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        void t_send_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            jUpload.Start();
        }

    }
}
