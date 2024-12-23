using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Core.Bases
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {

        }

        public Response<T> Delete<T>(string message = null)
        {
            return new Response<T>
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Successed = true,
                Message = message == null ? "Deleted Successfuly" : message
            };
        }


        public Response<T> Success<T>(T entity, object meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Successed = true,
                Message = " Get  Successfuly",
                Meta = meta


            };
        }

        public Response<T> Unauthorized<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Successed = true,
                Message = "UnAuthorized"
            };
        }

        public Response<T> BadRequest<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Successed = false,
                Message = message == null ? "Bad Request" : message
            };
        }

        public Response<T> UnProcessableEntity<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Successed = false,
                Message = message == null ? "Bad Request" : message
            };
        }

        public Response<T> NotFound<T>(string message = null)

        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Successed = false,
                Message = message == null ? "Not Found" : message

            };
        }

        public Response<T> Created<T>(T entity, object meta = null)
        {
            return new Response<T>
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Successed = true,
                Message = "Created",
                Meta = meta
            };
        }
    }
}
