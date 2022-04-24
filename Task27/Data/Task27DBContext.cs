using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task27.Data.Entities;

namespace Task27.Data
{
    internal class Task27DBContext:DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CommentsEntity> Comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BEXININSIRINNOT\SQLEXPRESS;Database=Task27;Trusted_Connection=True");
        }

    }
}
