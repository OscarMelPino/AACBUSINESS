namespace AACBackEnd.Models
{
    public class Recipe
    {
        public int? RecipeId { get; set; }
        public string Name { get; set; }
        public bool IsItem { get; set; }
        public string ItemsNeeded { get; set; }
    }
}
