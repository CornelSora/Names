using System.Collections.Generic;
using System.Threading.Tasks;

namespace Names
{
    public interface ISearchService
    {
        Task<List<SearchResult>> Search(string keyword);
    }
}
