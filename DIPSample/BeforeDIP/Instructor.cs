using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeDIP
{
    //EN : High Level Instructor depends on low level Student. if student class changes ... 
    //TR : Üst seviye "Instructor" sınıfı, alt seviye "Student" sınıfına bağımlı. Eğer "Student" sınıfı değişirse.. 
    public class Instructor
    {
        private Student student;
        public void SetStudent(Student newStudent)
        {
            student = newStudent;
        }

        public string AssignWork()
        {
            return student.AcceptWork();
        }
    }
}
