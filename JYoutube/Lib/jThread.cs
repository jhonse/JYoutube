using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace JYoutube.Lib
{
    class jThread
    {
        private static ListBox lbLogList = null;
        public static ListView lvTemplate = null;

        System.Timers.Timer t_collect = null;
        System.Timers.Timer t_send = null;

        public jThread(ListBox jlbLogList, ListView jlvTemplate)
        {
            lbLogList = jlbLogList;
            lvTemplate = jlvTemplate;

            init();

            t_collect = new System.Timers.Timer(1000);
            t_collect.Elapsed += t_collect_Elapsed;
            t_collect.AutoReset = true;
            t_collect.Enabled = false;

            t_send = new System.Timers.Timer(1000);
            t_send.Elapsed += t_send_Elapsed;
            t_send.AutoReset = true;
            t_send.Enabled = false;

            insertLog("初始化成功!");
        }

        public void start()
        {
            t_collect.Enabled = true;
            //t_send.Enabled = true;
        }

        public void stop()
        {
            t_collect.Enabled = false;
            //t_send.Enabled = false;
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

        private void init()
        {
            insertTmpColumns();
            Thread tInsertTmp = new Thread(new ThreadStart(insertTmp));
            tInsertTmp.IsBackground = true;
            tInsertTmp.Start();
        }

        private void insertTmp()
        {
            insertTmpItems(jTemplate.getTmp());
        }

        public void insertTmpItems(List<string[]> datas)
        {
            lvTemplate.BeginUpdate();
            foreach(string[] data in datas)
            {
                ListViewItem lvi = new ListViewItem();

                int i = 0;
                foreach(string d in data)
                {
                    if(i == 0)
                    {
                        lvi.Text = d;
                    }else
                    {
                        lvi.SubItems.Add(d);
                    }
                    i++;
                }

                lvTemplate.Items.Add(lvi);
            }
            lvTemplate.EndUpdate();
        }

        public void insertTmpColumns()
        {
            try
            {
                ImageList imgList = new ImageList();
                imgList.ImageSize = new Size(1, 40);
                lvTemplate.SmallImageList = imgList;

                lvTemplate.Columns.Add("模版名称", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("采集列表链接", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("采集列表链接A标签", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("视频页Video标题", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("视频页Video标签", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("模式", 120, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("Youtube播放列表名称", 120, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("Youtube播放列表ID", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("采集数目", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("上次采集时间", 150, HorizontalAlignment.Left);
                lvTemplate.Columns.Add("创建时间", 150, HorizontalAlignment.Left);
            }
            catch (Exception)
            {
                
            }
        }

        void t_collect_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            jCollect.Start();
        }

        void t_send_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            jUpload.Start();
        }

    }
}
