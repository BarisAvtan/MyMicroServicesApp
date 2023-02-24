using Course.Shared.Dtos;
using CourseServices.Catalog.Dtos;
using CourseServices.Catalog.Model;

namespace CourseServices.Catalog.Services
{
    public interface ICategoryServices
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
