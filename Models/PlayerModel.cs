using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourPlayer.Models
{
    public class PlayerModel
    {
        public PlayerModel(string name, byte age, string nationality, string position)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
            Position = position;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; }
        public string Name { get; 
        set; }
        public byte Age { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; }

        public void SetInactive()
        {
            Name = "deactivated";
        }
    }
}