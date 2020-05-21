using System;
using System.Collections.Generic;

namespace GeetHub.Domain
{
    public class Repository
    {
        private Repository()
        {
            Id = Guid.NewGuid();
            Branches = new List<Branch>
            {
                new Branch("master"),
            };
            PullRequests = new List<PullRequest>();
            Issues = new List<Issue>();
        }

        public Repository(string name) : this()
        {
            Name = name;
        }

        public Guid Id { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Branch> Branches { get; set; }

        public List<PullRequest> PullRequests { get; set; }

        public List<Issue> Issues { get; set; } 
    }
}