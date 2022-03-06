using Microsoft.EntityFrameworkCore;
using Middle.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middle.Services.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<GuestBoard> GuestBoards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
