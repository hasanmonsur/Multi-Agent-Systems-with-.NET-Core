using Microsoft.AspNetCore.Mvc;
using WebApiMultiAgent.Orchestrators;

namespace WebApiMultiAgent.Controllers
{
    [ApiController]
    [Route("api/ticket")]
    public class TicketController : ControllerBase
    {
        private readonly AgentOrchestrator _orchestrator;

        public TicketController(AgentOrchestrator orchestrator)
        {
            _orchestrator = orchestrator;
        }

        [HttpPost]
        public async Task<IActionResult> Process([FromBody] string input)
        {
            var result = await _orchestrator.ProcessAsync(input);
            return Ok(result);
        }
    }
}
