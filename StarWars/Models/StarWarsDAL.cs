using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace StarWars.Models
{
    public class StarWarsDAL
    {
        public static string GetData(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //Supported browsers. Some aservers will not work without the this
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Response succeed
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader data = new StreamReader(response.GetResponseStream());
                //JObject weatherData = JObject.Parse(data.ReadToEnd());
                return data.ReadToEnd();
            }

                return "";
        }

        public static Person GetPerson(int i)
        {
            string APIText = GetData($"https://swapi.co/api/people/{i}/");

            return new Person(APIText);
        }

        public static Planet GetPlanet(int i)
        {
            string APIText = GetData($"https://swapi.co/api/planets/{i}/");

            return new Planet(APIText);
        }
    }
}