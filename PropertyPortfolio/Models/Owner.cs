using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PropertyPortfolio.Models
{
    public class Owner
    {
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("properties")]
        public ICollection<Property> Properties { get; set; }
    }
}