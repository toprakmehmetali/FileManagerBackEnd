using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using File = Entities.Concrete.File;

namespace DataAccess.Concrete.EntityFramework
{
    public class FileDal:EfEntityRepositoryBase<File, FileManagerContext>,IFileDal
    {
    }
}
