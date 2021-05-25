using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public string Email { get; set; }
        [CompareProperty("Email",
            ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
        // Other properties
    }
}
