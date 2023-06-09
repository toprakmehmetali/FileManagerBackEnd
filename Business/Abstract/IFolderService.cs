﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract;

public interface IFolderService
{
    IDataResult<Folder> GetById(int folderId);
    IDataResult<List<Folder>> GetChildFoldersByFolderId(int folderId);
    IResult Add(FolderForCreateDto folderForCreateDto);
    IResult Delete(FolderForDelete folderForDelete);
    IResult Update(Folder folder);
    IDataResult<List<string>> GetFolderLocationById(int folderId);
    IResult CheckIfFolderExist(int folderId);

}