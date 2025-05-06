using System.Runtime;
using System.Transactions;
using AACBackEnd.Database;
using AACBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace AACBackEnd.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _context;

        public RecipeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Recipe> AddRecipe(Recipe recipe)
        {
            var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromSeconds(30) };
            using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                try
                {
                    _context.AAC_RECIPES.Add(new Database.DBModels.AAC_RECIPES
                    {
                        RecipeId = recipe.RecipeId,
                        Name = recipe.Name,
                        IsItem = recipe.IsItem,
                        ItemsNeeded = recipe.ItemsNeeded
                    });
                    await _context.SaveChangesAsync();
                    transaction.Complete();
                    return recipe;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    return null;
                }
            }
        }

        //public async Task<bool> DeleteRecipe(int id)
        //{
        //    var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromSeconds(30) };
        //    using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
        //    {
        //        try
        //        {
        //            _context.AAC_RECIPES.Remove(new Database.DBModels.AAC_RECIPES { RecipeId = id });
        //            await _context.SaveChangesAsync();
        //            transaction.Complete();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            // Log the exception
        //            return false;
        //        }
        //    }
        //}

        public async Task<List<Recipe>> GetAllRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            recipes = _context.AAC_RECIPES.Select(r => new Recipe
            {
                RecipeId = r.RecipeId,
                Name = r.Name,
                IsItem = r.IsItem,
                ItemsNeeded = r.ItemsNeeded
            }).ToList();

            if (recipes == null) return null;
            return recipes;
        }

        public async Task<List<Recipe>> GetAllRecipesByItemId(int recipeId)
        {
            List<Recipe> recipes = new List<Recipe>();

            recipes = await _context.AAC_RECIPES
                .Where(r => r.RecipeId == recipeId)
                .Select(r => new Recipe
                {
                    RecipeId = r.RecipeId,
                    Name = r.Name,
                    IsItem = r.IsItem,
                    ItemsNeeded = r.ItemsNeeded
                })
                .ToListAsync();

            if (recipes == null) return null;

            return recipes;
        }

        public async Task<Recipe?> GetRecipeByRecipeId(int id)
        {
            var recipe = await _context.AAC_RECIPES.FirstOrDefaultAsync(r => r.RecipeId == id);

            if (recipe == null) return null;

            return new Recipe { IsItem = recipe.IsItem, Name = recipe.Name, RecipeId = recipe.RecipeId, ItemsNeeded = recipe.ItemsNeeded };
        }

        public async Task<Recipe> ModifyRecipe(Recipe recipe)
        {
            var transactionOptions = new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromSeconds(30) };
            using (var transaction = new TransactionScope(TransactionScopeOption.Required, transactionOptions))
            {
                try
                {
                    var existingRecipe = await _context.AAC_RECIPES.FirstOrDefaultAsync(r => r.RecipeId == recipe.RecipeId);
                    if (existingRecipe == null) return null;
                    existingRecipe.Name = recipe.Name;
                    existingRecipe.IsItem = recipe.IsItem;
                    existingRecipe.ItemsNeeded = recipe.ItemsNeeded;
                    await _context.SaveChangesAsync();
                    transaction.Complete();
                    return recipe;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    return null;
                }
            }
        }
    }
}
