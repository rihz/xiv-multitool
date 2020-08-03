using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account
{
    public interface IAccountService
    {
        Task<AccountModel> CreateUser(AccountModel model);
        Task<string> GetJSONToken(AccountModel model);
        Task<string> GetLoginToken(AccountModel model);
    }

    public class AccountService : IAccountService
    {
        IAccountRepository _repo;
        JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };

        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }

        public async Task<AccountModel> CreateUser(AccountModel model)
        {
            return await _repo.CreateUser(model);
        }

        public async Task<string> GetJSONToken(AccountModel model)
        {
            var identity = await _repo.GetClaimsIdentity(model.Email, model.Password);

            return identity != null
                ? JsonConvert.SerializeObject(new
                    {
                        id = identity.Claims.Single(x => x.Type == "id").Value
                    }, _settings)
                : "";
        }

        public async Task<string> GetLoginToken(AccountModel model)
        {
            var identity = await _repo.GetClaimsIdentity(model.Email, model.Password);

            return await _repo.GetLoginToken(identity, model);
        }
    }
}
