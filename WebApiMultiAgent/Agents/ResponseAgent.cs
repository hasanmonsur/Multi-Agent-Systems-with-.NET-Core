using WebApiMultiAgent.Interfaces;
using WebApiMultiAgent.Models;
using WebApiMultiAgent.Services;

namespace WebApiMultiAgent.Agents
{
    public class ResponseAgent : IAgent
    {
        private readonly KnowledgeBaseService _kb;

        public ResponseAgent(KnowledgeBaseService kb)
        {
            _kb = kb;
        }

        public string Name => "ResponseAgent";

        public async Task<McpResponse> ExecuteAsync(McpRequest request)
        {
            var category = request.Context["Category"].ToString();
            var answer = await _kb.GetAnswerAsync(category);

            return new McpResponse
            {
                Output = answer
            };
        }
    }
}
