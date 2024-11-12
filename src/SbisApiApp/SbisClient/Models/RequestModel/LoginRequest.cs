using SbisApiApp.SbisClient.Models.BasicModels;

namespace SbisApiApp.SbisClient.Models.RequestModel
{
    public sealed record LoginRequest : RequestModelBase
    {
        public override string Method => "СБИС.Аутентифицировать";

        public LoginRequest(string login, string password)
        {
            Parametrs = new Parametrs()
            {
                Parametr = new Parametr() { Login = login, Password = password }
            };
        }
    }
}
