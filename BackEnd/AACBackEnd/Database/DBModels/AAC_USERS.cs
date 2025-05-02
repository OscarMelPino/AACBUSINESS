using System.ComponentModel.DataAnnotations;

namespace AACBackEnd.Database.DBModels
{
    public class AAC_USERS
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password{ get; set; }
        public DateTime? LastLogin{ get; set; }

    }
}
