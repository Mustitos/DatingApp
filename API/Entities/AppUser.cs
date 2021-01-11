namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } 

        public byte[] PasswordHast { get; set; }
        public byte[] PasswordSalt { get; set; }
    }

}
