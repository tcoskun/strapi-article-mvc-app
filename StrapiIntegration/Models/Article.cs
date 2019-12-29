using Newtonsoft.Json;
using System;

namespace StrapiIntegration.Models
{
    [Serializable]
    public class Article
    {
        [JsonProperty("id")]
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreateDate { get; set; }
    }
}