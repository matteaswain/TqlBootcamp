using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TqlBootcamp.Models
{
    public class Student // make class public
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }

        [Column(TypeName = "decimal(11,2)")]
        public decimal TargetSalary { get; set; }

        public bool? InBootcamp { get; set; } // boolean that allows a null
// brings us a list of assessment scores when calling a student profile 
        public virtual List<AssessmentScore> AssessmentScores { get; set; }
        public Student() { } // default constructer



       
    }
}
