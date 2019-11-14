using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitoAPI.Models
{
    public class Champion
    {
        public Champion(string json, string id)
        {
            JObject jObject = JObject.Parse(json);
            JToken jData = jObject["data"];
            JToken jChampion = jData[id];
            this.id = id;
            title = (string)jChampion["title"];
            lore = (string)jChampion["lore"];
        }

        public string id { get; set; }
        public string title { get; set; }
        public string lore { get; set; }


    }
}
