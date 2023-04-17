using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Mapper.Automapper
{
    public class BusinessMapperProfile:Profile
    {

        public BusinessMapperProfile()
        {
            CreateMap<Folder, FolderForCreateDto>().ReverseMap();

            CreateMap<Folder, FolderForDelete>().ReverseMap();
        }
    }
}
