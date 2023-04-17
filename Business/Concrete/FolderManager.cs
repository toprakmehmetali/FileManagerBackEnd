using AutoMapper;
using Business.Abstract;
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
        folder.Type = "folder";
        this.folderDal.Add(folder);
        return new SuccessResult();
    }

    public IResult Delete(Folder folder)
    {
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

    public IResult Update(Folder folder)
    {
        this.folderDal.Update(folder);
        return new SuccessResult();
    }
}