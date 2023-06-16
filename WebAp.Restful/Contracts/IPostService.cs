using System.Collections.Generic;
using System.Threading.Tasks;
using WebAp.Restful.Dto;

namespace WebAp.Restful.Contracts
{
    public interface IPostService
    {
        Task<IList<Post>> GetAll();
    }
}
