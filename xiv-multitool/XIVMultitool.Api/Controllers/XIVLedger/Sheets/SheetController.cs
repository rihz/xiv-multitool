using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XIVMultitool.Api.Controllers.XIVLedger.Sheets
{
    [Route("api/[controller]")]
    public class SheetController : Controller
    {
        ISheetService _service;

        public SheetController(ISheetService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public IActionResult GetSheets(string userId)
        {
            var sheets = _service.GetSheets(userId);

            return Ok(sheets);
        }

        [HttpPost("")]
        public IActionResult AddSheet([FromBody] SheetModel model)
        {
            var sheet = _service.AddSheet(model);

            return Ok(sheet);
        }

        [HttpPost("{sheetId}/marketTransaction")]
        public IActionResult AddMarketTransaction([FromBody] MarketTransactionModel model)
        {
            var transaction = _service.AddMarketTransaction(model);

            return Ok(transaction);
        }

        [HttpPut("")]
        public IActionResult UpdateSheet([FromBody] SheetModel model)
        {
            var sheet = _service.UpdateSheet(model);

            return Ok(sheet);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSheet(int id)
        {
            _service.DeleteSheet(id);

            return Ok();
        }
    }
}