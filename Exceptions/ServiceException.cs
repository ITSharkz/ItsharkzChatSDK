using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ITStreamSDK.Exceptions.ServiceException;

namespace ITStreamSDK.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceException(string message, ServiceExceptionState status) : base(message)
        {
            this.ExceptionStatus = status;
        }
        public ServiceException(string message) : base(message)
        {
            this.ExceptionStatus = ServiceExceptionState.Internal;
        }
        public ServiceExceptionState ExceptionStatus;

        public enum ServiceExceptionState
        {
            Internal,
            NotFound,
            Unauthorized
        }

    }
    public class WebApiError
    {
        public string Error { get; set; }
        public ServiceExceptionState Code { get; set; }
        public string CodeString { get; set; }

    }
}
