using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Openroom2023.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
