using AACBackEnd.Models;

namespace AACBackEnd.Repositories
{
    public interface IRecipeRepository
    {
        Task<Recipe?> GetRecipeByRecipeId(int recipeId);
        Task<List<Recipe>> GetAllRecipes();
        Task<List<Recipe>> GetAllRecipesByItemId(int id);
        Task<Recipe> AddRecipe(Recipe recipe);
        Task<Recipe> ModifyRecipe(Recipe recipe);
        //Task<bool> DeleteRecipe(int id);
    }
}
