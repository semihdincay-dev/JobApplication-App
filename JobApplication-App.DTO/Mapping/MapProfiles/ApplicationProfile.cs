using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.DTO.Mapping.MapProfiles
{
    public class ApplicationProfile : ProfileBase
    {
        public ApplicationProfile()
        {
            CreateMap<Application, ApplicationDTO>().ReverseMap();
        }
    }
}
