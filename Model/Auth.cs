using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStreamSDK.Model
{
    public class Auth
    {
        public class ChangePasswordRequest
        {
            public string CurrentPassword { get; set; }
            public string NewPassword { get; set; }
        }

        public class GetAuthTokenResponse : UserResponse
        {
            public string AuthToken { get; set; }

        }
        public class GetAuthTokenRequest
        {
            [EmailAddress]
            public string Login { get; set; }
            public string Password { get; set; }
        }


        public class ResetPasswordRequest
        {
            private string _login { get; set; }
            [EmailAddress]

            public string Login
            {
                get
                {
                    return _login;
                }
                set
                {
                    _login = value.ToLower().Replace(" ", "");
                }
            }
        }
        public class ResendTokenRequest
        {
            private string _login { get; set; }
            [EmailAddress]

            public string Login
            {
                get
                {
                    return _login;
                }
                set
                {
                    _login = value.ToLower().Replace(" ", "");
                }
            }
        }

        public class CreateTokenForEmail
        {
            private string _login { get; set; }
            [EmailAddress]

            public string Login
            {
                get
                {
                    return _login;
                }
                set
                {
                    _login = value.ToLower().Replace(" ", "");
                }
            }
        }


        public class LogoutRequest
        {
            public string Token { get; set; }
        }

        public class ConfirmResetPasswordRequest
        {
            public string Token { get; set; }
            public string Password { get; set; }
        }



        public class KeyPairResponse
        {
            public string Key { get; set; }
            public string Secret { get; set; }
            public DateTime ValidTo { get; set; }

        }


        public class DisposeKeyPairRequest
        {
            public string Key { get; set; }
        }

        public class GetApiTokenRequest
        {
            public string Secret { get; set; }
            public string Key { get; set; }
        }

        public class GetApiTokenResponse
        {
            public string Token { get; set; }
        }



    }
}
