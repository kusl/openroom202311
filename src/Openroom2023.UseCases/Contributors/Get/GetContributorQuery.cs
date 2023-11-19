using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Openroom2023.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
