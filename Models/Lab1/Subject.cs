using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebLab.Model.Lab1
{
    [Table("Subject")]
    public partial class Subject
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Titel { get; set; }
        public int Hours { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeOfControl { get; set; }
        public int SessionCode { get; set; }
        public int Mark { get; set; }
    }
}
