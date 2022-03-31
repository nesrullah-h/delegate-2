using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace ConsoleApp2
{
    internal class User: IEntity
    {
        public int Id { get; }
        public string Userame { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; }
        public User(string username,string email,Role role )
        {

        }
        public void ShowInfo()
        {

        }

    }
}
