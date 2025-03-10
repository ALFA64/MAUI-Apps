﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}