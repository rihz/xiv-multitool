using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using XIVChecklist.Entities;

namespace XIVMultitool.Api.Controllers.Account
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;

        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] AccountModel model)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email
            };
            
            var result = await _userManager.CreateAsync(user, model.Password);

            return Ok(model);
        }
    }
}