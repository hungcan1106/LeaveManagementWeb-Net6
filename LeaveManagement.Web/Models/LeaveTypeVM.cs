﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default number of days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}
