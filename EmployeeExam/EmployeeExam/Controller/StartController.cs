using EmployeeExam.Models;
using EmployeeExam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExam.Controller
{
    public class StartController
    {
        public void Start()
        {
            int CommandController = 0;
            EmployeeService employeeService = new EmployeeService();
            string[] ClassElementText = { "Name", "Surname", "Father Name", "Age", "FIN", "Number", "Position", "Salary" };
            Console.WriteLine("Write !Add Command");
            while (true)
            {
                int controller = 0;
                string command = Console.ReadLine();
                if (command == "!Add")
                {
                    string name_ = "";
                    string surname_ = "";
                    string fathername_ = "";
                    int age_ = 0;
                    string FIN_ = "";
                    string number_ = "";
                    string position_ = "";
                    int salary_ = 0;

                    for (int i = 0; i < ClassElementText.Length; i++)
                    {
                        if (i == controller)
                        {
                            Console.WriteLine(ClassElementText[i] + " : ");
                            switch (i)
                            {
                                case 0:
                                    name_ = Console.ReadLine();

                                    if (employeeService.NameCheck(name_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 1:
                                    surname_ = Console.ReadLine();

                                    if (employeeService.SurnameCheck(surname_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 2:
                                    fathername_ = Console.ReadLine();

                                    if (employeeService.FatherCheck(fathername_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 3:
                                    age_ = Convert.ToInt32(Console.ReadLine());

                                    if (employeeService.AgeCheck(age_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 4:
                                    FIN_ = Console.ReadLine();

                                    if (employeeService.FINCheck(FIN_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 5:
                                    number_ = Console.ReadLine();

                                    if (employeeService.NumberCheck(number_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 6:
                                    position_ = Console.ReadLine();

                                    if (employeeService.PositionCheck(position_))
                                    {
                                        controller++;
                                    }

                                    break;
                                case 7:
                                    salary_ = Convert.ToInt32(Console.ReadLine());

                                    if (employeeService.SalaryCheck(salary_))
                                    {
                                        controller++;
                                    }

                                    break;

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Please ente the correct {ClassElementText[controller]}");
                            break;
                        }


                    }
                    if (controller == 8)
                    {
                        CommandController++;
                        Console.WriteLine("EmployeSaved");
                        Employee person = new Employee(name_, surname_, fathername_, age_, FIN_, number_, position_, salary_);
                    }
                    controller = 0;
                }
                else
                {
                    Console.WriteLine("Please enter valid command");
                    Console.WriteLine("Write !Add command");
                }

            }
        }
    }
}
