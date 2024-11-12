#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.ResponseModel
{
    public sealed record ResponseGetDocuments : ResponseModelBase
    {
        public Result Result { get; init; }
    }
}
