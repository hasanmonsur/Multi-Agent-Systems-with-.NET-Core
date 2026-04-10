using WebApiMultiAgent.Models;

namespace WebApiMultiAgent.Interfaces
{
    public interface IAgent
    {
        string Name { get; }
        Task<McpResponse> ExecuteAsync(McpRequest request);
    }
}
