using ChatSDK.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSDK.SDK
{
    public class ChatService : IChatService
    {
        public IAuth Auth { get; set; }
        public ICustomers Customers { get; set; }
        private string _token { get; set; }
        private string _host { get; set; }
        public ChatService(string Token, Environment environment)
        {
            _token = Token;

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

            }

            this.Auth = new Auth(_token, _host);
            this.Customers = new Customers(_token, _host);

        }

        public void UpdateToken(string token)
        {
            this._token = token;
            this.Auth = new Auth(token, _host);
            this.Customers = new Customers(_token, _host);

        }
        public enum Environment { Dev, Prod, Localhost }




    }
}
