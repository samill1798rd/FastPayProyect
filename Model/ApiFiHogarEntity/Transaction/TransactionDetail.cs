using System;

namespace Model.ApiFiHogarEntity.Transaction
{
    public class TransactionDetail
    {
        public string AccountId { get; set; }
        public string TransactionId { get; set; }
        public string TransactionReference { get; set; }
        public string CreditDebitIndicator { get; set; }
        public string Status { get; set; }
        public DateTime BookingDateTime { get; set; }
        public string TransactionInformation { get; set; }
        public Amount Amount { get; set; }
        public BankTransactionCode BankTransactionCode { get; set; }
    }
}
