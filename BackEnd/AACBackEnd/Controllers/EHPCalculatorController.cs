using AACBackEnd.Managers;
using AACBackEnd.Models.EHPCalculator;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AACBackEnd.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class EHPCalculatorController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;
        Managers.EHPCalculatorManager _ehpCalculatorManager;

        public EHPCalculatorController(ILogger<ItemsController> _logger, EHPCalculatorManager ehpCalculatorManager)
        {
            this._logger = _logger;
            this._ehpCalculatorManager = ehpCalculatorManager;
        }

        // DEFENDER: THE STATS OF THE DEFENDER
        // ATTACKER: THE STATS OF THE ATTACKER
        [System.Web.Http.HttpGet()]
        public EHPResult GetAllEHPCalculators([FromUri] EHPDefenderStats defender, [FromUri] EHPAttackerStats attacker)
        {
            // HOVER OVER THE METHOD NAME (CALCULATEEHP), CLICK TO SELECT IT AND PRESS F12 TO GO TO THE METHOD
            return this._ehpCalculatorManager.CalculateEHP(defender, attacker);
        }
    }
}
