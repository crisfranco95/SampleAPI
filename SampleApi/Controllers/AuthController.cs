using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jose;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Model;
using SampleApi.Handlers.Auth;
using Microsoft.Extensions.Options;

namespace SampleApi.Controllers
{
    //[Route("api/[controller]/[action]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private AppSettings AppSettings { get; set; }
        public AuthController(IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
        }

        // POST api/values
        [HttpPost("api/auth/register")]
        public ActionResult<string> Register([FromBody] RegisterRequestModel registerRequestModel)
        {
            var loggedInAuthModel = registerRequestModel;

            return Ok(loggedInAuthModel);
        }

        // POST api/values
        [HttpPost("api/auth/login")]
        public ActionResult<AuthResponseModel> Login([FromBody] AuthRequestModel authRequestModel)
        {
            if (ModelState.IsValid)
            {


                var token = AuthenticationHandler.Authenticate(authRequestModel.Username, authRequestModel.Password);

                var authResponseModel = new AuthResponseModel()
                {
                    token = token
                };
                return Ok(authResponseModel);

            }
            else
            {
                return BadRequest();
            }
        }


    }
}
