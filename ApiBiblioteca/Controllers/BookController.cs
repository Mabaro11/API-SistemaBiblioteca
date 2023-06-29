using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            try
            {
                var books = await bookRepository.GetBooks();
                if(books == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, "No book in database");
                }
                return StatusCode(StatusCodes.Status200OK, books);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error retrieving data from the database: {e.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            try
            {
                var result = await bookRepository.GetBook(id);

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
        public async Task<ActionResult<Book>> CreateBook([FromBody] Book book)
        {
            try
            {
                if (book == null)
                    return BadRequest();

                var createdBook = await bookRepository.AddBook(book);

                return CreatedAtAction(nameof(GetBook),
                    new { id = createdBook.ID }, createdBook);
            }
            catch (Exception e)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new book record: {e.Message}");
            }
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, Book book)
        {
            try
            {
                if (id != book.ID)
                    return BadRequest("Book ID mismatch");

                var bookToUpdate = await bookRepository.GetBook(id);

                if (bookToUpdate == null)
                    return NotFound($"Book with Id = {id} not found");

                return await bookRepository.UpdateBook(book);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            try
            {
                var bookToDelete = await bookRepository.GetBook(id);

                if (bookToDelete == null)
                {
                    return NotFound($"Book with Id = {id} not found");
                }
                
                return await bookRepository.DeleteBook(id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new book record: {e.Message}");
            }
        }
    }
}
