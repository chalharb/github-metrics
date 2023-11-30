using NuGet.Protocol.Core.Types;
using SQLiteNetExtensions.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitHubMetics.Models
{
    [Table("Workflows")]
    public class Workflow
    {
        [Key]
        public required int Id { get; set; }
        public required string NodeId { get; set; }
        public required string Name { get; set; }
        public required string Path { get; set; }
        public required string State { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }
        public required string Url { get; set; }
        public required string HtmlUrl { get; set; }
        public required string BadgeUrl { get; set; }
        public required int RepositoryId { get; set; }


        [OneToMany]
        public List<WorkflowRun>? WorkflowRuns { get; set; }

        [OneToOne]
        public required Repository Repository { get; set; }
    }
}
