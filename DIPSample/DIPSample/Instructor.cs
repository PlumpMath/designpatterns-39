using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSample
{
    //EN : High Level Instructor depends on low level Student. if student class changes ... 
    //TR : Üst seviye "Instructor" sınıfı, alt seviye "Student" sınıfına bağımlı. Eğer "Student" sınıfı değişirse.. 
    public class Instructor
    {
        private IStudent student;
        public void SetStudent(IStudent newStudent)
        {
            student = newStudent;
        }

        public string AssignWork()
        {
            return student.AcceptWork();
        }
    }
}
