using System;
using System.Collections.Generic;

namespace GeetHub.Domain
{
    public sealed class Branch
    {
        private Branch()
        {
            Id = Guid.NewGuid();
            Commits = new List<Commit>();
        }

        public Branch(string name) : this()
        {
            Name = name;
        }

        public Guid Id { get; }

        public Guid RepositoryId { get; set; }

        public string Name { get; set; }

        public List<Commit> Commits { get; set; }
    }
}