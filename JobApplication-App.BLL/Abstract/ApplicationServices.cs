using AutoMapper;
using JobApplication_App.BLL.Interface;
using JobApplication_App.DTO;
using JobApplication_App.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobApplication_App.BLL.Abstract
{
    public class ApplicationServices : IApplicationServices

    {
        private readonly JobApplicationDBContext _context;
        private readonly IMapper _mapper;
        public ApplicationServices(IMapper mapper,JobApplicationDBContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Add(ApplicationDTO ApplicationDTO)
        {
            var entity = _mapper.Map<Application>(ApplicationDTO);

            _context.Application.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            try
            {
                var entity = _context.Application.FirstOrDefault(z => z.Id == Id);
                _context.Application.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ApplicationDTO[] getAll()
        {
            var entities = _context.Application.ToList();

            return _mapper.Map<Application[], ApplicationDTO[]>(entities.ToArray());
        }

        public ApplicationDTO getById(int Id)
        {
            var entity = _context.Application.FirstOrDefault(z => z.Id == Id);
            return entity == null ? new ApplicationDTO() : _mapper.Map<ApplicationDTO>(entity);
        }

        public void UpdateApplication(ApplicationDTO Entity)
        {

            var updateEntity = _mapper.Map<Application>(_context.Application.FirstOrDefault(z => z.Id == Entity.Id));
            updateEntity.FullName = Entity.FullName;
            updateEntity.HighSchool = Entity.HighSchool;
            updateEntity.University = Entity.University;
            updateEntity.ApplicationLetter = Entity.ApplicationLetter;
            updateEntity.Cv = Convert.ToBase64String(Entity.CV);

            _context.SaveChanges();
        }
    }
}
