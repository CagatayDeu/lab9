using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    [Serializable]
    class University
    {
        private string name;
        private List<Student> students = new List<Student>();

        public List<Student> Students
        {
            get { return students; }
        }

        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public Student SearchStudent(string name)
        {
            Student t = null;

            
            foreach(Student i in students)
            {
                if(i.Name == name)
                {
                    return i;
                }
            }

            return t;
        }
     
        
        public Student SearchStudent(int no)
        {
            Student t = null;

            foreach (Student i in students)
            {
                if (i.No == no)
                {
                    return i;
                }
            }

            return t;
        }


       
    }
}
