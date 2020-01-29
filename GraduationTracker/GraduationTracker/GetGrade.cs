using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
   public class GetGrade
    {
        public Tuple<bool, STANDING> GetStudentGrade(long average)
        {

            if (average < 50)
            {

                return new Tuple<bool, STANDING>(false, STANDING.Remedial);
            }
            else if (average < 80)
            {
                return new Tuple<bool, STANDING>(true, STANDING.Average);
            }
            else if (average < 95)
            {
                return new Tuple<bool, STANDING>(true, STANDING.MagnaCumLaude);
            }
            else
            {
                return new Tuple<bool, STANDING>(false, STANDING.MagnaCumLaude);
            }

        }
    }
}
