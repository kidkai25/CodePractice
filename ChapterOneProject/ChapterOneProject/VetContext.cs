using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ChapterOneProject
{
    class VetContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=MNILAY-ENVY\\SQLEXPRESS;Initial Catalog=TutorialsTeam;Integrated Security=True");
                //optionsBuilder.useSqlServer(@"Data Source=MNILAY-ENVY\\SQLEXPRESS;Initial Catalog=TutorialsTeam;Integrated Security=True");
            }
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
