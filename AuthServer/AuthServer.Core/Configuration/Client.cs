namespace AuthServer.Core.Configuration
{
    public class Client
    {
        public string Id { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public List<string> Audiences { get; set; } = new();
    }
}
