using AutoMapper;
using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete;

public class FolderManager : IFolderService
{
    private IFolderDal folderDal;
    private IMapper mapper;

    public FolderManager(IFolderDal folderDal,IMapper mapper)
    {
        this.folderDal = folderDal;
        this.mapper = mapper;
    }

    public IResult Add(FolderForCreateDto folderForCreateDto)
    {
        Folder folder = mapper.Map<Folder>(folderForCreateDto);
        folder.Size = 0;
        folder.CreateDateTime = DateTime.Now;
        this.folderDal.Add(folder);
        return new SuccessResult();
    }

    public IResult Delete(FolderForDelete folderForDelete)
    {
        var result = BusinessRules.Run(CheckIfChildFolderExist(folderForDelete.Id), 
                          CheckIfFolderExist(folderForDelete.Id));
        if (result != null)
        {
            return new ErrorResult(result.Message);
        }
        Folder folder = mapper.Map<Folder>(folderForDelete);
        this.folderDal.Delete(folder);
        return new SuccessResult();
    }

    public IDataResult<Folder> GetById(int folderId)
    {
        return new SuccessDataResult<Folder>(folderDal.Get(f => f.Id == folderId));
    }

    public IDataResult<List<Folder>> GetChildFoldersByFolderId(int folderId)
    {
        return new SuccessDataResult<List<Folder>>(folderDal.GetList(f=>f.FolderId == folderId).ToList());
    }

    public IDataResult<List<string>> GetFolderLocationById(int folderId)
    {
        return new SuccessDataResult<List<string>>(this.folderDal.GetFolderLocationById(folderId));
    }

    public IResult Update(Folder folder)
    {
        this.folderDal.Update(folder);
        return new SuccessResult();
    }

    public IResult CheckIfChildFolderExist(int folderId)
    {
        var result = GetChildFoldersByFolderId(folderId);
        if (result.Data.Count != 0)
        {
            return new ErrorResult("Klasör Boşaltılmadan Silinemez.");
        }
        return new SuccessResult();
    }

    public IResult CheckIfFolderExist(int folderId)
    {
        var result = GetById(folderId);
        if (result.Data == null)
        {
            return new ErrorResult("Böyle bir klasör bulunamadı.");
        }
        return new SuccessResult();
    }

}
