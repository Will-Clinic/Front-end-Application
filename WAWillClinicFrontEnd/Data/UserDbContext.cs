﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models;

namespace WAWillClinicFrontEnd.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base (options)
        {

        }

        public DbSet<RSVPUser> Users { get; set; }
    }
}
