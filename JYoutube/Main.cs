using JYoutube.Lib;
using System;
using System.Windows.Forms;

namespace JYoutube
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            jOs.init(lbLog,lvTmp);
        }

        private void btnTmpMake_Click(object sender, EventArgs e)
        {
            string Mode = "";
            if (rbTmpCollectModePc.Checked)
            {
                Mode = "PC";
            }else if (rbTmpCollectModeWap.Checked)
            {
                Mode = "WAP";
            }
            jOs.make(tbTmpName.Text, tbTmpCollectLink.Text, tbTmpCollectLinkA.Text, tbTmpCollectLinkTitle.Text, tbTmpCollectLinkVideo.Text, Mode, tbTmpYouTuBeName.Text, tbTmpYouTuBeID.Text);
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            jOs.registerjHotKey(Handle);
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            jOs.uregisterjHotKey(Handle);
        }

        protected override void WndProc(ref Message m)
        {

            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:    //按下的是Alt+S
                            this.Visible = true;
                            break;
                        case 101:    //按下的是Alt+B
                            this.Visible = false;
                            break;
                        case 102:    //按下的是Alt+D
                            this.Close();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jOs.start();
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jOs.stop();
        }
    }
}
