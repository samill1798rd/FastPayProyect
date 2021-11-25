using System;
using System.Collections.Generic;

namespace Model.ApiFiHogarEntity
{
    public class Account
    {
        public string Status { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        public string AccountSubType { get; set; }
        public string Nickname { get; set; }
        public DateTime OpeningDate { get; set; }
        public List<AccountDetail> account { get; set; }
        public List<Balance> Balance { get; set; }
    }
}
