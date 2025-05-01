namespace AACBackEnd.Models
{
    public class LoginModel
    {
        public uint UserId { get; set; }
        public string Username { get; set; }
        public string Password{ get; set; }
        public string LastLogin{ get; set; }

    }
}
