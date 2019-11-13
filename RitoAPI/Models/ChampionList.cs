using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RitoAPI.Models
{
    public class ChampionList
    {
        public String id;
        public String title;
        public Dictionary<string, ChampionList> Data { get; set; }
        public ChampionList(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

    }
}
