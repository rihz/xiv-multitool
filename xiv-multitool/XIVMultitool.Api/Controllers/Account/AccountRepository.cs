using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using XIVChecklist.Api;
using XIVChecklist.Api.Extensions;
using XIVChecklist.Data.Context;
using XIVChecklist.Entities;
using XIVMultitool.Entities.Account;

namespace XIVMultitool.Api.Controllers.Account
{
    public interface IAccountRepository
    {
        Task<AccountModel> CreateUser(AccountModel model);
        Task<ClaimsIdentity> GetClaimsIdentity(string email, string password);
        Task<string> GetLoginToken(ClaimsIdentity identity, AccountModel model);
        LodestoneCharacterModel AddLodestoneCharacter(LodestoneCharacterModel model);
        IEnumerable<LodestoneCharacterModel> GetCharacters(string userId);
    }

    public class AccountRepository : IAccountRepository
    {
        XIVContext _context;
        UserManager<AppUser> _userManager;
        IJwtFactory _factory;
        JwtIssuerOptions _options;
        IMapper _mapper;
        JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };

        public AccountRepository(XIVContext context, UserManager<AppUser> userManager, IJwtFactory factory,
            IOptions<JwtIssuerOptions> options, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _factory = factory;
            _options = options.Value;
            _mapper = mapper;
        }

        public async Task<AccountModel> CreateUser(AccountModel model)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            return model;
        }

        public async Task<ClaimsIdentity> GetClaimsIdentity(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                var user = await _userManager.FindByEmailAsync(email);
                
                if (user != null)
                {
                    if (await _userManager.CheckPasswordAsync(user, password))
                    {
                        return await Task.FromResult(_factory.GenerateClaimsIdentity(email, user.Id));
                    }
                }
            }

            return await Task.FromResult<ClaimsIdentity>(null);
        }

        public async Task<string> GetLoginToken(ClaimsIdentity identity, AccountModel model)
        {
            var response = new
            {
                id = identity.Claims.Single(x => x.Type == "id").Value,
                auth_token = await _factory.GenerateEncodedToken(model.Email, identity),
                expires_in = (int)_options.ValidFor.TotalSeconds,
                username = model.Email,
                email = model.Email,
            };

            return JsonConvert.SerializeObject(response, _settings);
        }

        public LodestoneCharacterModel AddLodestoneCharacter(LodestoneCharacterModel model)
        {
            var entity = _mapper.Map<LodestoneCharacter>(model);

            _context.LodestoneCharacters.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<LodestoneCharacterModel>(entity);
        }

        public IEnumerable<LodestoneCharacterModel> GetCharacters(string userId)
        {
            var characters = _context.LodestoneCharacters.Where(x => x.UserId == userId);

            return _mapper.MapEnumerable<LodestoneCharacter, LodestoneCharacterModel>(characters);
        }
    }
}
