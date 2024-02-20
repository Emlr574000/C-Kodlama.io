using KodlamaioCSharp.Business.Abstrats;
using KodlamaioCSharp.Business.Concretes;
using KodlamaioCSharp.DataAccess.Abstrats;
using KodlamaioCSharp.DataAccess.Concretes;
using KodlamaioCSharp.Entities.concretes;

internal class Program
{
    private static void Main(string[] args)
    {


        CourseManager courseManager = new CourseManager(new CourseDal());
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());
        //Yazdır...
        List<Course> courses = courseManager.GetAll();

        foreach (Course course in courses)
        {
            Console.WriteLine($"{course.Name} kampı : {course.Description} ; Fiyatı : {course.Price}");
        }

        // Kurs ekle... 
        categoryManager.Add(new Category() { CategoryId = 4, CategoryName = "Go" });
        courseManager.Add(new Course() { AuthorId = 1, CategoryId = 2, Description = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", Id = 4, Name = "Java", Price = 600 });
        instructorManager.Add(new Instructor() { AuthorId = 3, AuthorName = "Emirhan Şentürk" });
        // Kurs Sil...
        courseManager.Delete(new Course() { AuthorId = 1, CategoryId = 2, Description = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", Id = 4, Name = "Java", Price = 600 });
        categoryManager.Delete(new Category() { CategoryId = 4, CategoryName = "Go" });
        instructorManager.Delete(new Instructor() { AuthorId = 3, AuthorName = "Emirhan Şentürk" });
        

    }
}