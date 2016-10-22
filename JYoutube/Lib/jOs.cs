using System;
using System.Windows.Forms;

namespace JYoutube.Lib
{
    class jOs
    {
        private static jThread jthread;

        public static void init(ListBox jlbLogList, ListView jlvTemplate)
        {
            jthread = new jThread(jlbLogList,jlvTemplate);
        }

        public static void start() {
            jthread.start();
        }

        public static void stop()
        {
            jthread.stop();
        }

        public static void make(string TmpName, string TmpCollectLink, string TmpCollectLinkA, string TmpCollectLinkTitle, string TmpCollectLinkVideo, 
            string TmpCollectMode, string TmpYouTuBeName, string TmpYouTuBeId)
        {
            jTemplate.make(TmpName, TmpCollectLink, TmpCollectLinkA, TmpCollectLinkTitle, TmpCollectLinkVideo, TmpCollectMode, TmpYouTuBeName, TmpYouTuBeId);
        }

        public static void registerjHotKey(IntPtr hWnd)
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            jHotKey.RegisterHotKey(hWnd, 100, jHotKey.KeyModifiers.Alt, Keys.S);
            //注册热键Ctrl+B，Id号为101。HotKey.KeyModifiers.Ctrl也可以直接使用数字2来表示。
            jHotKey.RegisterHotKey(hWnd, 101, jHotKey.KeyModifiers.Alt, Keys.B);
            //注册热键Alt+D，Id号为102。HotKey.KeyModifiers.Alt也可以直接使用数字1来表示。
            jHotKey.RegisterHotKey(hWnd, 102, jHotKey.KeyModifiers.Alt, Keys.D);
        }

        public static void uregisterjHotKey(IntPtr hWnd)
        {
            //注销Id号为100的热键设定
            jHotKey.UnregisterHotKey(hWnd, 100);
            //注销Id号为101的热键设定
            jHotKey.UnregisterHotKey(hWnd, 101);
            //注销Id号为102的热键设定
            jHotKey.UnregisterHotKey(hWnd, 102);
        }
    }
}
