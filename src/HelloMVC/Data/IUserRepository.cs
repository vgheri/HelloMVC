using System;
using HelloMVC.Models;

namespace HelloMVC.Data
{
    public interface IUserRepository
    {
        User GetUser();
    }
}