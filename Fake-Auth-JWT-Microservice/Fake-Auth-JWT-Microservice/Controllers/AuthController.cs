using Fake_Auth_JWT_Microservice.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fake_Auth_JWT_Microservice.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        protected readonly IJwtService _jwtService;
        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult FakeLogin()
        {
            string tokenFake = _jwtService.GenerateToken();
            return Ok(new {
                token = tokenFake
            });
        }
    }
}
