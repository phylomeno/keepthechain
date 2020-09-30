using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace KeepTheChain
{
    public class Chain {
        [JsonProperty("id")]
        public System.Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

  public static class GetChains
    {
        [FunctionName("GetChains")]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            [CosmosDB(
                databaseName: "keepthechain",
                collectionName: "chains",
                ConnectionStringSetting = "CosmosDBConnection",
                SqlQuery = "SELECT * FROM c")]
                IEnumerable<Chain> chains,
            ILogger log)
        {
            var json = JsonConvert.SerializeObject(chains);

            return new HttpResponseMessage(HttpStatusCode.OK) {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }
    }
}
