﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace KeepTheChain.Chains
{
    [ApiController]
    [Route("[controller]")]
    public class ChainsController : ControllerBase
    {
        private readonly ChainService _chainService;

        public ChainsController(ChainService chainService)
        {
            _chainService = chainService;
        }

        [HttpGet("{id}")]
        public ActionResult<Chain> GetChain(Guid id)
        {
            return _chainService.GetChain(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Chain>> GetChains()
        {
            return _chainService.GetChains().ToList();
        }

        [HttpPost]
        public ActionResult<Chain> AddChain(Chain chain)
        {
            var createdChain = _chainService.AddNewChain(chain);

            return CreatedAtAction(nameof(GetChain), new { id = createdChain.Id }, createdChain);
        }

        [HttpDelete("{id}")]
        public ActionResult<Chain> DeleteChain(Guid id)
        {
            var chain = _chainService.GetChain(id);
            if (chain == null)
            {
                return NotFound();
            }
            
            _chainService.RemoveChain(id);

            return chain;
        }
    }
}
