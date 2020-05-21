using System;
using System.Security.Cryptography;
using GeetHub.Domain.Enums;

namespace GeetHub.Domain
{
    public class Issue
    {
        public Issue(Guid authorId, string description)
        {
            Id = Guid.NewGuid();
            Status = IssueStatus.Open;
            AuthorId = authorId;
            Description = description;
        }

        public Guid Id { get; set; }

        public IssueStatus Status { get; set; }

        public Guid AuthorId { get; set; }

        public string Description { get; set; }
    }
}