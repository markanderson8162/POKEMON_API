﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class Root
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }

    public class Abilities
	{
        public string name { get; set; }
	}
    
}
