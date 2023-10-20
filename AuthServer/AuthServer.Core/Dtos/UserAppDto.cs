namespace AuthServer.Core.Dtos
{
    public class UserAppDto
    {
        public string Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
