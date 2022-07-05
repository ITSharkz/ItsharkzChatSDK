using ITStreamSDK.Extensions;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using static ITStreamSDK.Model.Auth;
using ITStreamSDK.Exceptions;

namespace ITStreamSDK.SDK
{
    public class Auth : IAuth
    {
        private RestClient _cli { get; set; }
        public Auth(string _token, string host)
        {

            this._cli = new RestClient(host);
            this._cli.AddDefaultHeader("Authorization", _token);
        }

        public async Task<List<KeyPairResponse>> GetApiKeys()
        {
            RestRequest request = new RestRequest("ApiKeys", Method.Get);
            request = request.FillHeaders();
            var response = await _cli.ExecuteAsync<List<KeyPairResponse>>(request);
            if (response.Ok())
            {
                return response.Data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<WebApiError>(response.Content);
                throw new ServiceException(error.Error, error.Code);
            }
        }


        public async Task DisposeKeysPair(DisposeKeyPairRequest disposeKeyPair)
        {
            RestRequest request = new RestRequest("ApiKeys/DisposeKeysPair", Method.Patch);
            request.AddJsonBody<DisposeKeyPairRequest>(disposeKeyPair);
            var response = await _cli.ExecuteAsync(request);

            if (response.Ok())
            {
                //
            }
            else
            {
                var error = JsonConvert.DeserializeObject<WebApiError>(response.Content);
                throw new ServiceException(error.Error, error.Code);
            }

        }


        public async Task<GetApiTokenResponse> Authorize(GetApiTokenRequest apiTokenRequest)
        {
            RestRequest request = new RestRequest("ApiKeys/Authorize", Method.Post);
            request.AddJsonBody<GetApiTokenRequest>(apiTokenRequest);
            var response = await _cli.ExecuteAsync<GetApiTokenResponse>(request);

            if (response.Ok())
            {
                return response.Data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<WebApiError>(response.Content);
                throw new ServiceException(error.Error, error.Code);
            }
        }

















    }
}
