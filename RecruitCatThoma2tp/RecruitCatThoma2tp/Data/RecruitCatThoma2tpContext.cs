using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatThoma2tp.Models;

namespace RecruitCatThoma2tp.Data
{
    public class RecruitCatThoma2tpContext : DbContext
    {
        public RecruitCatThoma2tpContext (DbContextOptions<RecruitCatThoma2tpContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatThoma2tp.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatThoma2tp.Models.Company> Company { get; set; }

        public DbSet<RecruitCatThoma2tp.Models.Contact> Contact { get; set; }

        public DbSet<RecruitCatThoma2tp.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatThoma2tp.Models.JobTitle> JobTitle { get; set; }
    }
}
