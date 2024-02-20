using KodlamaioCSharp.DataAccess.Abstrats;
using KodlamaioCSharp.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCSharp.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "C";
            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "Java";
            Category category3 = new Category();
            category3.CategoryId = 3;
            category3.CategoryName="Python";
            categories=new List<Category>() { category1,category2,category3};
        }
        public void Add(Category category)
        {
            Console.WriteLine($"Veritabanına eklendi : {category.CategoryName}");
            //Veritabanına ekleme kodları yazılacak.
        }

        public void Delete(Category category)
        {
            
            Console.WriteLine($"Kategori veritabanından silindi  :{category.CategoryName} ");
            //Veritabanından silme kodları yazılacak.
        }

        public List<Category> GetAll()
        {
            
            return categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine($"Kategoriler güncellendi :{category.CategoryName}");
            //Veritabanında güncelleme kodları yazılacak.
        }
    }
}
