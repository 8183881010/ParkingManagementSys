using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParkingManagementSys.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [Display(Name = " Email ID : ")]
        public string EmailID { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = " Password : ")]
        public string Password { get; set; }
    }
}