using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Openroom2023.UseCases.Contributors.List;

public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
