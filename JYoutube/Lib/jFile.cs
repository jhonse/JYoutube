using System;
using System.Collections.Generic;
using System.IO;

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
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool is_File(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return true;
                }else
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

        public static List<string> getFiles(string path)
        {
            List<string> files = new List<string>();
            try
            {
                DirectoryInfo folder = new DirectoryInfo(path);
                foreach (FileInfo file in folder.GetFiles("*.xml"))
                {
                    files.Add(file.FullName);
                }
            }
            catch (Exception)
            {

            }
            return files;
        }
    }
}
