using Model.ApiFiHogarEntity;
using System.Threading.Tasks;
using Model.ApiFiHogarEntity.Transaction;

namespace Services.ApiFiHogar
{
    public interface IApiFiHogarServices
    {
        //genera el segundo token
        Task GetSecondToken(string username, string password);
        //obtiene la informacion de la cuenta actual
        Task<AccountInformation> GetAccountInformation();
        //obtiene las transaciones de la cuenta actual
        Task<Transaction> GetAccountTransationsDetail(string accountNumber);
        //crea transacione de la cuenta actual a otra cuenta
        Task<object> CreateAccountTransfer(string currentAccount, string monto);
    }
}
