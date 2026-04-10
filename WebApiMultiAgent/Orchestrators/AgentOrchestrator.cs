using WebApiMultiAgent.Interfaces;
using WebApiMultiAgent.Models;

namespace WebApiMultiAgent.Orchestrators
{
    public class AgentOrchestrator
    {
        private readonly IEnumerable<IAgent> _agents;

        public AgentOrchestrator(IEnumerable<IAgent> agents)
        {
            _agents = agents;
        }

        public async Task<string> ProcessAsync(string input)
        {
            var context = new Dictionary<string, object>();

            // Step 1: Classification
            var classifier = _agents.First(a => a.Name == "ClassificationAgent");
            var classificationResult = await classifier.ExecuteAsync(new McpRequest
            {
                Input = input,
                Context = context
            });

            foreach (var item in classificationResult.Context)
                context[item.Key] = item.Value;

            // Step 2: Response
            var responder = _agents.First(a => a.Name == "ResponseAgent");
            var response = await responder.ExecuteAsync(new McpRequest
            {
                Input = input,
                Context = context
            });

            return response.Output;
        }
    }
}
