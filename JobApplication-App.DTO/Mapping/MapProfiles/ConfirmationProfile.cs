using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.DTO.Mapping.MapProfiles
{
    public class ConfirmationProfile : ProfileBase
    {
        public ConfirmationProfile()
        {
            CreateMap<Confirmation, ConfirmationDTO>().ReverseMap();
        }
    }
}
