using AACBackEnd.Models.EHPCalculator;

namespace AACBackEnd.Repositories.EHPCalculator
{
    public interface IEHPCalculatorRepository
    {
        // This is the method that will be used to calculate the EHP, the logic will be in the repository in the other file of the folder

        // I KNOW I TOLD YOU THE METHODS NAME HAS TO BE DIFFERENT, BUT I LIED A LITTLE
        // THE COMPILER CAN DIFERECIATE BOTH METHODS BECAUSE THEY REQUIRE DIFFERENT PARAMETERS
        // SO DEPENDING ON WHAT THE USER SENDS, THE COMPILER WILL CALL THE CORRECT METHOD
        EHPResult GetCalulateEHP(EHPDefender defender, EHPAttacker attacker);
        EHPResult GetCalulateEHP(EHPDefender defender, int attackerProfileId);
    }
}
