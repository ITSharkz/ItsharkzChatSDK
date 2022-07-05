using ITStreamSDK.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStreamSDK.SDK
{
    public class ITStreamService : IITStreamService
    {
        public IAuth Auth { get; set; }
        public ICustomers Customers { get; set; }
        public IChannels Channels { get; set; }
        private string _apiKey { get; set; }
        private string _apiSecret { get; set; }
        private string _host { get; set; }
        private static string _token { get; set; }
        private Environment _environment { get; set; }
        public ITStreamService(string key, string secret, Environment environment)
        {
            _apiKey = key;
            _apiSecret = secret;

            switch (environment)
            {
                case Environment.Dev:
                    this._host = "https://chat.itsharkz.com/api/";
                    break;
                case Environment.Localhost:
                    this._host = "http://127.0.0.1:5010/api/";
                    break;
                case Environment.Prod:
                    throw new ServiceException("Not available.");
                case Environment.Not_set:
                    this._host = "https://service.itstream.app/";
                    throw new ServiceException("Not available.");

            }


            this.Auth = new Auth("", _host);

            var tokenService = this.Auth.Authorize(new Model.Auth.GetApiTokenRequest { Key = _apiKey, Secret = _apiSecret });
            tokenService.Wait();

            _token = tokenService.Result.Token;


            this.Auth = new Auth(_token, _host);
            this.Customers = new Customers(_token, _host);
            this.Channels = new Channels(_token, _host);



        }


        public async Task UpdateToken()
        {
            var response = await Auth.Authorize(new Model.Auth.GetApiTokenRequest { Key = _apiKey, Secret = _apiSecret });
            _token = response.Token;
            this.Auth = new Auth(_token, _host);
            this.Customers = new Customers(_token, _host);
            this.Channels = new Channels(_token, _host);

        }


        public enum Environment { Not_set, Dev, Prod, Localhost }




    }
}
