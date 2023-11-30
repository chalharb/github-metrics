using System.ComponentModel.DataAnnotations;

namespace GitHubMetics.Models
{
    public class User
    {
        [Key]
        public required int Id { get; set; }
        public required string Login { get; set; }
        public required string Url { get; set; }
    }
}
