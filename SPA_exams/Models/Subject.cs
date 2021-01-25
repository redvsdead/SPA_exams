using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPA_exams.Models
{
    public class Subject
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Please, enter correct subject name")]
        [DisplayName("Subject name")]
        public string Name { get; set; }
    }
}