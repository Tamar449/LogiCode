using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core;

namespace Core.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        { 
           // CreateMap<DAO.User, DTO.User>().ReverseMap();
        }
    }
}
