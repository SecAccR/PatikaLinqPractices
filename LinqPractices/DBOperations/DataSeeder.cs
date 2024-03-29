using System.Collections.Generic;
using System.Linq;
using LinqPractices.Entities;

namespace LinqPractices.DBOperations;

public class DataSeeder
{
    public static void Seed()
    {
        using (LinqDbContext context = new LinqDbContext())
        {
            if (context.Students.Any()) return;

            context.Students.AddRange([
                new Student("Ayşe", "Yılmaz", 1),
                new Student("Deniz", "Arda", 1),
                new Student("Umut", "Arda", 2),
                new Student("Merve", "Tembel", 2)
            ]);

            context.SaveChanges();
        }
    }
}