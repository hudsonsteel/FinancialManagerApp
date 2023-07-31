using FinancialManagerWebApi.Dtos.V1;
using FinancialManagerWebApi.Interfaces.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagerWebApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;
        private readonly ILogger<BankController> _logger;

        public BankController(ILogger<BankController> logger, IBankService bankService)
        {
            _logger = logger;
            _bankService = bankService;
        }

        [HttpPost("RegisterBank")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult RegisterBank(BankDto bankDto)
        {
            // Implementar a lógica para registrar um banco
            // _bankService.RegisterBank(bankDto);
            // Retornar o resultado da operação
            return Ok();
        }

        [HttpGet("GetBanks")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult GetBanks()
        {
            // Implementar a lógica para obter a lista de bancos
            // var banks = _bankService.GetBanks();
            // Retornar a lista de bancos como resposta
            // return Ok(banks);
            return Ok(new List<BankDto>()); // Exemplo sem dados reais
        }
    }

}
