﻿using Hyka.Models;
using Microsoft.EntityFrameworkCore;

namespace Hyka.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Blockbuster> Blockbusters { get; set; }
        public DbSet<Person> Users { get; set; }
    }
}