//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkingManagementSys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.InteropServices.ComTypes;

    public partial class Coustmer
    {
        public int CoustID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Coustmer Name is required*")]
        [Display (Name ="Coustmer Name:")]
        public string CoustName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Vechical No is required*")]
        [Display(Name = "Vechical No :")]
        public string VechicalNO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile  No is required*")]

        [Display(Name = "Mobile NO:")]
        public string MobileNO { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Parking Area is required*")]

        [Display(Name = "Parking Area:")]
        public string ParkingArea { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Slot NO is required*")]
        [Display(Name = "Slot NO:")]
        public int SlotNO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Time is required*")]

        [Display(Name = "Enter Time:")]
        public string EnterTime { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exit Time is required*")]

        [Display(Name = "Exit Time:")]
        public string ExitTime { get; set; }
    }
}