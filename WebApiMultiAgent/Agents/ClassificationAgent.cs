using WebApiMultiAgent.Interfaces;
using WebApiMultiAgent.Models;

namespace WebApiMultiAgent.Agents
{
    public class ClassificationAgent : IAgent
    {
        public string Name => "ClassificationAgent";

        public Task<McpResponse> ExecuteAsync(McpRequest request)
        {
            string category = request.Input.ToLower().Contains("payment")
                ? "Billing"
                : "General";

            return Task.FromResult(new McpResponse
            {
                Output = category,
                Context = new Dictionary<string, object>
            {
                { "Category", category }
            }
            });
        }
    }
}
