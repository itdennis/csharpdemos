using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace demo01
{
    public class Async : IDemoBase
    {
        public void Run()
        {
            AsyncVoidExceptions_CannotBeCaughtByCatch();
        }

        private async Task<HttpResponseMessage> ThrowExceptionAsync()
        {
            HttpClient httpClient = null;
            try
            {
                return await httpClient.SendAsync(new HttpRequestMessage()).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void AsyncVoidExceptions_CannotBeCaughtByCatch()
        {
            try
            {
                var response = ThrowExceptionAsync().Result;
            }
            catch (Exception)
            {
                // The exception is never caught here!
                throw;
            }
        }
    }
}
