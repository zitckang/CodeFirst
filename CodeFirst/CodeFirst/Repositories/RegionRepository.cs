using CodeFirst.Data;
using CodeFirst.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Repositories
{
    public class RegionRepository : IRegionRepository //implement interface
    {
        private readonly CodeFirstDBContext codeFirstDBContext;  // line 8 use at line 20

        //inject codeFirstDBContext though the contructor 'RegionRepository'
        public RegionRepository(CodeFirstDBContext codeFirstDBContext) //CodeFirstDBContext using CodeFirst.Data; //codeFirstDBContext right click assign and field readonly 
        {
            
            this.codeFirstDBContext = codeFirstDBContext;
        }


        //Synchrpnous 同步 API
        //RegionRepository.cs name as sqlregionrepository also can 
        public IEnumerable<Region> GetAll()
        {
            return codeFirstDBContext.Regions.ToList();
        }

        //Asynchronous 异步 API
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            //这里用 await 上面就要用 async 
            return await codeFirstDBContext.Regions.ToListAsync();//ToListAsync() using Microsoft.EntityFrameworkCore;
        }

        //SourceTree Testing 1
        //SourceTree Testing 2
        //SourceTree Testing 3
        //SourceTree Testing 4
        //SourceTree Testing 5
        //SourceTree Testing 6
        //SourceTree Testing 7
        //SourceTree Testing 8
        //SourceTree Testing 3  
        //SourceTree Testing 4
        //SourceTree Testing 5
        //SourceTree Testing 6
        //SourceTree Testing 7
        //SourceTree Testing 8
    }
}
