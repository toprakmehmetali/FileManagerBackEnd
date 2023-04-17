using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IFolderService
{
    IDataResult<Folder> GetById(int folderId);
    IDataResult<List<Folder>> GetListByFolderId(int folderId);
    IResult Add(Folder file);
    IResult Delete(Folder file);
    IResult Update(Folder file);

}