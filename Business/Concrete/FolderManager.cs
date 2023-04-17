using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class FolderManager : IFolderService
{
    private IFolderDal folderDal;

    public FolderManager(IFolderDal folderDal)
    {
        this.folderDal = folderDal;
    }

    public IResult Add(Folder file)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(Folder folder)
    {
        throw new NotImplementedException();
    }

    public IDataResult<Folder> GetById(int folderId)
    {
        return new SuccessDataResult<Folder>(folderDal.Get(f => f.Id == folderId));
    }

    public IDataResult<List<Folder>> GetListByFolderId(int folderId)
    {
        throw new NotImplementedException();
    }

    public IResult Update(Folder file)
    {
        throw new NotImplementedException();
    }
}