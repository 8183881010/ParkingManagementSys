using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ParkingManagementSys.Models
{
    public class UserModel
    {
        public int AdminID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required")]
        [StringLength(10, ErrorMessage = "Name not be Exceed")]
        [Display(Name = " First Name: ")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required")]
        [StringLength(10, ErrorMessage = "Name not be Exceed")]
        [Display(Name = " Last Name: ")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]

        [DataType(DataType.EmailAddress)]
        [Display(Name = " Email ID: ")]
        public string EmailID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password  is required")]

        [Display(Name = " Password: ")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "The length Should be between 6 to 10 Charaters.")]
        [RegularExpression("[A-Za-z0-9],{6,10}", ErrorMessage = "Password should have atleast one number,one lowercase letter,one Uppercase letter.")]
        

        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Confrim Password  is required")]
        [Display(Name = " Confirm Password: ")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = " Confrim Password and Password Should be same")]
        public string ConfirmPassword { get; set; }
        public string SuccessMessage { get; set; }
    }
}