﻿using Microsoft.EntityFrameworkCore;

namespace Projekt
{
    public class Userdb : DbContext
    {
        public Userdb(DbContextOptions<Userdb> options) : base(options) { }

        

        public DbSet<User> Users { get; set; }
    }
}
