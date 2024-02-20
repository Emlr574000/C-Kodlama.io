using KodlamaioCSharp.DataAccess.Abstrats;
using KodlamaioCSharp.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCSharp.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor = new Instructor();
            instructor.AuthorName = "Engin Demiroğ";
            instructor.AuthorId = 1;
            Instructor instructor2 = new Instructor();
            instructor2.AuthorName = "Halit Enes Kalaycı";
            instructor2.AuthorId = 2;

            instructors = new List<Instructor>() { instructor,instructor2};
            
        }
        public void Add(Instructor instructor)
        {
            Console.WriteLine($"Eğitimci eklendi : {instructor.AuthorName}");
            //Veritabanına ekleme kodları yazılacak.
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine($"Eğitimci veritabanından silindi :{instructor.AuthorName}");
            //Veritabanından silme kodları yazılacak.
        }

        public List<Instructor> GetAll()
        {

            return instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine($"Eğitimciler güncellendi :{instructor.AuthorName}");
            //Veritabanında güncelleme kodları yazılacak.
        }
    }
}
