using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public partial class GraduationTracker
    {

        private GetGrade _gg;
        private CaluculateAverage _cAvg;
        public GraduationTracker(GetGrade gg1, CaluculateAverage cAvg)
        {
           _gg = gg1;
            _cAvg = cAvg;
        }
        public Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student)
        {
            return _gg.GetStudentGrade(_cAvg.CaluculateavgStrudent(diploma, student));
        }
    }
}
