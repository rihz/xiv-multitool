using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XIVMultitool.Api.Controllers.Account.Retainer
{
    [Route("api/[controller]")]
    public class RetainerController : Controller
    {
        IRetainerService _service;

        public RetainerController(IRetainerService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public IActionResult GetRetainers(string userId)
        {
            return Ok(_service.GetRetainers(userId));
        }

        [HttpPost("")]
        public IActionResult AddRetainer([FromBody] RetainerModel model)
        {
            return Ok(_service.AddRetainer(model));
        }

        [HttpPost("label")]
        public IActionResult AddRetainerLabel([FromBody] RetainerLabelModel model)
        {
            return Ok(_service.AddRetainerLabel(model));
        }

        [HttpPut("")]
        public IActionResult UpdateRetainer([FromBody] RetainerModel model)
        {
            return Ok(_service.UpdateRetainer(model));
        }

        [HttpPut("label")]
        public IActionResult UpdateRetainerLabel([FromBody] RetainerLabelModel model)
        {
            return Ok(_service.UpdateRetainerLabel(model));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRetainer(int id)
        {
            _service.DeleteRetainer(id);

            return Ok();
        }

        [HttpDelete("label/{id}")]
        public IActionResult DeleteRetainerLabel(int id)
        {
            _service.DeleteRetainerLabel(id);

            return Ok();
        }
    }
}