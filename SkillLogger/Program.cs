using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillLogger
{
    public class Program
    {
        public class MyEntity
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }


        static void Main(string[] args)
        {

            using (var context = new MyDbContext())
            {
                // Add a new record
                var newEntity = new MyEntity { Name = "John Doe", Age = 30 };
                context.MyEntities.Add(newEntity);
                context.SaveChanges();

                // Retrieve and display records
                var entities = context.MyEntities.ToList();
                foreach (var entity in entities)
                {
                    Console.WriteLine($"ID: {entity.Id}, Name: {entity.Name}, Age: {entity.Age}");
                }
            }

            Console.WriteLine("Database operations completed.");
            Console.ReadKey();

        }
    }
}
