using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LinqExample
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student { Id = 1, Name = "Alice", Course = "IT", Age = 20, Grade = 95 });
            students.Add(new Student { Id = 2, Name = "Bob", Course = "CS", Age = 21, Grade = 88 });
            students.Add(new Student { Id = 3, Name = "Charlie", Course = "IT", Age = 22, Grade = 92 });
            students.Add(new Student { Id = 4, Name = "David", Course = "IS", Age = 20, Grade = 85 });
            students.Add(new Student { Id = 5, Name = "Eve", Course = "IT", Age = 23, Grade = 98 });

            dtg.DataSource = students;
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dtg.DataSource = null;
            dtg.DataSource = students;
        }

        private void btnHighGrade_Click(object sender, EventArgs e)
        {
            var result = from s in students
                         where s.Grade > 90
                         select s;

            dtg.DataSource = null;
            dtg.DataSource = result.ToList();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            var result = from s in students
                         where s.Course == "IT"
                         select s;

            dtg.DataSource = null;
            dtg.DataSource = result.ToList();
        }

        private void btnNames_Click(object sender, EventArgs e)
        {
            var result = from s in students
                         select new { s.Name };

            dtg.DataSource = null;
            dtg.DataSource = result.ToList();
        }
    }
}

