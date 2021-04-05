using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.DTO.Mapping
{
    public class MapperConfig
    {
        public static void RegisterMappers()
        {
            MapperFactory.RegisterMappers();
        }
    }
}
