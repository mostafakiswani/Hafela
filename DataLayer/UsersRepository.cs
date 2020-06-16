using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class UsersRepository
    {
        static Database _context = new Database();


        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public User Edit(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb = user;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

            return user;
        }

        public void Block(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb.IsBlocked = true;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

        }

        public void Delete(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb.IsDeleted = true;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

        }



    }
}
