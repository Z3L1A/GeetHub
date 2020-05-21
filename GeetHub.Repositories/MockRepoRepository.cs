using System;
using System.Collections.Generic;
using GeetHub.Domain;

namespace GeetHub.Repositories
{
    public class MockRepoRepository : IRepoRepository
    {
        private static readonly Dictionary<Guid, Repository> _repos = new Dictionary<Guid, Repository>();

        public bool Delete(Guid repoId)
        {
            if (_repos.ContainsKey(repoId))
            {
                return _repos.Remove(repoId);
            }

            return false;
        }

        public void Upsert(Repository repo)
        {
            if (_repos.ContainsKey(repo.Id))
            {
                _repos[repo.Id] = repo;
            }
            else
            {
                _repos.Add(repo.Id, repo);
            }
        }

        public Repository Find(Guid repoId)
        {
            if (_repos.TryGetValue(repoId, out var repo))
            {
                return repo;
            }

            return null;
        }
    }
}
