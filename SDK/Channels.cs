using ChatSDK.Exceptions;
using ChatSDK.Extensions;
using ChatSDK.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSDK.SDK
{
    public class Channels : IChannels
    {
        private RestClient _cli { get; set; }
        public Channels(string _token, string host)
        {
            this._cli = new RestClient(host);
            this._cli.AddDefaultHeader("Authorization", _token);
        }

        public async Task<StringIdResponse> Create(CreateChannel createChannel)
        {
            RestRequest request = new RestRequest("Channel", Method.Post);
            request.AddJsonBody<CreateChannel>(createChannel);
            var response = await _cli.ExecuteAsync<StringIdResponse>(request);

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
