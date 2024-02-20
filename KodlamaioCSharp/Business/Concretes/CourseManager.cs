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
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal= courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course id)
        {
            _courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
