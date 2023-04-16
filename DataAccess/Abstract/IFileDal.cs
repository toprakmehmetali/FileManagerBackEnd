using Core.DataAccess;
using File = Entities.Concrete.File;

namespace DataAccess.Abstract;

public interface IFileDal : IEntityRepository<File>
{
}