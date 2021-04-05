using System;
using System.Collections.Generic;

namespace JobApplication_App.Entity.Models
{
    public partial class Application
    {
        public Application()
        {
            Confirmation = new HashSet<Confirmation>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string HighSchool { get; set; }
        public string University { get; set; }
        public string ApplicationLetter { get; set; }
        public string Cv { get; set; }
        public int JobAdvertId { get; set; }

        public virtual JobAdvert JobAdvert { get; set; }
        public virtual ICollection<Confirmation> Confirmation { get; set; }
    }
}
