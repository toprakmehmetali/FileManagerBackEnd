using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class File : IEntity
    {
        public int Id { get; set; }

        public int FolderId { get; set; }

        public int? UserId { get; set; }

        public string Name { get; set; }

        public int ExtensionId { get; set; }

        public DateTime UploadeDateTime { get; set; }
        public bool IsPrivate { get; set; }

        public bool ReadOnly { get; set; }

        public float Size { get; set; }

        public User user { get; set; }
        public Folder Folder { get; set; }

        public Extension Extension { get; set; }
    }
}
