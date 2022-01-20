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
    public class Customers : ICustomers
    {
        private RestClient _cli { get; set; }
        public Customers(string _token, string host)
        {
            this._cli = new RestClient(host);
            this._cli.AddDefaultHeader("Authorization", _token);
        }
        public async Task<StringIdResponse> CreateCustomer(CreateCustomerRequest createCustomer)
        {

            RestRequest request = new RestRequest("Customer", Method.Post);
            request.AddJsonBody<CreateCustomerRequest>(createCustomer);
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

        public async Task Demand500()
        {

            RestRequest request = new RestRequest("Customer/Demand500", Method.Post);
            //request.AddJsonBody<CreateCustomerRequest>(createCustomer);
            var response = await _cli.ExecuteAsync<StringIdResponse>(request);

            if (response.Ok())
            {
                //return response.Data;
            }
            else
            {
                var error = JsonConvert.DeserializeObject<WebApiError>(response.Content);
                throw new ServiceException(error.Error, error.Code);
            }
        }

        public async Task<CustomerKeyResponse> GetCustomerToken(string CustomerId)
        {
            RestRequest request = new RestRequest("Customer/Token", Method.Get);
            request.AddParameter("CustomerId", CustomerId);

            var response = await _cli.ExecuteAsync<CustomerKeyResponse>(request);
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

        public async Task<ListCustomersResponse> ListCustomers()
        {
            RestRequest request = new RestRequest("Customer/List", Method.Get);


            var response = await _cli.ExecuteAsync<ListCustomersResponse>(request);
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
