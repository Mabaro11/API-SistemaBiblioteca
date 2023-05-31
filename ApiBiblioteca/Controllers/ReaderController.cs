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
    public class ReaderController : ControllerBase
    {

        private readonly IReaderRepository readerRepository;

        public ReaderController(IReaderRepository readerRepository)
        {
            this.readerRepository = readerRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetReaders()
        {
            try
            {
                return Ok(await readerRepository.GetReaders());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Reader>> GetReader(int id)
        {
            try
            {
                var result = await readerRepository.GetReader(id);

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
        public async Task<ActionResult<Reader>> CreateReader([FromBody] Reader reader)
        {
            try
            {
                if (reader == null)
                    return BadRequest();

                var createdBook = await readerRepository.AddReader(reader);

                return CreatedAtAction(nameof(GetReader),
                    new { id = createdBook.ID }, createdBook);
            }
            catch (Exception e)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new reader record: {e.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Reader>> UpdateReader(int id, Reader reader)
        {
            try
            {
                if (id != reader.ID)
                    return BadRequest("Reader ID mismatch");

                var readerToUpdate = await readerRepository.GetReader(id);

                if (readerToUpdate == null)
                    return NotFound($"Reader with Id = {id} not found");

                return await readerRepository.UpdateReader(reader);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Reader>> DeleteReader(int id)
        {
            try
            {
                var readerToDelete = await readerRepository.GetReader(id);
                var transactionsByReader = await readerRepository.GetTransactionsByReaderID(id);

                if (readerToDelete == null)
                {
                    return NotFound($"Reader with Id = {id} not found");
                }
                if(transactionsByReader != 0)
                {
                    return StatusCode(StatusCodes.Status405MethodNotAllowed,
                    $"Error deleting new reader record: Transactions found");
                }

                return await readerRepository.DeleteReader(id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error deleting new reader record: {e.Message}");
            }
        }
    }
}
