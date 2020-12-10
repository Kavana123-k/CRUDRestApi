using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace RestClient
{
    class CrudCleint
    {
        private static readonly string urlParameters;
        public static string URL = ConfigurationManager.AppSettings["URL"].ToString();
        public void CreateFile()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL + "CreateFile");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            }
            catch (Exception)
            {
                //Console.WriteLine("create error" + ex.Message);
            }
        }
        public string ReadFile()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL + "ReadFile");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            }
            catch (Exception)
            {
                //Console.WriteLine("create error" + ex.Message);
            }
            return " ";
        }
        public string UpdateFile(String s)
        {
            try
            {
                HttpClient client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(new { text = s }), Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(URL + "UpdateFile", content).Result;// new Uri(URL + "UpdateFile", content);
                string resp = Convert.ToString(response);
                return resp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("create error" + ex.Message);
            }
            return " ";
        }
        public void DeleteFile()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL + "DeleteFile");
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            }
            catch (Exception)
            {
                //Console.WriteLine("create error" + ex.Message);
            }
        }

    }
}
