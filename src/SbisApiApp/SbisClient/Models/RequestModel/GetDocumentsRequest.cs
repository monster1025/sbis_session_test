using SbisApiApp.SbisClient.Enums;
using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.RequestModel
{
    public sealed record GetDocumentsRequest : RequestModelBase
    {
        public override string Method => "СБИС.СписокДокументов";

        public GetDocumentsRequest(string inn, string kpp, DocumentType documentType, DateTime? dateFrom = null, int page = 0, int pageSize = 200)
        {
            Parametrs = new Parametrs()
            {
                Filter = new Filter()
                {
                    DateFrom = dateFrom,
                    DocumentType = documentType,
                    OurOrganization = new OurOrganization()
                    {
                        LegalEntity = new LegalEntity()
                        {
                            Inn = inn,
                            Kpp = kpp,
                        }
                    },
                    Navigation = new Navigation()
                    {
                        Page = page,
                        PageSize = pageSize
                    }
                }
            };
        }
    }
}
