using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;

namespace Kreata.Backend.Repos
{
    public interface IServerRepo
    {
        Task<List<Server>> GetAll();
        Task<Server?> GetBy(Guid id);

    }
}
