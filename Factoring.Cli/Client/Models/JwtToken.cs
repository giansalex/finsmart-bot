using System.Collections.Generic;

namespace Factoring.Cli.Client.Models
{
    public class JwtToken
    {
        public string iss { get; set; }
        public string aud { get; set; }
        public string sub { get; set; }
        public int exp { get; set; }
        public List<string> rol { get; set; }
    }
}
