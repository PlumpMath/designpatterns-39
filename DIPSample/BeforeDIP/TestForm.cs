using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeforeDIP
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string result;
            Student student = new Student();
            Instructor instructor = new Instructor();

            instructor.SetStudent(student);
            result = instructor.AssignWork();

            MessageBox.Show(result);
        }
    }
}
