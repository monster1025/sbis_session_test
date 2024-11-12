using SbisApiApp.SbisClient.Models.BasicModels;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SbisApiApp.SbisClient.Models.ResponseModel;

public sealed record ResponseGetPackageAuthor: ResponseModelBase
{
    public Result Result { get; init; }
}