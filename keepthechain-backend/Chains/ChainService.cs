using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KeepTheChain.Chains
{
    public class ChainService
    {
        private readonly ChainRepository _chainRepository;

        public ChainService(ChainRepository chainRepository)
        {
            _chainRepository = chainRepository;
        }

        public async Task<Chain> AddNewChain(Chain chain)
        {
            chain.Id = Guid.NewGuid().ToString();

            return await _chainRepository.AddChain(chain);
        }

        public IList<Chain> GetChains()
        {
            return _chainRepository.GetChains();
        }

        public async Task<Chain> GetChain(string id)
        {
            return await _chainRepository.GetChain(id);
        }

        public async Task RemoveChain(string id)
        {
            await _chainRepository.RemoveChain(id);
        }
    }
}