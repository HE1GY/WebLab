using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebLab.Model.Lab1
{
    [Table("Student")]
    public partial class Student
    {
        [Required]
        [StringLength(50)]
        public string Profession { get; set; }
        [Required]
        [StringLength(50)]
        public string GroupCode { get; set; }
        [Key]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Key]
        [StringLength(50)]
        public string SecondName { get; set; }
        [StringLength(50)]
        public string MiddelName { get; set; }
        [Required]
        [StringLength(50)]
        public string DateOfBirth { get; set; }
        [Required]
        [StringLength(50)]
        public string HomeAddress { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }
    }
}
