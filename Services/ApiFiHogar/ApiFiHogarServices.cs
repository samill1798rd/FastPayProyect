using Model.ApiFiHogarEntity;
using Model.ApiFiHogarEntity.Transaction;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Services.ApiFiHogar
{
    public class ApiFiHogarServices : IApiFiHogarServices
    {
        private string FirstToken;
        private string SecondToken;
        //private string CurrentAccount;
        protected const string defaultToken = "dzBMbkVNOUpYeWhNYmlBMEg4Nk9lM3FwVjVzYTpyRlRqanFUdkxOY25ZbTltSndHX0FNbVp6b2dh";
        protected const string url = "https://api.uat.4wrd.tech:8243/manage-accounts/api/2.0/accounts/";

        public ApiFiHogarServices()
        {
            GetFirstToken();
        }
        public async Task GetFirstToken()
        {
            var client = new RestClient("https://api.uat.4wrd.tech:8243/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("grant_type", "client_credentials");
            request.AddHeader("Authorization", $"Bearer {defaultToken}");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "client_credentials" +
                "");
            IRestResponse response = client.Execute(request);

            FirstToken = JsonConvert.DeserializeObject<TokenModel>(response.Content).access_token;
        }

        public async Task GetSecondToken(string username, string password)
        {
            var client = new RestClient("https://api.uat.4wrd.tech:8243/authorize/2.0/token?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", $"{username}");
            request.AddParameter("password", $"{password}");
            IRestResponse response = client.Execute(request);

            SecondToken = JsonConvert.DeserializeObject<SecondAccessToken>(response.Content).access_token;
        }


        public async Task<AccountInformation> GetAccountInformation()
        {
            var client = new RestClient($"{url}?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("token-id", $"{SecondToken}");
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return JsonConvert.DeserializeObject<AccountInformation>(response.Content);
        }

        public async Task<Transaction> GetAccountTransationsDetail(string accountNumber)
        {

            var client = new RestClient($"{url}{accountNumber}/transactions?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("token-id", $"{SecondToken}");
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            IRestResponse response = client.Execute(request);

          
            return JsonConvert.DeserializeObject<Transaction>(response.Content);
        }

        public async Task<object> CreateAccountTransfer(string currentAccount, string monto)
        {
            var client = new RestClient("https://api.uat.4wrd.tech:8243/manage-transfers/api/2.0/transfers?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            request.AddHeader("token-id", $"{SecondToken}");
            var body = GetBodyPart(currentAccount, monto);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<object>(response.Content);
        }

        public string GetBodyPart(string currentAccount, string monto)
        {
            return @"{" + "\n" +
            @"    ""Data"": {" + "\n" +
            @"        ""Initiation"": {" + "\n" +
            @"            ""InstructionType"": ""Internal""," + "\n" +
            @"            ""InstructionIdentification"": ""df96ac00-5410-4136-8fff-3ab8ec9f1fe3""," + "\n" +
            @"            ""EndToEndIdentification"": ""e1c8db3f-d8cd-4c26-b0a2-e5ef153a8653""," + "\n" +
            @"            ""InstructedAmount"": {" + "\n" +
            @"                ""Amount"":"+monto +"," + "\n" +
            @"                ""Currency"": ""USD""" + "\n" +
            @"            }," + "\n" +
            @"            ""DebtorAccount"": {" + "\n" +
            @"                ""SchemeName"": ""4WRD.AccountNumber""," + "\n" +
            @"                ""Identification"":" + currentAccount + "" + "\n" +
            @"            }," + "\n" +
            @"            ""CreditorAccount"": {" + "\n" +
            @"                ""SchemeName"": ""4WRD.AccountNumber""," + "\n" +
            @"                ""Identification"": 86376489," + "\n" +
            @"                ""Name"": ""Fast Pay""" + "\n" +
            @"            }" + "\n" +
            @"        }" + "\n" +
            @"    }," + "\n" +
            @"    ""Risk"": {" + "\n" +
            @"        ""TransferContextCode"": ""Internal Transfer""" + "\n" +
            @"    }" + "\n" +
            @"}";
        }
    }
}
