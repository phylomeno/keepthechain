using System;
using System.Collections.Generic;
using System.Linq;

namespace KeepTheChain.Chains
{
    public class ChainService
    {
        private readonly IDictionary<Guid, Chain> _chains = new Dictionary<Guid, Chain>();

        public Chain AddNewChain(Chain chain)
        {
            chain.Id = Guid.NewGuid();
            _chains[chain.Id] = chain;

            return chain;
        }

        public IList<Chain> GetChains()
        {
            return _chains.Values.ToList();
        }

        public Chain GetChain(Guid id)
        {
            return _chains.ContainsKey(id) ? _chains[id] : null;
        }

        public void RemoveChain(Guid id)
        {
            _chains.Remove(id); 
        }
    }
}