using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.RequestModel;

public sealed record GetPackageAuthorRequest : RequestModelBase
{
    public override string Method => "СБИС.ПрочитатьДокумент";

    public GetPackageAuthorRequest(string externalPackageId)
    {
        Parametrs = new Parametrs()
        {
            DocumentParameters = new DocumentParameters()
            {
                PackageExternalId = externalPackageId
            },
            Filter = null,
            Parametr = null
        };
    }
}