using AutoMapper;
using WebScraper.Application.Models;
using WebScraper.Data.Models;

namespace WebScraper.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SearchEngine, SearchEngineResult>();
            CreateMap<SearchHistory, SearchHistoryResult>();
        }
    }
}
