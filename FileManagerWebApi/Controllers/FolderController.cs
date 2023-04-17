using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileManagerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private IFolderService folderService;

        public FolderController(IFolderService folderService)
        {
            this.folderService = folderService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int folderId)
        {
            var result = folderService.GetById(folderId);
            return Ok(result.Data);
        }

        [HttpGet("getfolderlocationbyid")]
        public IActionResult GetFolderLocationById(int folderId)
        {
            var result = folderService.GetFolderLocation(folderId);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FolderForCreateDto folderForCreateDto)
        {
            var result = folderService.Add(folderForCreateDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Folder folder)
        {
            var result = folderService.Update(folder);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Folder folder)
        {
            var result = folderService.Delete(folder);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
