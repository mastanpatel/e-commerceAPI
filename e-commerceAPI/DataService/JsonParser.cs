using DataService.Models;
using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace DataService
{
    class JsonParser
    {

        //read the file
        public List<Products> loadFile()
        {

            var result = String.Empty;

            using (var client = new WebClient()) 
            {
                client.Headers.Add("Content-Type:application/json"); 
                client.Headers.Add("Accept:application/json");
                result = client.DownloadString("https://fakestoreapi.com/products");

            }

            return JsonConvert.DeserializeObject<List<Products>>(result);
        }


    }
}
