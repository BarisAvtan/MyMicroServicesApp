using AutoMapper;
using CourseServices.Catalog.Dtos;
using CourseServices.Catalog.Model;

namespace CourseServices.Catalog.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<Courses, CourseDto>().ReverseMap();//Course clası CourseDto'a dönüşebilsin ve ReverseMap ile terside yani CourseDto Course'a dönüşebilir.
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Courses, CourseCreateDto>().ReverseMap();
            CreateMap<Courses, CourseUpdateDto>().ReverseMap();   


        }
    }
}
