using Restuarant_ASP_Task.DATA;
using Restuarant_ASP_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.Services
{
    public class MealRepository : IRepository
    {

        private readonly MealDbContext _context;

        public MealRepository(MealDbContext context)
        {
            _context = context;
        }
        public void Add(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            foreach (var item in _context.Meals)
            {
                if (item.Id==id)
                {
                    _context.Meals.Remove(item);
                }
            }
            _context.SaveChanges();
        }

        public Meal Get(int id)
        {
            foreach (var item in _context.Meals)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<Meal> GetAll()
        {
            return _context.Meals.ToList();
        }

        public void Update(Meal meal)
        {
            foreach (var item in _context.Meals)
            {
                if (item.Id==meal.Id)
                {
                    item.Name = meal.Name;
                    item.Type = meal.Type;
                    item.Price = meal.Price;
                }
            }
            _context.SaveChanges();
        }
    }
}
