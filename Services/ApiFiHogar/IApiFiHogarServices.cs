using Model.ApiFiHogarEntity;
using System.Threading.Tasks;

namespace Services.ApiFiHogar
{
    public interface IApiFiHogarServices
    {
        void GetSecondToken(string username, string password);
        Task<AccountInformation> GetAccountInformation();
    }
}
