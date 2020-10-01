using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace KeepTheChain.Chains
{
    public class ChainRepository
    {
        private const string DatabaseId = "keepthechain";
        private const string ContainerId = "chains";

        private readonly Container _chainsContainer;

        public ChainRepository(CosmosClient cosmosClient)
        {
            _chainsContainer = cosmosClient.GetContainer(DatabaseId, ContainerId);
        }

        public async Task<Chain> AddChain(Chain chain)
        {
            await _chainsContainer.CreateItemAsync(chain);
            return chain;
        }

        public IList<Chain> GetChains()
        {
            return _chainsContainer.GetItemLinqQueryable<Chain>(true).GetEnumerator().ToEnumerable().ToList();
        }

        public async Task<Chain> GetChain(string id)
        {
            var response = await _chainsContainer.ReadItemAsync<Chain>(id, new PartitionKey(id));
            return response.Resource;
        }

        public async Task RemoveChain(string id)
        {
            await _chainsContainer.DeleteItemAsync<Chain>(id, new PartitionKey(id));
        }
    }
}