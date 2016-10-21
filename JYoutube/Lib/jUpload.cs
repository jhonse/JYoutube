using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYoutube.Lib
{
    class jUpload
    {
        private static int status = 0;

        public static void Start()
        {
            if (status == 0)
            {
                status = 1;
                Youtube.Upload.Start("相声《有哲理的人》小岳岳爆料孙越北京每环都有房", "相声《有哲理的人》小岳岳爆料孙越北京每环都有房", new string[] { "相声《有哲理的人》小岳岳爆料孙越北京每环都有房" }, @"C:\Users\admin_000\Desktop\相声《有哲理的人》小岳岳爆料孙越北京每环都有房.mp4");
            }
            else if (status == 1)
            {
                if (Youtube.Upload.finish == 1)
                {
                    status = 2;
                }
                else if (Youtube.Upload.finish == -1)
                {
                    status = 0;
                }
            }
            else if (status == 2)
            {
                status = 3;
                Youtube.Playlists.Start("郭德纲相声大全", "PLBLfWwQUZZbgGSrrZZA4Y2IlpQrW8lLNV", Youtube.Upload.s_video.Id);
            }
            else if (status == 3)
            {
                if (Youtube.Playlists.finish == 1)
                {
                    //完成整个流程
                }
                else if (Youtube.Playlists.finish == -1)
                {
                    status = 2;
                }
            }
            
        }
    }
}
