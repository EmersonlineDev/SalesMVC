using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySalesMVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public List<Telephone> Telephones { get; set; } = new List<Telephone>();

        public Client()
        {

        }

        public Client(int id, string name, DateTime birthdate, string email)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Email = email;
        }
    }
}
