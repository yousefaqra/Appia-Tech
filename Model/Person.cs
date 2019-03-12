using System.Collections.Generic;

namespace appiatech.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

    }
}