using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_PRG282
{
    class Student
    {
        private int studentNumber;
        private string fullName;
        private string dateOfBirth;
        private string studentGender;
        private string studentPhone;
        private string studentAddress;

        public Student(int studentNumber, string fullName, string dateOfBirth, string studentGender, string studentPhone, string studentAddress)
        {
            this.studentNumber = studentNumber;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.studentGender = studentGender;
            this.studentPhone = studentPhone;
            this.studentAddress = studentAddress;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentPhone { get => studentPhone; set => studentPhone = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
    }
}
