using JobApplication_App.BLL.Interface;
using JobApplication_App.DTO;
using Microsoft.AspNetCore.Mvc;

namespace JobApplication_App.WebUI.Controllers
{
    public class JobAdvertController : Controller
    {
        private readonly IJobAdvertServices _jobAdvertServices;

        public JobAdvertController(IJobAdvertServices jobAdvertServices)
        {
            _jobAdvertServices = jobAdvertServices;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateJobAdvert(JobAdvertDTO jobAdvertDTO)
        {
            _jobAdvertServices.Add(jobAdvertDTO);
            return View();
        }
    }
}
