﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examination3.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Exam Subject")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exam subject required")]
        public string Subject { get; set; }
        [Display(Name = "Start Time")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Start time required")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Display(Name = "Exam Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exam date required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Exam Duration")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Exam duration required")]
        public string ExamDuration { get; set; }
        [Display(Name = "Class Room")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Class room required")]
        public string ClassRoom { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Faculty required")]
        public string Faculty { get; set; }

    }
}