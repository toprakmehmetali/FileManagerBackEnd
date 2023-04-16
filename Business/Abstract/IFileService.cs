using Core.Utilities.Results;
using File = Entities.Concrete.File;

namespace Business.Abstract;

public interface IFileService
{
    IDataResult<File> GetById(int fileId);
    IDataResult<List<File>> GetListByFolderId(int folderId);
    IResult Add(File file);
    IResult Delete(File file);
    IResult Update(File file);

}