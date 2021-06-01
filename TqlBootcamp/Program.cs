using System;
using TqlBootcamp.Models;
using System.Linq;

namespace TqlBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BootcampContext();


            //var newStudent = new Student
            //{
            //    Firstname = "Mattea",
            //    Lastname = "Swain",
            //    TargetSalary = 8000.00m,
            //    InBootcamp = true
            //};

            //context.Students.Add(newStudent);
            //context.SaveChanges();


            //var firstAssessment = new Assessment
            //{
            //    Topic = "Git",
            //    NumberofQuestions = 6,
            //    MaxPoints = 120
            //};

            //var secondAssessment = new Assessment
            //{
            //    Topic = "Sql Server ",
            //    NumberofQuestions = 12,
            //    MaxPoints = 110
            //};

            //var thirdAssessment = new Assessment
            //{
            //    Topic = "CSharp",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};

            //var fourthAssessment = new Assessment
            //{
            //    Topic = "Java Script// html",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};

            //var fifthAssessment = new Assessment
            //{
            //    Topic = "Angular",
            //    NumberofQuestions = 11,
            //    MaxPoints = 110
            //};

            //context.Assessments.Add(firstAssessment);
            //context.Assessments.Add(secondAssessment);
            //context.Assessments.Add(thirdAssessment);
            //context.Assessments.Add(fourthAssessment);
            //context.Assessments.Add(fifthAssessment);
            //context.SaveChanges();

            //var gitScore = new AssessmentScore()
            //{
            //    StudentId = newStudent.Id,
            //    AssessmentId = firstAssessment.Id,
            //    Score = 120
            //};


            //var sqlScore = new AssessmentScore()
            //{
            //    StudentId = newStudent.Id,
            //    AssessmentId = secondAssessment.Id,
            //    Score = 110
            //};

            //context.AssessmentScores.AddRange(gitScore, sqlScore);
            //context.SaveChanges();



            // Calculate the average of the Assessment Scores //



            //var assessmentScores = (from a in context.AssessmentScores select a)
            //    .Average(assessmentScores => assessmentScores.Score);


            //var assessmentAvgScore = context.AssessmentScores.ToArray();

            //                            // what columns you want to average goes in ()
            //assessmentAvgScore.Average(assessmentAvgScore => assessmentAvgScore.Score);

            var matteaScores = from s in context.Students
                               join a in context.AssessmentScores
                               on s.Id equals a.StudentId
                               join amt in context.Assessments
                               on a.AssessmentId equals amt.Id
                               select new
                               {
                                   s.Lastname, a.Score
                                 
                               };
            foreach( var score in matteaScores)
            {
                Console.WriteLine($"{score.Lastname} {score.Score}");
            }
            
        }

        


    }
    
}
