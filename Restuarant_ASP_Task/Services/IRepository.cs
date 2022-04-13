using Restuarant_ASP_Task.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restuarant_ASP_Task.Services
{
    public interface IRepository
    {
        void Add(Meal item);
        void Delete(int id);
        void Update(Meal item);
        Meal Get(int id);
        IEnumerable<Meal> GetAll();
    }
}
