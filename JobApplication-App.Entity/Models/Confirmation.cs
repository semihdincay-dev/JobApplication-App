using System;
using System.Collections.Generic;

namespace JobApplication_App.Entity.Models
{
    public partial class Confirmation
    {
        public int Id { get; set; }
        public int ApplicationStateId { get; set; }
        public int? ApplicationId { get; set; }

        public virtual Application Application { get; set; }
        public virtual StateOfApplication ApplicationState { get; set; }
    }
}
