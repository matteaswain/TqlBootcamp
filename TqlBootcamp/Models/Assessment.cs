using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TqlBootcamp.Models
{
   public class Assessment
    {

        public int Id { get; set; }
        
        [Required, StringLength(30)]
        public string Topic { get; set; }

        [Required]
        public int NumberofQuestions { get; set; }

        [Required]
        public int MaxPoints { get; set; }
// brings a list of assessment scores when calling assessment 
        public virtual List<AssessmentScore> AssessmentScores { get; set; }
        public Assessment()
        {
            
        }

    }
}
