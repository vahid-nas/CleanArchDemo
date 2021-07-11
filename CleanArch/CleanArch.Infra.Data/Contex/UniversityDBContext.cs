using CleanArch.
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Contex
{
    public class UniversityDBContext : DbContext
    {
        public  UniversityDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

    }
}
