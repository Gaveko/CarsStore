using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.Models
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public IQueryable<Category> Categories => new List<Category>
        {
            new Category { CategoryName = "Car",
                Cars = new List<Car>
                {
                    new Car {Name = "Lada"},
                    new Car {Name = "Porshe"}
                }
            },
            new Category {CategoryName = "Truck",
                Cars = new List<Car>
                {
                    new Car {Name = "Mercedes"}
                }
            }
        }.AsQueryable<Category>();
            

    }
}
