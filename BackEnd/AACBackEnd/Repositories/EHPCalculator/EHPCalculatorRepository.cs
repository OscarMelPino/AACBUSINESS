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

        public EHPResult GetCalulateEHP(EHPDefenderStats defender, EHPAttackerStats attacker)
        {
            var result = new EHPResult();

            // IF I LET YOU HERE WILL YOU BE ABLE TO CALCULATE THE EHP?
            // YES, you write logic here

            result.EHP = attacker.BaseDamage - defender.Defense;

            return result;
        }
    }
}
