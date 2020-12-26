using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catstagram.Server.Features.Cats
{
    public interface ICatService
    {
        Task<int> Create(string imageUrl, string description, string userId);

        Task<IEnumerable<CatListingResponseModel>> ByUser(string userId);
    }
}
