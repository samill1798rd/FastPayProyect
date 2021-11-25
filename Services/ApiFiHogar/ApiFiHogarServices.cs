using Model.ApiFiHogarEntity;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.ApiFiHogar
{
    public class ApiFiHogarServices : IApiFiHogarServices
    {
        private string FirstToken;
        private string SecondToken;
        protected const string defaultToken = "dzBMbkVNOUpYeWhNYmlBMEg4Nk9lM3FwVjVzYTpyRlRqanFUdkxOY25ZbTltSndHX0FNbVp6b2dh";

        public ApiFiHogarServices()
        {
            GetFirstToken();
        }
        public void GetFirstToken()
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
            var modelResult = JsonConvert.DeserializeObject<TokenModel>(response.Content);

            FirstToken = modelResult.access_token;
        }

        public void GetSecondToken(string username, string password)
        {

            var client = new RestClient("https://api.uat.4wrd.tech:8243/authorize/2.0/token?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", "fast_1");
            request.AddParameter("password", "fast_1");
            IRestResponse response = client.Execute(request);


            var modelResult = JsonConvert.DeserializeObject<SecondAccessToken>(response.Content);
            SecondToken = modelResult.access_token;
        }


        public async Task<AccountInformation> GetAccountInformation()
        {
            var client = new RestClient("https://api.uat.4wrd.tech:8243/manage-accounts/api/2.0/accounts/?provider=AB4WRD");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("token-id", $"{SecondToken}");
            request.AddHeader("Authorization", $"Bearer {FirstToken}");
            //request.AddHeader("", "");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            var modelResult = JsonConvert.DeserializeObject<AccountInformation>(response.Content);

            return modelResult;


        }
    }
}
