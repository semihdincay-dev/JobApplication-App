using AutoMapper;
using JobApplication_App.BLL.Interface;
using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobApplication_App.BLL.Abstract
{
    public class ConfirmationServices : IConfirmationServices
    {
        private readonly JobApplicationDBContext _context;
        private readonly IMapper _mapper;
        public ConfirmationServices(IMapper mapper, JobApplicationDBContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Confirmation> getAll()
        {
           return _context.Confirmation.ToList();
        }

        public Confirmation getById(int Id)
        {
            return _context.Confirmation.FirstOrDefault(z => z.Id == Id);
        }

        public void UpdateConfirmation(Confirmation Entity)
        {
            Confirmation updateConfirmation = _context.Confirmation.FirstOrDefault(z => z.Id == Entity.Id);
            updateConfirmation.ApplicationState.State = Entity.ApplicationState.State;

            _context.SaveChanges();
        }
    }
}
