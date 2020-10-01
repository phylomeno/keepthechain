using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KeepTheChain.Chains
{
    public class Chain
    {
        [JsonProperty(PropertyName = "entries")]
        public IEnumerable<DateTime> Entries;

        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
    }
}
