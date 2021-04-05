using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobApplication_App.DTO
{
    public class JobAdvertDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İlan başlığı girmek zorunludur.")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Range(1,99)]
        public int? NumbOfRecruit { get; set; }
        public int? MaxAppnum { get; set; }
        public List<ApplicationDTO> Applications { get; set; }

    }
}
