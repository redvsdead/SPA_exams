using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPA_exams.Models
{
    public class MarkAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int mark = Convert.ToInt32(value);
            return (mark >= 2 && mark <= 5);
        }
    }
}