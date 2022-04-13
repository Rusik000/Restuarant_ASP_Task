using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.Entities
{
    public class Meal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Price { get; set; }
        public string ImagePath { get; set; }

    }
}
