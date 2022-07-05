using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITStreamSDK.Model
{
    public class CreateKeyForCustomerRequest
    {
        public string CustomerId { get; set; }
    }

    public class CustomerKeyResponse
    {
        public string Key { get; set; }
    }

    public class StringIdResponse
    {
        public string Id { get; set; }
    }

    public class CustomerResponse
    {
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public string Id { get; set; }
        public string Tag { get; set; }
        public DateTime Created { get; set; }
        public List<string> Channels { get; set; }
        public List<string> Moderator { get; internal set; }
    }

    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Tag { get; set; }

    }
}
