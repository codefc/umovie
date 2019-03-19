using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Umovie.Services.Handlers
{
    public class MovieHttpClientHandler : HttpClientHandler
    {
        private string _apiKey;

        public MovieHttpClientHandler(string apiKey)
        {
            _apiKey = apiKey;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

           

            return base.SendAsync(request, cancellationToken);
        }
    }
}
