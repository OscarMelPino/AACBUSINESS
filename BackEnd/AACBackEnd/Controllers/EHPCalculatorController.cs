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

        // THIS IS THE ENTRY POINT, YOU EXPECT THESE PARAMETERS TO BE PASSED IN THE URL 
        // DONT WORRY ABOUT HOW IT IS DONE, JUST KNOW THAT IT IS DONE AND TRUST IT
        // DEFENDER: THE STATS OF THE DEFENDER
        // ATTACKER: THE STATS OF THE ATTACKER, NULLABLE BECAUSE THE USER CAN CHOOSE TO PASS THE PROFILE ID INSTEAD
        // ATTACKERPROFILEID: THE ID OF THE ATTACKER PROFILE, NULLABLE BECAUSE THE USER CAN CHOOSE TO PASS THE ATTACKER STATS INSTEAD
        [System.Web.Http.HttpGet()]
        public EHPResult GetAllEHPCalculators([FromUri] EHPDefender defender, [FromUri] EHPAttacker? attacker, [FromUri] int? attackerProfileId)
        {
            // HOVER OVER THE METHOD NAME (CALCULATEEHP), CLICK TO SELECT IT AND PRESS F12 TO GO TO THE METHOD
            return this._ehpCalculatorManager.CalculateEHP(defender, attacker, attackerProfileId);
        }
    }
}
