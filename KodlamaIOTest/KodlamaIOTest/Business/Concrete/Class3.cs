using Business.Abstract;
using DataAccess.Abstract;
using Entities5.Concrete;
using KodlamaIOTest.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        List<Instructor> IInstructorService.GetAll()
        {
            throw new NotImplementedException();
        }

        Instructor IInstructorService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}