using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication_App.DTO
{
    public class StateOfApplicationDTO
    {
        public int Id { get; set; }
        public string State { get; set; }
        public List<ConfirmationDTO> Confirmations { get; set; }

    }
}
