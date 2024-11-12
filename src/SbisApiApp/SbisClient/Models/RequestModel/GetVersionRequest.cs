using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.RequestModel;

public sealed record GetVersionRequest : RequestModelBase
{
    public override string Method => "СБИС.ИнформацияОВерсии";

    public GetVersionRequest()
    {
        Parametrs = new Parametrs()
        {
            Parametr = new Parametr()
        };
    }
}