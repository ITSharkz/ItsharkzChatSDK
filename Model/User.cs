using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSDK.Model
{
    public class CreateUserRequest
    {
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? CompanyName { get; set; }
        public string Password { get; set; }
    }
    public class UserResponse
    {
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? CompanyName { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
    }


    public class ListCustomersResponse
    {
        public List<CustomerPublicResponse> items { get; set; }
    }

    public class CustomerPublicResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public bool Online { get; set; }

    }
}
