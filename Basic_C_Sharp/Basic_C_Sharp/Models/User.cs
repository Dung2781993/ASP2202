using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp.Models
{
    internal class User
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Location { get; set; }

        public User(String Name, String Location){
            this.Name = Name;
            this.Location = Location;
        }
    }
}
