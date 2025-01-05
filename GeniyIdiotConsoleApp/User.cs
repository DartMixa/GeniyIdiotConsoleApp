using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    internal class User
    {
        public string? Name { get; set; }
        public User(string? name) 
        {
            Name = name;
        }
    }
}
