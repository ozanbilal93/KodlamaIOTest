﻿using DataAccess.Abstract;
using Entities5.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;
        public CourseDal()
        {
            Course course1 = new Course { Id = 1, Name = "C#", CategoryName = "Yazılım", Description = "", InstructorName = "Engin Demiroğ" };
            Course course2 = new Course { Id = 2, Name = "Python", CategoryName = "Yazılım", Description = "", InstructorName = "Engin Demiroğ" };
            Course course3 = new Course { Id = 3, Name = "Java", CategoryName = "Geliştirme", Description = "", InstructorName = "Engin Demiroğ" };

            List<Course> courses = new List<Course> { course1, course2, course3 };
            _courses = courses;
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courses.Remove(entity);
        }

        public Course Get(int id)
        {
            return _courses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            _courses.Where(c => c.Id == entity.Id).FirstOrDefault().Name = entity.Name;
        }

        Course IEntityRepository<Course>.Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}