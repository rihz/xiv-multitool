using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account
{
    public class AccountModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
