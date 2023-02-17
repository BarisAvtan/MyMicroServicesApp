using Course.Shared.ControllerBases;
using CourseServices.Catalog.Dtos;
using CourseServices.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseServices.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class CategoriesController : CustomBaseController
    {
        private readonly ICategoryServices _categoryService;

        public CategoriesController(ICategoryServices categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> GetAll() 
        {
            var categories = await _categoryService.GetAllAsync();
            return CreateActionResultInstance(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var category= await _categoryService.GetByIdAsync(id);
            return CreateActionResultInstance(category);
        }

        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var response = await _categoryService.CreateAsync(categoryDto);
            return CreateActionResultInstance(response);
        }
    }
}
