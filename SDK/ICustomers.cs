using ITStreamSDK.Model;

namespace ITStreamSDK.SDK
{
    public interface ICustomers
    {
        Task<StringIdResponse> CreateCustomer(CreateCustomerRequest createCustomer);
        Task Demand500();
        Task<CustomerKeyResponse> GetCustomerToken(string CustomerId);
        Task<ListCustomersResponse> ListCustomers();
    }
}