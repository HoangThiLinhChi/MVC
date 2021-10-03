using Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class DataStudentcs
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        StudentName = "Nguyen Van a"
                    },
                    new Student
                    {
                        StudentName = "Nguyen Van b"
                    },
                    new Student
                    {
                        StudentName = "Nguyen Van c"
                    }


                ); ;
                context.SaveChanges();
            }
        }
    }
}
