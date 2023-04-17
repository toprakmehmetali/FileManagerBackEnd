using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Dtos
{
    public class FolderForCreateDto:IDto
    {
        public int UserId { get; set; }

        public int? FolderId { get; set; }

        public string Name { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsHidden { get; set; }

        public bool ReadOnly { get; set; }
        
    }
}
