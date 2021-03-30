using EquipmentWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

namespace EquipmentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(UserModels user)
        {
            UserModels u = new UserRepository().GetUser(user.Username);
            if (u == null)
                return this.StatusCode(Convert.ToInt32(HttpStatusCode.NotFound), "The user was not found.");  //Request.CreateResponse(HttpStatusCode.NotFound, // "The user was not found.");
            bool credentials = u.Password.Equals(user.Password);
            if (!credentials) return this.StatusCode(Convert.ToInt32(HttpStatusCode.Forbidden), "The username / password combination was wrong.");
            ObjectResult result = this.StatusCode(Convert.ToInt32(HttpStatusCode.OK), TokenManager.GenerateToken(user.Username));
            return result;
        }

        [HttpGet]
        public IActionResult Validate(string token, string username)
        {
            bool exists = new UserRepository().GetUser(username) != null;
            if (!exists) return this.StatusCode(Convert.ToInt32(HttpStatusCode.NotFound), "The user was not found.");
            string tokenUsername = TokenManager.ValidateToken(token);
            if (username.Equals(tokenUsername))
                return this.StatusCode(Convert.ToInt32(HttpStatusCode.OK));
            return this.StatusCode(Convert.ToInt32(HttpStatusCode.BadRequest));
        }
        [HttpGet]
        public IActionResult ShowPaymentHistory(string token, string username, int accno)
        {
            bool exists = new UserRepository().GetUser(username) != null;
            if (!exists) return this.StatusCode(Convert.ToInt32(HttpStatusCode.NotFound), "The user was not found.");
            string tokenUsername = TokenManager.ValidateToken(token);
            if (username.Equals(tokenUsername))
                return this.StatusCode(Convert.ToInt32(HttpStatusCode.OK));
            return this.StatusCode(Convert.ToInt32(HttpStatusCode.BadRequest));
        }
    }
}
