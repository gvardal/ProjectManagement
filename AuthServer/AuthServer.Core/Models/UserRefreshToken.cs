namespace AuthServer.Core.Models
{
    public class UserRefreshToken
    {
        public string UserId { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }
    }
}
