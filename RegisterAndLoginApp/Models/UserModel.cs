namespace RegisterAndLoginApp.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
