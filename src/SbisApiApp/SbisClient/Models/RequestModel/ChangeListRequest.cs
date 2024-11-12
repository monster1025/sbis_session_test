using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.RequestModel
{
    public sealed record ChangeListRequest : RequestModelBase
    {
        public override string Method => "СБИС.СписокИзменений";

        public ChangeListRequest(string inn, string kpp, DateTime? dateFrom = null)
        {
            Parametrs = new Parametrs()
            {
                Filter = new Filter()
                {
                    DateFrom = dateFrom,
                    OurOrganization = new OurOrganization()
                    {
                        LegalEntity = new LegalEntity()
                        {
                            Inn = inn,
                            Kpp = kpp,
                        }
                    }
                }
            };
        }
    }
}
