using rest_api_udemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace rest_api_udemy.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
