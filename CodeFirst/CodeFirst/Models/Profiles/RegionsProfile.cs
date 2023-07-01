using AutoMapper;

namespace CodeFirst.Models.Profiles
{
    public class RegionsProfile : Profile //using AutoMapper;
    {
        public RegionsProfile()
        {
            //TSource to TDestination
            CreateMap<Models.Domain.Region, Models.DTO.Region>();
            //CreateMap need to tell
            //go to program.cs to inject
        }

    }
}
