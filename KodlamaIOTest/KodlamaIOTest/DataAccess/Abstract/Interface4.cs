﻿using Entities5.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal : IEntityRepository<Instructor>
    {
    }
}