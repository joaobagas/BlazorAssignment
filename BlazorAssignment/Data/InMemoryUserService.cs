using BlazorAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAssignment.Data.Impl
{
    public class InMemoryUserService : ServiceInterface
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
                {
                new User
                {
                    UserName = "admin",
                    Password="1234",
                    SecurityLevel = 2
                },
                new User
                {
                    UserName = "user",
                    Password="1234",
                    SecurityLevel= 1
                }
            }.ToList();
        }
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if(first==null)
            {
                throw new Exception("User not found");

            }
            if(!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            return first;
        }
    }
}
