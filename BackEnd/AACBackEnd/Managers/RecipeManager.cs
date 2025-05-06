using AACBackEnd.Models;
using AACBackEnd.Repositories;

namespace AACBackEnd.Managers
{
    public class RecipeManager : BaseManager
    {
        private readonly IRecipeRepository _recipeService;
        public RecipeManager(IRecipeRepository recipeService)
        {
            this._recipeService = recipeService;
        }
        public async Task<Recipe?> GetRecipeByRecipeId(int recipeId)
        {
            return await this._recipeService.GetRecipeByRecipeId(recipeId);
        }
        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await this._recipeService.GetAllRecipes();
        }
        public async Task<List<Recipe>> GetAllRecipesByItemId(int itemId)
        {
            return await this._recipeService.GetAllRecipesByItemId(itemId);
        }
        public async Task<Recipe> AddRecipe(Recipe recipe)
        {
            return await this._recipeService.AddRecipe(recipe);
        }
        public async Task<Recipe> ModifyRecipe(Recipe recipe)
        {
            return await this._recipeService.ModifyRecipe(recipe);
        }

        // Zeddy said to delete this. Im keeping it!

        //public async Task<bool> DeleteRecipe(int id)
        //{
        //    return await this._recipeService.DeleteRecipe(id);
        //}
    }
}
