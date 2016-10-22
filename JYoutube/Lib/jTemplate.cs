using System;
using System.Collections.Generic;
using System.Xml;

namespace JYoutube.Lib
{
    class jTemplate
    {

        public static void make(string TmpName, string TmpCollectLink, string TmpCollectLinkA, string TmpCollectLinkTitle, string TmpCollectLinkVideo, 
            string TmpCollectMode, string TmpYouTuBeName,string TmpYouTuBeId)
        {
            string TmpDir = System.IO.Directory.GetCurrentDirectory() + "/Template";
            if (jFile.is_Dir(TmpDir))
            {
                string TmpFile = TmpDir + "/"+TmpName+".xml";
                if (!jFile.is_File(TmpFile))
                {
                    try
                    {
                        XmlDocument xmldoc = new XmlDocument();
                        //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                        XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                        xmldoc.AppendChild(xmldecl);
                        //加入一个根元素
                        XmlElement xmlelem = xmldoc.CreateElement("", "Template", "");
                        xmldoc.AppendChild(xmlelem);
                        //Template元素
                        XmlNode root = xmldoc.SelectSingleNode("Template");//查找<Template> 
                        //Name元素
                        XmlElement Name = xmldoc.CreateElement("Name");
                        XmlElement xeTmpValue = xmldoc.CreateElement("Value");//创建一个<Node>节点 
                        xeTmpValue.InnerText = TmpName;
                        Name.AppendChild(xeTmpValue);
                        root.AppendChild(Name);
                        //Collect元素
                        XmlElement Collect = xmldoc.CreateElement("Collect");
                        XmlElement xeTmpCollectLink = xmldoc.CreateElement("Link");//创建一个<Node>节点 
                        xeTmpCollectLink.InnerText = TmpCollectLink;
                        Collect.AppendChild(xeTmpCollectLink);
                        XmlElement xeTmpCollectLinkA = xmldoc.CreateElement("LinkA");//创建一个<Node>节点 
                        xeTmpCollectLinkA.InnerText = TmpCollectLinkA;
                        Collect.AppendChild(xeTmpCollectLinkA);
                        XmlElement xeTmpCollectLinkTitle = xmldoc.CreateElement("LinkTitle");//创建一个<Node>节点 
                        xeTmpCollectLinkTitle.InnerText = TmpCollectLinkTitle;
                        Collect.AppendChild(xeTmpCollectLinkTitle);
                        XmlElement xeTmpCollectLinkVideo = xmldoc.CreateElement("LinkVideo");//创建一个<Node>节点 
                        xeTmpCollectLinkVideo.InnerText = TmpCollectLinkVideo;
                        Collect.AppendChild(xeTmpCollectLinkVideo);
                        XmlElement xeTmpCollectMode = xmldoc.CreateElement("Mode");//创建一个<Node>节点 
                        xeTmpCollectMode.InnerText = TmpCollectMode;
                        Collect.AppendChild(xeTmpCollectMode);
                        root.AppendChild(Collect);
                        //YoutuBe元素
                        XmlElement YouTuBe = xmldoc.CreateElement("YouTuBe");
                        XmlElement xeTmpYouTuBeName = xmldoc.CreateElement("Name");//创建一个<Node>节点 
                        xeTmpYouTuBeName.InnerText = TmpYouTuBeName;
                        YouTuBe.AppendChild(xeTmpYouTuBeName);
                        XmlElement xeTmpYouTuBeId = xmldoc.CreateElement("Id");//创建一个<Node>节点 
                        xeTmpYouTuBeId.InnerText = TmpYouTuBeId;
                        YouTuBe.AppendChild(xeTmpYouTuBeId);
                        root.AppendChild(YouTuBe);
                        //状态元素
                        XmlElement Status = xmldoc.CreateElement("Status");
                        XmlElement xeStatusNumber = xmldoc.CreateElement("number");//创建一个<Node>节点 
                        xeStatusNumber.InnerText = "0";
                        Status.AppendChild(xeStatusNumber);
                        XmlElement xeStatusLastTime = xmldoc.CreateElement("LastTime");//创建一个<Node>节点 
                        xeStatusLastTime.InnerText = "0";
                        Status.AppendChild(xeStatusLastTime);
                        XmlElement xeStatusPublicTime = xmldoc.CreateElement("PublicTime");//创建一个<Node>节点 
                        xeStatusPublicTime.InnerText = DateTime.Now.ToString();
                        Status.AppendChild(xeStatusPublicTime);
                        root.AppendChild(Status);

                        xmldoc.Save(TmpFile);
                        jThread.insertLog("模版"+TmpName+"制作成功!");
                    }
                    catch(Exception e)
                    {
                        jThread.insertLog("模版" + TmpName + "制作失败!原因: "+e.Message);
                    }
                }else
                {
                    jThread.insertLog("模版" + TmpName + "制作失败!原因: 模版已存在");
                }
            }
        }

        public static List<string[]> getTmp()
        {
            List<string[]> ret = new List<string[]>();
            try
            {
                string TmpDir = System.IO.Directory.GetCurrentDirectory() + "/Template";
                List<string> files = jFile.getFiles(TmpDir);
                foreach(string file in files)
                {
                    List<string> data = new List<string>();
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(file);
                    XmlNode root = xmldoc.SelectSingleNode("Template");
                    foreach(XmlNode node in root.ChildNodes)
                    {
                        foreach(XmlNode n in node.ChildNodes)
                        {
                            XmlElement ne = (XmlElement)n;
                            data.Add(ne.InnerText);
                        }
                    }
                    ret.Add(data.ToArray());
                }
            }
            catch (Exception)
            {

            }
            return ret;
        }
    }
}
