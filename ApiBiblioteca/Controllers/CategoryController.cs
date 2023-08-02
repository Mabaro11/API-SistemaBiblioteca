using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            try
            {
                return Ok(await categoryRepository.GetCategories());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            try
            {
                var result = await categoryRepository.GetCategory(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateCategory([FromBody] Category category)
        {
            try
            {
                if (category == null)
                    return BadRequest();

                var createdCategory = await categoryRepository.AddCategory(category);

                return CreatedAtAction(nameof(GetCategory),
                    new { id = createdCategory.ID }, createdCategory);
            }
            catch (Exception e)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new category record: {e.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Category>> UpdateCategory(int id, Category category)
        {
            try
            {
                if (id != category.ID)
                    return BadRequest("Category ID mismatch");

                var categoryToUpdate = await categoryRepository.GetCategory(id);

                if (categoryToUpdate == null)
                    return NotFound($"Category with Id = {id} not found");

                return await categoryRepository.UpdateCategory(category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            try
            {
                var categoryToDelete = await categoryRepository.GetCategory(id);

                

                if (categoryToDelete == null)
                {
                    return NotFound($"Category with Id = {id} not found" );
                }
                
                return await categoryRepository.DeleteCategory(id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new category record: {e.Message}");
            }
        }
    }
}
