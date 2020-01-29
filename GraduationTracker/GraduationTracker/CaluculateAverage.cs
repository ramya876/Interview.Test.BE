using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
   public class CaluculateAverage
    {
        public long CaluculateavgStrudent(Diploma diploma, Student student)
        {
            var average = 0;
            var credits = 0;
            for (int i = 0; i < diploma.Requirements.Length; i++)
            {
                for (int j = 0; j < student.Courses.Length; j++)
                {
                    var requirement = Repository.GetRequirement(diploma.Requirements[i]);

                    for (int k = 0; k < requirement.Courses.Length; k++)
                    {
                        if (requirement.Courses[k] == student.Courses[j].Id)
                        {
                            average += student.Courses[j].Mark;
                            if (student.Courses[j].Mark > requirement.MinimumMark)
                            {
                                credits += requirement.Credits;
                            }
                        }
                    }
                }
            }

#pragma warning disable S1854 // Unused assignments should be removed
            return average /= student.Courses.Length;
#pragma warning restore S1854 // Unused assignments should be removed
        }
    }
}
