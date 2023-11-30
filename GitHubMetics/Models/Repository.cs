using System.ComponentModel.DataAnnotations;

namespace GitHubMetics.Models
{
    public class Repository
    {
        [Key]
        public required int Id { get; set; }
        public required string NodeId { get; set; }
        public required string Name { get; set; }
        public required string FullName { get; set; }
        public required string HtmlUrl { get; set; }
        public required string Description { get; set; }
        public required string Url { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }
        public required DateTime PushedAt { get; set; }
    }
}
