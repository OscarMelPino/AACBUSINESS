namespace AACBackEnd.Models
{
    public class RecipeInformation
    {
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public ItemInformation[] ItemsNeeded { get; set; } 
    }
}
