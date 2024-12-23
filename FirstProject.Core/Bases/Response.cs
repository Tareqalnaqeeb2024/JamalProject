using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Bases
{
    public class Response<T>
    {

        #region feilds
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Successed { get; set; }
        public object Meta { get; set; }
        public string Message { get; set; }
        #endregion

        #region Constructor
        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Successed = true;
            Message = message;
            Data = data;

        }
        public Response(string message)
        {
            Successed = false;
            Message = message;
        }
        public Response(string message, bool successed)
        {
            Message = message;
            Successed = successed;
        }
        #endregion


    }
}
