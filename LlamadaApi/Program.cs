using System;
using System.Net;
using Newtonsoft.Json;

namespace LlamadaApi
{

    class Program
    {

        static void Main(string[] args)
        {
            string API_url = "https://jsonplaceholder.typicode.com/posts?_limit=5";
            var client = new WebClient(); //guarda un objeto
            var json = client.DownloadString(API_url); // trae los datos de la api en formato Json
            Console.WriteLine(json);// muestro los datos que traigo de la api
            dynamic datas = JsonConvert.DeserializeObject(json);// des-serializo el objeto ,para luego poder llamar de a un valor
            foreach (var data in datas)// recorro el arreglo donde tengo los registros
            {
                Console.WriteLine(data.id + ": " + data.title);// solo muestro el id y el title
            }
        }
    }


}