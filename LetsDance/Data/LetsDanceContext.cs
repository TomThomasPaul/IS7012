using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LetsDance.Models;

namespace LetsDance.Data
{
    public class LetsDanceContext : DbContext
    {
        public LetsDanceContext (DbContextOptions<LetsDanceContext> options)
            : base(options)
        {
        }

        public DbSet<LetsDance.Models.Branch> Branch { get; set; }

        public DbSet<LetsDance.Models.BuddingDancer> BuddingDancer { get; set; }

        public DbSet<LetsDance.Models.ClassSchedule> ClassSchedule { get; set; }

        public DbSet<LetsDance.Models.Faculty> Faculty { get; set; }

        public DbSet<LetsDance.Models.Genre> Genre { get; set; }

        public DbSet<LetsDance.Models.Inquiry> Inquiry { get; set; }
    }
}
