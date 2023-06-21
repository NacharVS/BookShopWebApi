namespace BookShopWebApi.DTOs
{
    public class UserCreateDTO
    {
        public UserCreateDTO(string? login, string? password)
        {
            Login = login;
            Password = password;
        }

        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
