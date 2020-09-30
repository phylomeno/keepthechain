using System;
using System.Collections.Generic;

namespace KeepTheChain.Chains
{
    public class Chain
    {
        public IEnumerable<DateTime> Entries;

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
