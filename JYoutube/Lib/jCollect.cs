using System;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using Newtonsoft.Json;
using System.Xml;

namespace JYoutube.Lib
{
    class jCollect
    {
        private static bool ok = false;

        public static void Start()
        {
            if (!ok)
            {
                ok = true;
                getPageList();
            }else
            {

            }
        }

        private static void getPageList()
        {
            if(jThread.lvTemplate.Items.Count > 0)
            {
                try
                {
                    ListViewItem lvi = null;
                    if (jThread.lvTemplate.SelectedItems.Count <= 0)
                    {
                        lvi = jThread.lvTemplate.Items[0];
                    }
                    else
                    {
                        lvi = jThread.lvTemplate.SelectedItems[0];
                    }
                    string name = lvi.Text;
                    string TmpCollectLink = lvi.SubItems[1].Text;
                    string TmpCollectLinkA = lvi.SubItems[2].Text;
                    string TmpCollectLinkTitle = lvi.SubItems[3].Text;
                    string TmpCollectLinkVideo = lvi.SubItems[4].Text;
                    string TmpCollectMode = lvi.SubItems[5].Text;
                    string pageListData = jDownLoad.downPage(TmpCollectLink, Encoding.UTF8, true);
                    pageListData = ((XmlDocument)JsonConvert.DeserializeXmlNode(pageListData)).InnerText;
                    if (!pageListData.Equals(""))
                    {
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(pageListData);
                        HtmlNodeCollection LinkAs = doc.DocumentNode.SelectNodes(TmpCollectLinkA);
                        foreach(HtmlNode LinkA in LinkAs)
                        {
                            string a_href = LinkA.Attributes["href"].Value;
                            if (!a_href.Equals(""))
                            {
                                string pageData = jDownLoad.downPage(a_href,Encoding.UTF8, true);
                                if (!pageData.Equals(""))
                                {
                                    HtmlAgilityPack.HtmlDocument page_doc = new HtmlAgilityPack.HtmlDocument();
                                    page_doc.LoadHtml(pageData);
                                    HtmlNode Title = page_doc.DocumentNode.SelectSingleNode(TmpCollectLinkTitle);
                                    if(Title != null)
                                    {
                                        string title = Title.InnerText;
                                        HtmlNode Video = page_doc.DocumentNode.SelectSingleNode(TmpCollectLinkVideo);
                                        if(Video != null)
                                        {
                                            string video = Video.Attributes["src"].Value;
                                            if (!video.Equals(""))
                                            {
                                                //WebClient mywebclient = new WebClient();
                                                //mywebclient.DownloadFile(video, imagePath + "/" + page.ToString() + "/" + parentName + "/" + fileName);
                                            }
                                        }
                                    }
                                }
                                else
                                {

                                }
                            }else
                            {

                            }
                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                //return -1;
            }
        }
    }
}
