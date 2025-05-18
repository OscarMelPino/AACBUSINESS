using AACBackEnd.Models.Recipes;

namespace AACBackEnd.Repositories.Recipes
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
