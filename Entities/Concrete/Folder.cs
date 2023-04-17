using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Folder : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        
        public int? FolderId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime CreateDateTime { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsHidden { get; set; }

        public bool ReadOnly { get; set; }

        public float Size { get; set; }

        
        public User User { get; set; }

        public ICollection<Folder> Folders { get; set; }

        public ICollection<File> Files { get; set; }

    }
}
