using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class User
    {
        public string Name { get; set; }
        public User(string name) 
        {
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (GetType() != obj.GetType()) return false;

            User other = (User)obj;

            return Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
