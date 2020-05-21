using System;
using GeetHub.Repositories;
using NUnit.Framework;

namespace GeetHub.Services.UnitTests
{
    public class RepoServiceTests
    {
        [Test]
        public void CreateAndFindRepository()
        {
            // Arrange
            var repoName = "TestRepo";
            var repoService = new RepoService(new MockRepoRepository());
            
            // Act
            var createdRepoId = repoService.Create(repoName);

            var actualRepo = repoService.Find(createdRepoId);

            // Assert
            Assert.AreEqual(repoName, actualRepo.Name);
        }

        [Test]
        public void CreateAndDeleteRepository()
        {
            // Arrange
            var repoService = new RepoService(new MockRepoRepository());
            
            // Act
            var createdRepoId = repoService.Create("repo");

            var deletionResult = repoService.Delete(createdRepoId);

            // Assert
            Assert.IsTrue(deletionResult);
        }

        [Test]
        public void FindNotExistingRepository()
        {
            // Arrange
            var repoService = new RepoService(new MockRepoRepository());
            
            // Act
            var result = repoService.Find(Guid.NewGuid());

            // Assert
            Assert.IsNull(result);
        }
    }
}