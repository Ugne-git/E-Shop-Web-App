using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop_Web_Application.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Maistas", Description="Šviežios gėrybės iš kaimo ir daržo"},
                new Category{CategoryId=2, CategoryName="Blusturgis", Description="Įvairūs daugiau ar mažiau naudoti daiktai, žaislai, drabužiai - laukia naujų šeimininkų "},
                new Category{CategoryId=3, CategoryName="Biblioteka", Description="Naujos ir skaitytos knygos, žurnalai ar kiti leidiniai"},
                new Category{CategoryId=4, CategoryName="Paslaugos", Description="Pačios naudingiausios ir reikalingiausios paslaugos kaimynams"}
            };
    }
}
