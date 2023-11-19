using Openroom2023.Core.ContributorAggregate;
using Xunit;

namespace Openroom2023.UnitTests.Core.ContributorAggregate;

public class ContributorConstructor
{
  private readonly string _testName = "test name";
  private Contributor? _testContributor;

  private Contributor CreateContributor()
  {
    return new Contributor(_testName);
  }

  [Fact]
  public void InitializesName()
  {
    _testContributor = CreateContributor();

    Assert.Equal(_testName, _testContributor.Name);
  }
}
