using Daawahla.Application.Interfaces.JWTAuthManager;
using Daawahla.Core.Entities.AuthModel;
using Daawahla.Core.Entities.Roles;
using Daawahla.Core.Entities.UserModel;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Daawahla.WebApi.Controllers.api.AccountController
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase
    {
        private readonly IJWTAuthManager _authentication;

        public AccountController(IJWTAuthManager authentication)
        {
            _authentication = authentication;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult login([FromBody] LoginModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Parameter is missing");
            }

            DynamicParameters dp_param = new DynamicParameters();
            dp_param.Add("email", user.email, DbType.String);
            dp_param.Add("password", user.password, DbType.String);
            dp_param.Add("retVal", DbType.String, direction: ParameterDirection.Output);
            var result = _authentication.Execute_Command<User>("sp_loginUser", dp_param);
            if (result.code == 200)
            {
                var token = _authentication.GenerateJWT(result.Data);
                return Ok(token);
            }
            return NotFound(result.Data);
        }

        [HttpGet("UserList")]
        [Authorize(Roles = Role.Admin)]
     
        public IActionResult getAllUsers()
        {
            var result = _authentication.getUserList<User>();
            return Ok(result);
        }

        [HttpPost("Register")]
        [Authorize(Roles = Role.Admin)]
        [AllowAnonymous]
        public IActionResult Register([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Parameter is missing");
            }

            DynamicParameters dp_param = new DynamicParameters();
            dp_param.Add("email", user.Email, DbType.String);
            dp_param.Add("username", user.Username, DbType.String);
            dp_param.Add("password", user.Password, DbType.String);
            dp_param.Add("role", user.Role, DbType.String);

            dp_param.Add("msisdn", user.msisdn, DbType.String);
            dp_param.Add("usertype", user.usertype, DbType.Int32);
            dp_param.Add("status", user.status, DbType.Int32);
            dp_param.Add("imei", user.imei, DbType.String);

            dp_param.Add("retVal", DbType.String, direction: ParameterDirection.Output);
            var result = _authentication.Execute_Command<User>("sp_registerUser", dp_param);
            if (result.code == 200)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("Delete")]
        [Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public IActionResult Delete(string id)
        {
            if (id == string.Empty)
            {
                return BadRequest("Parameter is missing");
            }

            DynamicParameters dp_param = new DynamicParameters();
            dp_param.Add("userid", id, DbType.String);

            dp_param.Add("retVal", DbType.String, direction: ParameterDirection.Output);
            var result = _authentication.Execute_Command<User>("sp_deleteUsers", dp_param);
            if (result.code == 200)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
