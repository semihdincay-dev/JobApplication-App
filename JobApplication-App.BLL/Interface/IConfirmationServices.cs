using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.BLL.Interface
{
    public interface IConfirmationServices
    {
        List<Confirmation> getAll();
        Confirmation getById(int Id);
        void UpdateConfirmation(Confirmation Entity);
    }
}
