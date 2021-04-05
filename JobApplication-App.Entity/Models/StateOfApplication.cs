using System;
using System.Collections.Generic;

namespace JobApplication_App.Entity.Models
{
    public partial class StateOfApplication
    {
        public StateOfApplication()
        {
            Confirmation = new HashSet<Confirmation>();
        }

        public int Id { get; set; }
        public string State { get; set; }

        public virtual ICollection<Confirmation> Confirmation { get; set; }
    }
}
