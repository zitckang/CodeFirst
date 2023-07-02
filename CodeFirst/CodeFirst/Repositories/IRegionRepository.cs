using CodeFirst.Models.Domain;

namespace CodeFirst.Repositories
{
    public interface IRegionRepository
    {
        //Synchrpnous 同步 API
        IEnumerable<Region> GetAll();


        //Asynchronous 异步 API
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
