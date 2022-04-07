using System;
using System.Net.Http;
using Newtonsoft.Json;
using ClassWork_04_07_2022.Models;
using System.Collections.Generic;

namespace ClassWork_04_07_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string myLink = @"https://jsonplaceholder.typicode.com/users";

            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync(myLink).Result;
            string responseJsonStr = response.Content.ReadAsStringAsync().Result;

            List<Info> info = JsonConvert.DeserializeObject<List<Info>>(responseJsonStr);

            foreach (var item in info)
            {
                Console.WriteLine(item);
            }
        }
    }
}
