using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace rest_api_udemy.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
