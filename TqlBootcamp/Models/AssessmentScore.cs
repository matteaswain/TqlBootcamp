using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TqlBootcamp.Models
{
    public class AssessmentScore
    {
        public int Id { get; set; }
        public int Score { get; set; }
       
        [Required]
        public int StudentId { get; set; }
// virtual tells EF that this is a foregin key for the Students table
        public virtual Student Student { get; set; } // instance of our Student class
        [Required]
        public int AssessmentId { get; set; }
        public virtual Assessment Assessment { get; set; }

        public AssessmentScore()
        {

        }
    }
}
