using ASP_MVC_Library.Models;
using System.Threading.Tasks;

namespace ASP_MVC_Library.Services.Interfaces
{
    public interface IQuoteInterface
    {
        Task<QuoteResponseModel> GetQuotesByAuthor(string author, int limit);
    }
}
