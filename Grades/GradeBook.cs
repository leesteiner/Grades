using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public List<float> Grades { get; set; } = new List<float>();

        public GradeBook()
        {

        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);    
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            
            foreach(float grade in Grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / Grades.Count;
            return stats;
        }


    }
}
