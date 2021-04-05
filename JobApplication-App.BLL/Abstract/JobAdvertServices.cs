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
    public class JobAdvertServices : IJobAdvertServices
    {
        private readonly JobApplicationDBContext _context;
        private readonly IMapper _mapper;
        public JobAdvertServices(IMapper mapper, JobApplicationDBContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(JobAdvertDTO jobAdvertDTO)
        {
            var entity = _mapper.Map<JobAdvert>(jobAdvertDTO);
            _context.JobAdvert.Add(entity);
            _context.SaveChanges();
        }
    }
}
