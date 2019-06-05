using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class Planet
    {
        public string Name { get; set; }

        public Planet(string APIText)
        {
            JObject personObject = JObject.Parse(APIText);

            if (personObject != null)
            {
                Name = personObject["name"].ToString();
            }
        }
    }
}