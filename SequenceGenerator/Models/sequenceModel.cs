using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SequenceGenerator.Models
{
    public class sequenceModel
    {
       [Required(ErrorMessage = "Sequence Limit Value is required")]
       [Range(0, int.MaxValue, ErrorMessage = "Please enter valid whole number")]
       [Display(Name = "Sequence Limit")]
        public int limitValue { get; set; }
    }
}