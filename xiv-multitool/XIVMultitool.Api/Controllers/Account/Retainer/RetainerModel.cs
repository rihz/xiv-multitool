using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVMultitool.Api.Controllers.Account.Retainer
{
    public class RetainerModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<RetainerLabelModel> Labels { get; set; }
    }

    public class RetainerLabelModel
    {
        public int Id { get; set; }
        public int RetainerId { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }
    }
}
