using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SneakerShop_Core.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UserController : ControllerBase
    {

        private UserService.User.UserClient _userClient;

        public UserController(UserService.User.UserClient userClient)
        {
            this._userClient = userClient;
        }

        [HttpPost]
        public async Task<UserService.CreateUserReply> Create(UserService.CreateUserRequest createUserRequest)
        {
            var result = await _userClient.AddUserAsync(createUserRequest);
            return result;
        }
    }
}

