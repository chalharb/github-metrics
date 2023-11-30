using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitHubMetics.Models
{
    [Table("WorkflowRuns")]
    public class WorkflowRun
    {
        public int Id { get; set; }
        public required int ActorId { get; set; }
        public required string Name { get; set; }
        public required string NodeId { get; set; }
        public required string HeadBranch { get; set; }
        public required string HeadSha { get; set; }
        public required string Path { get; set; }
        public required string DisplayTitle { get; set; }
        public required int RunNumber { get; set; }
        public required string Event { get; set; }
        public required string Status { get; set; }
        public required string Conclusion { get; set; }
        public required int WorkflowId { get; set; }
        public required int CheckSuiteId { get; set; }
        public required string CheckSuiteNodeId { get; set; }
        public required string Url { get; set; }
        public required string HtmlUrl { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Workflow? Workflow { get; set; }
        public required User User { get; set; }
    }
}
