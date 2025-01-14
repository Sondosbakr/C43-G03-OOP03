

using System;
using System.Deployment.Internal;

namespace Assignment03OOP
{
    #region Q1

    public enum SecurityPrivileges
    {
        Guest,
        Developer,
        Security,
        DBA
    }
    public class Employee
    {
        #region Attributes
        private char gender;
        #endregion

        #region Property
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate;
        public SecurityPrivileges SecurityLevel { get; set; }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine("Gener must be 'M' or 'F'");
            }
        }
        #endregion

        #region Constructor
        public Employee(char gender, int iD, string name, decimal salary, HiringDate hireDate, SecurityPrivileges securityLevel)
        {
            Gender = gender;
            ID = iD;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
        }
        #endregion


        #region Method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}, Hire Date: {HireDate}, Security Level: {SecurityLevel}";
        }
        #endregion
    }
    #endregion



    #region Q2
    public class HiringDate
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constractor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Day {Day}, Month {Month}, Year {Year}";
        }
        #endregion
    }
    #endregion
    internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }

