using Openroom2023.Core.ContributorAggregate;
using Xunit;

namespace Openroom2023.IntegrationTests.Data;

public class EfRepositoryAdd : BaseEfRepoTestFixture
{
  [Fact]
  public async Task AddsContributorAndSetsId()
  {
    var testContributorName = "testContributor";
    var testContributorStatus = ContributorStatus.NotSet;
    var repository = GetRepository();
    var Contributor = new Contributor(testContributorName);

    await repository.AddAsync(Contributor);

    var newContributor = (await repository.ListAsync())
                    .FirstOrDefault();

    Assert.Equal(testContributorName, newContributor?.Name);
    Assert.Equal(testContributorStatus, newContributor?.Status);
    Assert.True(newContributor?.Id > 0);
  }
}
