using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPA_exams.Models
{
    public class ExamResult
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Semester number")]
        public int Semester { get; set; }
        [Required]
        [DisplayName("Subject name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Please, enter correct subject name")]
        public string Subject { get; set; }
        /*public int? SubjectId { get; set; }
        public virtual Subject Subject { get; set; }*/
        [Required]
        [Mark(ErrorMessage = "Invalid mark: the mark has to be in range from 2 to 5")]
        [DisplayName("Exam mark")]
        public int Mark { get; set; }
    }
}