using Entities5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities5.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

    }
}