using Business.Abstract;
using Core.Utilities.Results;

namespace Business.Concrete;

public class FileManager : IFileService
{
    public IResult Add(Entities.Concrete.File file)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(Entities.Concrete.File file)
    {
        throw new NotImplementedException();
    }

    public IDataResult<Entities.Concrete.File> GetById(int fileId)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Entities.Concrete.File>> GetListByFolderId(int folderId)
    {
        throw new NotImplementedException();
    }

    public IResult Update(Entities.Concrete.File file)
    {
        throw new NotImplementedException();
    }
}