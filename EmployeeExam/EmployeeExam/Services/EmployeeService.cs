using EmployeeExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExam.Services
{
    public class EmployeeService 
    {
        public bool NameCheck(string name_)
        {
            int namecontroller = 0;
            if (name_.Length >= 2 && name_.Length <= 20)
            {
                if (Convert.ToInt32(Convert.ToChar(name_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(name_[0])))
                {
                    for (int y = 1; y < name_.Length; y++)
                    {
                        if (97 <= Convert.ToInt32(Convert.ToChar(name_[y])) && Convert.ToInt32(Convert.ToChar(name_[y])) <= 122)
                        {
                            namecontroller++;
                        }
                        else { break; }
                    }
                }
            }
            if (namecontroller == name_.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SurnameCheck(string surname_)
        {
            int surnamecontroller = 0;
            if (surname_.Length >= 2 && surname_.Length <= 35)
            {
                if (Convert.ToInt32(Convert.ToChar(surname_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(surname_[0])))
                {
                    for (int y = 1; y < surname_.Length; y++)
                    {
                        if (97 <= Convert.ToInt32(Convert.ToChar(surname_[y])) && Convert.ToInt32(Convert.ToChar(surname_[y])) <= 122)
                        {
                            surnamecontroller++;
                        }
                        else { break; }
                    }
                }
            }
            if (surnamecontroller == surname_.Length - 1)
            {
                return true;
            }
            else { return false; }
        }

        public  bool FatherCheck(string fathername_)
        {
            int fathernamecontroller = 0;
            if (fathername_.Length >= 2 && fathername_.Length <= 20)
            {
                if (Convert.ToInt32(Convert.ToChar(fathername_[0])) <= 90 && 65 <= Convert.ToInt32(Convert.ToChar(fathername_[0])))
                {
                    for (int y = 1; y < fathername_.Length; y++)
                    {
                        if (97 <= Convert.ToInt32(Convert.ToChar(fathername_[y])) && Convert.ToInt32(Convert.ToChar(fathername_[y])) <= 122)
                        {
                            fathernamecontroller++;
                        }
                        else { break; }
                    }
                }
            }
            if (fathernamecontroller == fathername_.Length - 1)
            {
                return true;
            }
            else
            { return false; }
        }
        public  bool AgeCheck(int age_)
        {
            if (18 <= age_ && age_ <= 65)
            {
                return true;
            }
            else { return false; }

        }
        public  bool FINCheck(string FIN_)
        {
            int FINcontroller = 0;
            if (FIN_.Length == 7)
            {
                for (int y = 1; y < FIN_.Length; y++)
                {
                    if ((65 <= Convert.ToInt32(Convert.ToChar(FIN_[y])) && Convert.ToInt32(Convert.ToChar(FIN_[y])) <= 90) || (48 <= Convert.ToInt32(Convert.ToChar(FIN_[y])) && Convert.ToInt32(Convert.ToChar(FIN_[y])) <= 57))
                    {
                        FINcontroller++;
                    }
                    else { break; }
                }
            }
            if (FINcontroller == FIN_.Length - 1)
            {
                return true;
            }
            else { return false; }
        }
        public  bool NumberCheck(string number_)
        {
            string numberstartwith = "+994";
            int numbercontroller = 0;
            if (number_.Length == 13)
            {
                for (int t = 0; t < 4; t++)
                {
                    if (number_[t] == numberstartwith[t])
                    {
                        numbercontroller++;
                    }
                }
                for (int t = 4; t < 13; t++)
                {
                    if (48 <= Convert.ToInt32(Convert.ToChar(number_[t])) && Convert.ToInt32(Convert.ToChar(number_[t])) <= 57)
                    {
                        numbercontroller++;
                    }
                }
            }
            if (numbercontroller == 13)
            {
                return true;
            }
            else { return false; }
        }
        public  bool PositionCheck(string position_)
        {
            if (position_ == "HR" || position_ == "Audit" || position_ == "Engineer")
            {
                return true;
            }
            else { return false; }

        }
        public  bool SalaryCheck(int salary_)
        {
            if (1500 <= salary_ && salary_ <= 5000)
            {
                return true;
            }
            else { return false; }
        }
    }
}
