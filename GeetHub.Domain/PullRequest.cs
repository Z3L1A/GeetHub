using System;
using GeetHub.Domain.Enums;

namespace GeetHub.Domain
{
    public class PullRequest
    {
        public PullRequest(string name, Guid authorId)
        {
            Id = Guid.NewGuid();
            Status = PullRequestStatus.Open;
            Name = name;
            AuthorId = authorId;
        }

        public Guid Id { get; }

        public PullRequestStatus Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid AuthorId { get; set; }

        public Guid AssigneeId { get; set; }
    }
}