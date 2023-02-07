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
    public class TransactionController : ControllerBase
    {

        private readonly ITransactionRepository transactionRepository;

        public TransactionController(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetTransaction()
        {
            try
            {
                return Ok(await transactionRepository.GetTransactions());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Transaction>> GetTransaction(int id)
        {
            try
            {
                var result = await transactionRepository.GetTransaction(id);

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
        public async Task<ActionResult<Transaction>> CreateTransaction([FromBody] Transaction transaction)
        {
            try
            {
                if (transaction == null)
                    return BadRequest();

                var createdTransaction = await transactionRepository.AddTransaction(transaction);

                return CreatedAtAction(nameof(GetTransaction),
                    new { id = createdTransaction.ID }, createdTransaction);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new transaction record: {e.Message}");
            }
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Transaction>> UpdateTransaction(int id, Transaction transaction)
        {
            try
            {
                if (id != transaction.ID)
                    return BadRequest("Transaction ID mismatch");

                var transactionToUpdate = await transactionRepository.GetTransaction(id);

                if (transactionToUpdate == null)
                    return NotFound($"Transaction with Id = {id} not found");

                return await transactionRepository.UpdateTransaction(transaction);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Transaction>> DeleteTransaction(int id)
        {
            try
            {
                var transactionToDelete = await transactionRepository.GetTransaction(id);

                if (transactionRepository == null)
                {
                    return NotFound($"Transaction with Id = {id} not found");
                }
                
                return await transactionRepository.DeleteTransaction(id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error creating new transaction record: {e.Message}");
            }
        }
    }
}
