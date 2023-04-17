using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IFolderDal : IEntityRepository<Folder>
{
    public List<string> GetFolderLocation(int folderId);
}