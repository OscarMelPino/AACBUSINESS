namespace AACBackEnd.Models
{
    public class NewLogin
    {
        public uint UserId { get; set; }
        public string Username { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}
