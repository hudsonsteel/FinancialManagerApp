using FinancialManagerWebApi.Dtos.V1;
using FinancialManagerWebApi.Interfaces.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagerWebApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("RegisterUser")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult RegisterUser(UserDto userDto)
        {
            // Implementar a lógica para registrar um usuário
            // _userService.RegisterUser(userDto);
            // Retornar o resultado da operação
            return Ok();
        }

        [HttpGet("GetUsers")]
        [Authorize] // Autenticação via OAuth 2.0
        public IActionResult GetUsers()
        {
            // Implementar a lógica para obter a lista de usuários
            // var users = _userService.GetUsers();
            // Retornar a lista de usuários como resposta
            // return Ok(users);
            return Ok(new List<UserDto>()); // Exemplo sem dados reais
        }
    }

}
