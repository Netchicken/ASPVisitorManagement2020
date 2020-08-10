using System;
using System.Collections.Generic;
using System.Text;
using ASPVisitorManagement2020.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPVisitorManagement2020.Data
{
    public class VisitorDbContext : DbContext
    {

        //add in the  Tables we are using
        public DbSet<StaffNames> StaffNames { get; set; }
        public DbSet<Visitor> Visitor { get; set; }


        public VisitorDbContext(DbContextOptions<VisitorDbContext> options)
            : base(options)
        {
        }

        public VisitorDbContext()
        {


        }

    }
}
