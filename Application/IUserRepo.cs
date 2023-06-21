using Core;


namespace Application
{
    public interface IUserRepo
    {
        public User Authorisation(string login, string password);
        public void Registration(User user);

        public void Save();
    }
}
