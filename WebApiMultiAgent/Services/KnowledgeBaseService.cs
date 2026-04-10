namespace WebApiMultiAgent.Services
{
    public class KnowledgeBaseService
    {
        public Task<string> GetAnswerAsync(string category)
        {
            var response = category switch
            {
                "Billing" => "Please check your invoice under billing section.",
                _ => "Our support team will contact you shortly."
            };

            return Task.FromResult(response);
        }
    }
}
