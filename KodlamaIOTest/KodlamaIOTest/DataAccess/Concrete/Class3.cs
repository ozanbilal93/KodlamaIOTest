using DataAccess.Abstract;
using Entities5.Concrete;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor { Id = 1, Name = "Engin Demiroğ", About = "Öğretmen1" };
            Instructor instructor2 = new Instructor { Id = 2, Name = "Atıl Samancıoğlu", About = "Öğretmen2" };

            List<Instructor> instructors = new List<Instructor> { instructor1, instructor2 };
            _instructors = instructors;
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _instructors.Remove(entity);
        }

        public Instructor Get(int id)
        {
            return _instructors.Where(i => i.Id == id).FirstOrDefault();
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor entity)
        {
            _instructors.Where(i => i.Id == entity.Id).FirstOrDefault().Name = entity.Name;
        }
    }
}