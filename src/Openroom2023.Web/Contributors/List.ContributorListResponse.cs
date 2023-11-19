using Openroom2023.Web.ContributorEndpoints;

namespace Openroom2023.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
