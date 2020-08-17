namespace Factoring.Cli.Client.Models
{
    public class TokenResponse
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string names { get; set; }
        public string lastName1 { get; set; }
        public string lastName2 { get; set; }
        public string phone { get; set; }
        public string direction { get; set; }
        public string dni { get; set; }
        public string accessToken { get; set; }
    }
}
