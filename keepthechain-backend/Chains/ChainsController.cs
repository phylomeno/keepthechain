using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult<Chain>> GetChain(string id)
        {
            return await _chainService.GetChain(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Chain>> GetChains()
        {
            return _chainService.GetChains().ToList();
        }

        [HttpPost]
        public async Task<ActionResult<Chain>> AddChain(Chain chain)
        {
            var createdChain = await _chainService.AddNewChain(chain);

            return CreatedAtAction(nameof(GetChain), new { id = createdChain.Id }, createdChain);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Chain>> DeleteChain(string id)
        {
            var chain = await _chainService.GetChain(id);
            if (chain == null)
            {
                return NotFound();
            }
            
            await _chainService.RemoveChain(id);

            return chain;
        }
    }
}
