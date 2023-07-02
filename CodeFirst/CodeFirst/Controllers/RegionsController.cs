using AutoMapper;
using CodeFirst.Models.Domain;
using CodeFirst.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [ApiController] //tell the app this is api controller
    //[Route("Regions")]
    [Route("[controller]/[action]")]// this will auto get to below controller's Regions as a name
    public class RegionsController : Controller
    {


        //public IActionResult Index()
        //{
        //    return View();
        //}

        #region WithoutRepositories
        //[HttpGet]
        //public IActionResult GetAllRegions()
        //{
        //    var regions = new List<Region>() //using CodeFirst.Models.Domain;
        //    {
        //       new Region
        //       {
        //           Id = Guid.NewGuid(),
        //           Name = "ChickenKing",
        //           Code = "CK",
        //           Area = 520,
        //           Lat = 1.855,
        //           Long = 299.8,
        //           Population = 50000

        //       },     
        //       new Region
        //       {
        //           Id = Guid.NewGuid(),
        //           Name = "Heebabi",
        //           Code = "bb",
        //           Area = 1314,
        //           Lat = 1.855,
        //           Long = 299.8,
        //           Population = 50000

        //       }

        //    };


        //    return Ok(regions);
        //}
        #endregion WithoutRepositories


        #region With Repositories

        private readonly IRegionRepository regionRepository; //line 54 use at line 65
        private readonly IMapper mapper;

        //public RegionsController(IRegionRepository regionRepository)  //using CodeFirst.Repositories;
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)  //using Automapper
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegions() //Synchrpnous 同步 API 
        //public async Task<IActionResult> GetAllRegions() //Asynchronous 异步 API
        {

            #region Domain Models Testing Code
            var regions = regionRepository.GetAll();
            var regionNames = regions.Select(r => r.Name).ToList();
            //string firstRegionName = regionNames[0];

            return Json(regionNames);
            //return Json(firstRegionName);
            #endregion Domain Models Testing


            #region Domain Models
            //var regions = regionRepository.GetAll();
            //return Ok(regions);
            //return Json(regions);
            #endregion Domain Models


            //我们改次要换Model region.cs 里面的variable 的时候就就会不一样的Api所以这个可以固定他们
            //Models.DTO folder
            #region DTO contract models without Automapper
            //var regions = regionRepository.GetAll();

            //return DTO regions
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region() { 
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,

            //    };

            //    regionsDTO.Add(regionDTO);
            //});

            //return Json(regionsDTO);
            #endregion DTO contract models without Automapper


            #region DTO contract models with Automapper Synchrpnous 同步 API 
            //var regions = regionRepository.GetAll();

            ////return DTO regions with mapper
            //var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            //return Json(regionsDTO);
            #endregion DTO contract models with Automapper


            #region DTO contract models with Automapper Asynchronous 异步 API 
            //var regions = await regionRepository.GetAllAsync();

            ////return DTO regions with mapper
            //var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            //return Json(regionsDTO);
            #endregion DTO contract models with Automapper


        }
        #endregion With Repositories
    }

}
