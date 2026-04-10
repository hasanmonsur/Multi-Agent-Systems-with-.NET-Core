namespace WebApiMultiAgent.Models
{
    public class McpResponse
    {
        public string Output { get; set; }
        public Dictionary<string, object> Context { get; set; } = new();
    }
}
