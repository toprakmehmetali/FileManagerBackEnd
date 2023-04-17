using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Extension:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<File> Files { get; set; }
    }
}
