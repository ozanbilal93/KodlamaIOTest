using Entities5.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOTest.Business.Abstract
{
    internal interface ICourseService
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        List<Course> GetAll();
        Course GetById(int id);

    }
}
