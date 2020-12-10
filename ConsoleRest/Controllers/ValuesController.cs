using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;

namespace ConsoleRest.Controllers
{
   [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
   // [EnableCors(origins: "http://localhost", headers: "*", methods: "GET,POST")]
    public class ValuesController : ApiController
    {
        Crud crud = new Crud();
        // [HttpGet]
        //public string[] GetValues()
        //{
        //    crud.ReadFile();
        //    return new string[]
        //    {
        //        "hello"
        //    };
        //}
        [HttpGet]
        public void CreateFile()
        {          
            crud.CreateFile();
            Console.WriteLine("file Created");
        }
        [HttpGet]
        public string ReadFile()
        {
            string text;
            text = crud.ReadFile();
            Console.WriteLine("file read " +text);
            return text;
        }
        [HttpPost]
        public string UpdateFile([FromBody] Text text)
        {
            //string s = Console.ReadLine();
            string r = crud.UpdateFile(text.text);
            Console.WriteLine("File got updated " + r);
            return r;           
        }
        [HttpGet]
        public void DeleteFile()
        {
            crud.DeleteFile();
            Console.WriteLine("File deleted.");
        }
    }
    public class Text
    {
        public string text { get; set; }
    }
}
