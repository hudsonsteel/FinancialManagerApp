using FinancialManagerWebApi.Dtos.V1;
using FinancialManagerWebApi.Interfaces.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagerWebApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ITransactionService transactionService, ILogger<TransactionController> logger)
        {
            _transactionService = transactionService;
            _logger = logger;
        }

        [HttpPost("RegisterTransaction")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult RegisterTransaction(TransactionDto transactionDto)
        {
            // Implementar a lógica para registrar uma transação
            // _transactionService.RegisterTransaction(transactionDto);
            // Retornar o resultado da operação
            return Ok();
        }

        [HttpGet("GetTransactions")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult GetTransactions()
        {
            // Implementar a lógica para obter a lista de transações
            // var transactions = _transactionService.GetTransactions();
            // Retornar a lista de transações como resposta
            // return Ok(transactions);
            return Ok(new List<TransactionDto>()); // Exemplo sem dados reais
        }
    }

}
