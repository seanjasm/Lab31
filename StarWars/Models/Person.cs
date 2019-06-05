using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWars.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string HomePlanet { get; set; }

        public Person(string APIText)
        {
            JObject personObject = JObject.Parse(APIText);

            if (personObject != null)
            {
                JObject specie = JObject.Parse(StarWarsDAL.GetData(personObject["species"][0].ToString()));
                JObject homeWorld = JObject.Parse(StarWarsDAL.GetData(personObject["homeworld"].ToString()));

                Name = personObject["name"].ToString();
                Species = specie["name"].ToString();
                
                Gender = personObject["gender"].ToString();
                HomePlanet = homeWorld["name"].ToString();
            }
        }
    }
}