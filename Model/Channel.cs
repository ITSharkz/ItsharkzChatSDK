using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSDK.Model
{
    public class CreateChannel
    {

        public string Name { get; set; }
        public List<string> InitialCustomers { get; set; }

    }
}
