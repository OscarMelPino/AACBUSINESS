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

        public EHPResult CalculateEHP(EHPDefenderStats defender, EHPAttackerStats attacker)
        {
            return this._ehpCalculatorService.GetCalulateEHP(defender, attacker);
        }
    }
}
