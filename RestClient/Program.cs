using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using System.IO;

namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter the choice");
                Console.WriteLine("1.create file");
                Console.WriteLine("2.read file");
                Console.WriteLine("3.update file");
                Console.WriteLine("4. delete  file");
                Console.WriteLine("----------");
                CrudCleint crudclient = new CrudCleint();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:                       
                        crudclient.CreateFile();
                        Console.WriteLine("file created");
                        break;
                    case 2:
                        String text = crudclient.ReadFile();
                        Console.WriteLine(text);
                        Console.WriteLine("File is read");
                        break;
                    case 3:
                        Console.WriteLine("enter the text");
                        string s = Console.ReadLine();
                        string r = crudclient.UpdateFile(s);
                        Console.WriteLine("File got updated "+ r);
                        break;
                    case 4:
                        crudclient.DeleteFile();
                        Console.WriteLine("File deleted.");
                        break;
                    default:
                        Console.WriteLine("no file exit");
                        break;
                }
            }
        }
    }
}
