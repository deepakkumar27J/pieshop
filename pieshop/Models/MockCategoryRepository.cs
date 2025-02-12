using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pieshop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All fruit pies assemble" },
                new Category { CategoryId = 2, CategoryName = "Cheese Cakes", Description = "Cheesy cakes assemble" },
                new Category
                    { CategoryId = 3, CategoryName = "Seasonal Pies", Description = "All seasonal pies assemble" }
            };
    }
}
