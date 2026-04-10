namespace WebApiMultiAgent.Models
{
    public class McpRequest
    {
        public string AgentName { get; set; }
        public string Input { get; set; }
        public Dictionary<string, object> Context { get; set; } = new();
    }
}
