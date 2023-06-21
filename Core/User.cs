using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class User
    {
        public User(string? login, string? password)
        {
            Login = login;
            Password = password;
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Login { get; set; }
        [MaxLength(20)]
        public string?  Password { get; set; }
    }
}
