using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYoutube.Lib
{
    class jFile
    {
        public static bool is_Dir(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void deleteDirFiles(string path)
        {
            try
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }
            catch (Exception)
            {

            }
        }

        public static void deleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception)
            {

            }
        }
    }
}
