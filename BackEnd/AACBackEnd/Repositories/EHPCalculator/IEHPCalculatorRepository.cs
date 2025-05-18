using AACBackEnd.Models.EHPCalculator;

namespace AACBackEnd.Repositories.EHPCalculator
{
    public interface IEHPCalculatorRepository
    {
        // This is the method that will be used to calculate the EHP, the logic will be in the repository in the other file of the folder
        EHPResult GetCalulateEHP(EHPDefenderStats defender, EHPAttackerStats attacker);
    }
}
