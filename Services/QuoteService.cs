using ASP_MVC_Library.Models;
using ASP_MVC_Library.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ASP_MVC_Library.Services
{
    public class QuoteService : IQuoteInterface
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public QuoteService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<QuoteResponseModel> GetQuotesByAuthor(string author, int limit)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetStringAsync($"https://api.quotable.io/quotes?author={author}&limit={limit}");

            return JsonConvert.DeserializeObject<QuoteResponseModel>(response);
        }
    }
}
