using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account
{
    public class LodestoneCharacterModel
    {
        public int Id { get; set; }
        public string CharacterId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Server { get; set; }
    }
}
