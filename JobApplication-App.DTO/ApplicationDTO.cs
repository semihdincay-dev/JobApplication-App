using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobApplication_App.DTO
{
    public class ApplicationDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim soy isim girilmelidir.")]
        public string FullName { get; set; }
        public string HighSchool { get; set; }
        public string University { get; set; }
        [Required(ErrorMessage = "Başvuru alanı doldurulmalıdır.")]
        public string ApplicationLetter { get; set; }
        public byte[] CV { get; set; }
        public int JobAdvertId { get; set; }
        public List<ConfirmationDTO> Confirmations { get; set; }
    }
}
