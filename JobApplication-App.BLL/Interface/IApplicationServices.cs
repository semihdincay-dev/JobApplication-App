using JobApplication_App.DTO;
using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.BLL.Interface
{
    public interface IApplicationServices
    {
        ApplicationDTO[] getAll();
        ApplicationDTO getById(int Id);
        void Delete(int Id);
        void UpdateApplication(ApplicationDTO Entity);
        void Add(ApplicationDTO Entity);
    }
}
