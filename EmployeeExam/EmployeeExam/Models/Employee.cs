using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExam.Models
{
    public class Employee
    {
        public string name;
        public string surname;
        public string fathername;
        public int age;
        public string FIN;
        public string number;
        public string position;
        public int salary;

        public Employee(string _name, string _surname, string _fathername, int _age, string _FIN, string _number, string _position, int _salary)
        {
            name = _name;
            surname = _surname;
            fathername = _fathername;
            age = _age;
            FIN = _FIN;
            number = _number;
            position = _position;
            salary = _salary;
        }
    }
}
