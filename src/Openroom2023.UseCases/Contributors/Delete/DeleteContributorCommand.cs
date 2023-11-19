using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Openroom2023.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
