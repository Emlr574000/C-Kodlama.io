using KodlamaioCSharp.DataAccess.Abstrats;
using KodlamaioCSharp.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCSharp.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.AuthorId = 1;
            course1.Price = 0;
            course1.Description = "Yazılım Geliştirici Yetiştirme Kampı(C# + Angular)";
            course1.CategoryId = 1;
            course1.Name = "C#";
            course1.Id = 1;
            Course course2= new Course();
            course2.AuthorId = 1;
            course2.Price = 0;
            course2.Description = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course2.CategoryId = 2;
            course2.Name = "Java";
            course2.Id = 2;
            Course course3= new Course();
            course3.AuthorId = 2;
            course3.Price = 0;
            course3.Description = "(2023)Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course3.CategoryId = 3;
            course3.Name = "Python";
            course3.Id = 3;

            courses=new List<Course> { course1 ,course2};
        }
        public void Add(Course course)
        {
            Console.WriteLine($"Kurs veritabanına eklendi : {course.Name}");
            //Veritabanına ekleme kodları yazılacak.
        }

        public void Delete(Course course)
        {
            
            Console.WriteLine($"Kurs veritabanından silindi :{course.Name}");
            //Veritabanından silme kodları yazılacak.
        }

        public List<Course> GetAll()
        {

            return courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine($"Kurslar güncellendi :{course.Name}");
            //Veritabanında güncelleme kodları yazılacak.
        }
    }
}
