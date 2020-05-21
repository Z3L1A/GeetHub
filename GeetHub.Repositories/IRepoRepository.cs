using System;
using GeetHub.Domain;

namespace GeetHub.Repositories
{
    public interface IRepoRepository
    {
        bool Delete(Guid repoId);

        void Upsert(Repository repo);

        Repository Find(Guid repoId);
    }
}