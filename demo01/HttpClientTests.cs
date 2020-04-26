using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace demo01
{
    public class HttpClientTests : IDemoBase
    {
        public void Run()
        {
            throw new NotImplementedException();
        }


        //public async Task TestHttpResponseErrorMsg(string id)
        //{
        //    var accept = Request.GetTypedHeaders().Accept;
        //    var result = await _valuesService.Get(id);
        //    var data = Encoding.UTF8.GetBytes(result);
        //    if (accept.Any(x => x.MediaType == "text/html"))
        //    {
        //        Response.ContentType = "text/html";
        //    }
        //    else
        //    {
        //        Response.ContentType = "text/plain";
        //    }
        //    await Response.Body.WriteAsync(data, 0, data.Length);
        //}
    }
}
