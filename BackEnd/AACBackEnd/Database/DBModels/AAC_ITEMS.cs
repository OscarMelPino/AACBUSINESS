using System.ComponentModel.DataAnnotations;

namespace AACBackEnd.Database.DBModels
{
    public class AAC_ITEMS
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
    }
}
