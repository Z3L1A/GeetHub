using System;
using GeetHub.Domain;
using GeetHub.Repositories;

namespace GeetHub.Services
{
    public class RepoService
    {
        private readonly IRepoRepository _repository;

        public RepoService(IRepoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Guid Create(string name, string description = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Parameter should not be empty", nameof(name));
            }

            var repository = new Repository(name)
            {
                Description = description,
            };

            _repository.Upsert(repository);

            return repository.Id;
        }

        public Repository Find(Guid repoId)
        {
            return _repository.Find(repoId);
        }

        public bool Delete(Guid repoId)
        {
            return _repository.Delete(repoId);
        }
    }
}
