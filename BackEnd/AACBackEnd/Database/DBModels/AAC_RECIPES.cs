using AACBackEnd.Models;

namespace AACBackEnd.Database.DBModels
{
    public class AAC_RECIPES
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public bool IsItem { get; set; }
        public List<Item> ItemsNeeded { get; set; }
    }
}
