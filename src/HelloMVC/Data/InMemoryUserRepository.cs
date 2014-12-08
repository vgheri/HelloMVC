using System;
using HelloMVC.Models;

namespace HelloMVC.Data
{
    public class InMemoryUserRepository : IUserRepository
    {
        public User GetUser()
        {
            return new User()
            {
                Name = "Valerio G.",
                Address = "Route de Cretes"
            };
        } 
    }
}