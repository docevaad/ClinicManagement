using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagement.Web.Models
{
    public class Patient
    {
        public string PatientID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}