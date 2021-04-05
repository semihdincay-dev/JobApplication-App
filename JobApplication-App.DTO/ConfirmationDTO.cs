using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.DTO
{
    public class ConfirmationDTO
    {
        public int Id { get; set; }
        public int ApplicationStateId { get; set; }
        public int? ApplicationId { get; set; }
        public ApplicationDTO Application { get; set; }
        public StateOfApplicationDTO StateOfApplication { get; set; }

    }
}
