using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace ConsoleRest
{
    class Crud
    {
        string filepath = ConfigurationManager.AppSettings["filepath"].ToString();
        public void CreateFile()
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("create error" + ex.Message);
            }
        }
        public string ReadFile()
        {
            string text;
            try
            {
                text = File.ReadAllText(filepath);
                //Console.WriteLine(text);
                return text;
            }
            catch (Exception ex)
            {
                 Console.WriteLine("read error" + ex.Message);
            }
            return " ";
        }
        public string UpdateFile(String s)
        {
            try
            {
                File.WriteAllText(filepath, s);
                return filepath;
            }
            catch (Exception ex)
            {
                Console.WriteLine("update error" + ex.Message);              
            }
            return " ";
        }
        public void DeleteFile()
        {
            try
            {
                if (File.Exists(Path.Combine(filepath)))
                {
                    File.Delete(Path.Combine(filepath));
                   // Console.WriteLine("File deleted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete error" + ex.Message);
            }
        }
    }
}
