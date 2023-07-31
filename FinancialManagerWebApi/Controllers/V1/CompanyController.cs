using FinancialManagerWebApi.Dtos.V1;
using FinancialManagerWebApi.Interfaces.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagerWebApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger, ICompanyService companyService)
        {
            _logger = logger;
        }

        [HttpPost("RegisterCompany")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult RegisterCompany(CompanyDto companyDto)
        {
            // Implementar a lógica para registrar uma empresa
            // _companyService.RegisterCompany(companyDto);
            // Retornar o resultado da operação
            return Ok();
        }

        [HttpGet("GetCompanies")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult GetCompanies()
        {
            // Implementar a lógica para obter a lista de empresas
            // var companies = _companyService.GetCompanies();
            // Retornar a lista de empresas como resposta
            // return Ok(companies);
            return Ok(new List<CompanyDto>()); // Exemplo sem dados reais
        }
    }

}
