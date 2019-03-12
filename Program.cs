using System;
using System.Collections.Generic;
using appiatech.Model;

namespace appiatech
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                var flag = true;

                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                string secondName = Console.ReadLine();

                Console.WriteLine("Enter Person skill");
                string skill1 = Console.ReadLine();

                Console.WriteLine("Enter Another skill");
                string skill2 = Console.ReadLine();


                var person = new Person
                {
                    FirstName = firstName,
                    LastName = secondName,
                    Skills = new List<Skill>
                    {
                        new Skill { Name = skill1},
                        new Skill { Name = skill2},
                    }
                };
                context.Add(person);
                context.SaveChanges();
            }


            using (var context = new PersonContext())
            {
                foreach (var skill in context.Skills)
                {
                    Console.WriteLine(skill.Name);
                }
            }
        }


    }
}
