﻿using Application;
using Core;

namespace Infrastructure
{
    public class UserRepo : IUserRepo
    {
        private readonly BookShopDbContext _context;
        public UserRepo(BookShopDbContext context)
        {
            _context = context;
        }

        public User Authorisation(string login, string password)
        {
            return _context.UserTable.Find(login, password);
        }

        public void Registration(User user)
        {
            _context.UserTable.Add(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}