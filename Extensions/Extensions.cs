using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITStreamSDK.Exceptions;
using RestSharp;

namespace ITStreamSDK.Extensions
{
    public static class Extensions
    {
        public static RestRequest FillHeaders(this RestRequest request)
        {
            
           
            return request;
        }

        public static bool Ok(this RestResponse response)
        {
            return response.StatusCode == System.Net.HttpStatusCode.OK;

        }
    }
}
