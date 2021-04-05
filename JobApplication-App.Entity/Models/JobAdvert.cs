using System;
using System.Collections.Generic;

namespace JobApplication_App.Entity.Models
{
    public partial class JobAdvert
    {
        public JobAdvert()
        {
            Application = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? NumbOfRecruit { get; set; }
        public int? MaxAppNum { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }
}
