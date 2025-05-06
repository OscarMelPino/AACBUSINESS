using System.Collections;
using AACBackEnd.Models;
using AACBackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AACBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipeRepository _recipeRepository;
        Managers.RecipeManager _recipeManager;
        public RecipeController(ILogger<RecipeController> _logger, IRecipeRepository recipeRepository)
        {
            this._logger = _logger;
            _recipeRepository = recipeRepository;
            this._recipeManager = new Managers.RecipeManager(_recipeRepository);
        }

        [HttpGet("{recipeId}")]
        public async Task<Recipe?> GetRecipeByRecipeId(int recipeId)
        {
            return await this._recipeManager.GetRecipeByRecipeId(recipeId);
        }

        [HttpGet]
        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await this._recipeManager.GetAllRecipes();
        }

        //[HttpGet("/items/{itemId}")]
        //public async Task<List<Recipe>> GetAllRecipesByItemId(int itemId)
        //{
        //    return await this._recipeManager.GetAllRecipesByItemId(itemId);
        //}

        [HttpPost]
        public async Task<Recipe> AddRecipe([FromBody] Recipe recipe)
        {
            return await this._recipeManager.AddRecipe(recipe);
        }

        [HttpPut]
        public async Task<Recipe> ModifyRecipe([FromBody] Recipe recipe)
        {
            return await this._recipeManager.ModifyRecipe(recipe);
        }

        //zeddy said to delete this. Im keeping it!

        //[HttpDelete]
        //public async Task<bool> DeleteRecipe(int id)
        //{
        //    return await this._recipeManager.DeleteRecipe(id);
        //}

    }
}
