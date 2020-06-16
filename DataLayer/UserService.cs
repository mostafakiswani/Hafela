using DatabaseContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class UserService
    {
        static Database _context = new Database();


        public static List<User> GetAll()
        {
            var users = _context.Users.ToList();

            return users;
        }

        public static User GetById(int Id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == Id);

            return user;
        }

        public static User Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public static User Edit(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb = user;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

            return user;
        }

        public static void Block(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb.IsBlocked = true;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

        }

        public static void Delete(User user)
        {
            var userFromDb = GetById(user.Id);

            userFromDb.IsDeleted = true;

            _context.Users.Update(userFromDb);
            _context.SaveChanges();

        }



    }
}
