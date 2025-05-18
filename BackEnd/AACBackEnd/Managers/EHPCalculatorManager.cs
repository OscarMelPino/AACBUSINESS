using AACBackEnd.Models.EHPCalculator;
using AACBackEnd.Repositories.EHPCalculator;

namespace AACBackEnd.Managers
{
    public class EHPCalculatorManager : BaseManager
    {
        private readonly IEHPCalculatorRepository _ehpCalculatorService;

        public EHPCalculatorManager(IEHPCalculatorRepository ehpCalculatorService)
        {
            this._ehpCalculatorService = ehpCalculatorService;
        }

        // THIS IS THE METHOD WHERE YOU DETERMINE WHICH METHOD OF THE REPOSITORY TO USE
        public EHPResult CalculateEHP(EHPDefender defender, EHPAttacker? attacker, int? attackerProfileId)
        {
            if (!(attacker is null))
                return this._ehpCalculatorService.GetCalulateEHP(defender, attacker);
            // HOVER OVER THE METHOD NAME (GetCalulateEHP), CLICK TO SELECT IT AND PRESS F12 TO GO TO THE METHOD

            else if (attackerProfileId.HasValue)
                    return this._ehpCalculatorService.GetCalulateEHP(defender, attackerProfileId.Value);
            // HOVER OVER THE METHOD NAME (GetCalulateEHP), CLICK TO SELECT IT AND PRESS F12 TO GO TO THE METHODS
            else
                throw new ArgumentException("Either attacker or attackerProfileId must be provided.");
                // IGNORE THIS LINE AND DONT ASK WHY
        }
    }
}
