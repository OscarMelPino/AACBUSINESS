using AACBackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace AACBackEnd.Database.DBModels
{
    public class AAC_RECIPES
    {
        [Key]
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public bool IsItem { get; set; }
        public List<Item> ItemsNeeded { get; set; }
    }
}
