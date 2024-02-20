using KodlamaioCSharp.Business.Abstrats;
using KodlamaioCSharp.DataAccess.Abstrats;
using KodlamaioCSharp.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCSharp.Business.Concretes
{
    internal class InstructorManager : IInstructorService
    {
        IInstructorDal _InstructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _InstructorDal = instructorDal;


        }
        public void Add(Instructor instructor)
        {
            _InstructorDal.Add(instructor);
        }
        public void Delete(Instructor entity)
        {
            _InstructorDal.Delete(entity);
        }

        public List<Instructor> GetAll()
        {

            return _InstructorDal.GetAll();
        }



        public void Update(Instructor entity)
        {
            _InstructorDal.Update(entity);        }
    }
}
