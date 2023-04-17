using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;


namespace DataAccess.Concrete.EntityFramework;

public class FolderDal : EfEntityRepositoryBase<Folder, FileManagerContext>, IFolderDal
{
    public List<string> GetFolderLocation(int folderId)
    {
        List<string> location = new();
        using (var context = new FileManagerContext())
        {
            Folder folder = context.Set<Folder>().SingleOrDefault(f => f.Id == folderId);
            location.Insert(0,folder.Name);
            while (folder.FolderId != null)
            {
                folder = context.Set<Folder>().SingleOrDefault(f => f.Id == folder.FolderId);
                location.Insert(0, folder.Name);
            }
        }
        return location;
    }
}