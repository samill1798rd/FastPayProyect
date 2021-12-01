﻿using Model.ApiFiHogarEntity;
using System.Threading.Tasks;
using Model.ApiFiHogarEntity.Transaction;

namespace Services.ApiFiHogar
{
    public interface IApiFiHogarServices
    {
        Task GetSecondToken(string username, string password);
        Task<AccountInformation> GetAccountInformation();
        Task<Transaction> GetAccountTransationsDetail(string accountNumber);
        Task<object> CreateAccountTransfer(string currentAccount, string monto);
    }
}
