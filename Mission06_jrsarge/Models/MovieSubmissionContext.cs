using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jrsarge.Models
{
    public class MovieSubmissionContext : DbContext
    {
        //Constructor
        public MovieSubmissionContext (DbContextOptions<MovieSubmissionContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<MovieSubmission> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Family"},
                new Category { CategoryID = 2, CategoryName = "Action/Adventure"},
                new Category { CategoryID = 3, CategoryName = "Comedy" },
                new Category { CategoryID = 4, CategoryName = "Drama"},
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<MovieSubmission>().HasData(
                new MovieSubmission
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Tarzan",
                    Year = 1999,
                    Director = "Chris Buck",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieSubmission
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Stuart Little",
                    Year = 1999,
                    Director = "Rob Minkoff",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieSubmission
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Frozen",
                    Year = 2013,
                    Director = "Chris Buck",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }

    }
}
