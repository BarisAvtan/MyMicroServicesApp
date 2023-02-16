using Course.Shared.Dtos;
using CourseServices.Catalog.Dtos;
using CourseServices.Catalog.Model;

namespace CourseServices.Catalog.Services
{
    internal interface ICategoryServices
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(Category category);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
