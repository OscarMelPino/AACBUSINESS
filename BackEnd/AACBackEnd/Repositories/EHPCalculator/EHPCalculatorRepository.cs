using AACBackEnd.Database;
using AACBackEnd.Models.EHPCalculator;
using Microsoft.EntityFrameworkCore;

namespace AACBackEnd.Repositories.EHPCalculator
{
    public class EHPCalculatorRepository : IEHPCalculatorRepository
    {
        private readonly AppDbContext _dbcontext;
        public EHPCalculatorRepository(AppDbContext context)
        {
            _dbcontext = context;
        }

        public EHPResult GetCalulateEHP(EHPDefender defender, EHPAttacker attacker)
        {
            // YOU WRITE YOUR CALCULATION LOGIC HERE
            var result = new EHPResult
            {
                // YOU DO THE CALCULATION HERE
                // ADD THE PROPERTIES HERE
            };
            return result;
        }

        public EHPResult GetCalulateEHP(EHPDefender defender, int attackerProfileId)
        {
            // GET THE ATTACKER PROFILE FROM THE DATABASE
            var dbattackerprofile = _dbcontext.AAC_ATTACKERPROFILE.FirstOrDefault(profiles => profiles.ProfileId == attackerProfileId);
            var attacker = new EHPAttacker
            {
                // YOU MAP THE DATA FROM THE DATABASE TO THE ATTACKER CLASS
                // ADD THE PROPERTIES HERE
            };
            return GetCalulateEHP(defender, attacker); 
            // this returns the result of the calculation from the method above, so you just write it once, but you extract the datafrom the database
        }
    }
}
