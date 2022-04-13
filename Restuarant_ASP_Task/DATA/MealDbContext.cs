using Microsoft.EntityFrameworkCore;
using Restuarant_ASP_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.DATA
{
    public class MealDbContext:DbContext
    {
        public MealDbContext(DbContextOptions<MealDbContext> options)
            :base(options)
        {

        }
        public DbSet<Meal> Meals { get; set; }

    }
}
