using Model.ApiFiHogarEntity;
using System.Threading.Tasks;
using Model.ApiFiHogarEntity.Transaction;

namespace Services.ApiFiHogar
{
    public interface IApiFiHogarServices
    {
        void GetSecondToken(string username, string password);
        Task<AccountInformation> GetAccountInformation();
        Task<Transaction> GetAccountTransationsDetail(string accountNumber);
    }
}
