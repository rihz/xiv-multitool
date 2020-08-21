using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using XIVChecklist.Entities;

namespace XIVMultitool.Api.Controllers.Account
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;
        IAccountService _accountService;

        public AccountController(UserManager<AppUser> userManager, IAccountService accountService)
        {
            _userManager = userManager;
            _accountService = accountService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] AccountModel model)
        {
            var created = await _accountService.CreateUser(model);

            var token = await _accountService.GetJSONToken(model);

            return new OkObjectResult(token);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] AccountModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if(await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return new OkObjectResult(await _accountService.GetLoginToken(model));
            }

            return BadRequest("Login Failed");
        }

        [HttpPost("{userId}/lodestone/{characterId}/{code}")]
        public async Task<IActionResult> VerifyLodestone(string userId, string characterId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if(user != null)
            {
                return Ok(_accountService.VerifyLodestone(userId, characterId, code));
            }

            return BadRequest("User Not Found");
        }

        [HttpGet("{userId}/lodestone")]
        public IActionResult GetCharacters(string userId)
        {
            return Ok(_accountService.GetCharacters(userId));
        }
    }
}