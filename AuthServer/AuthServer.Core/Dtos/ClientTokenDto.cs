namespace AuthServer.Core.Dtos
{
    public class ClientTokenDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public DateTime AccessTokenExpiration { get; set; }
    }
}
