using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyPortfolio.Models
{
    public class Property
    {
        public Guid Id { get; set; }
        [ForeignKey("Id")]
        public Guid OwnerId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type {get;set;}
    }
}