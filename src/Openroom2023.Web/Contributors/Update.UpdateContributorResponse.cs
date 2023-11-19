using Openroom2023.Web.ContributorEndpoints;

namespace Openroom2023.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
