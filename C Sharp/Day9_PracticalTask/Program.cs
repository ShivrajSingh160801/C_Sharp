using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AutoMapper;

namespace AutoMapperDemo

{

    class Program

    {

        static void Main(string[] args)

        {
            var config = new MapperConfiguration( cfg => cfg.CreateMap<Student, StudentDT>() );

            Student stu = new Student();

            var mapper = new Mapper(config);

            var stuDT = mapper.Map<StudentDT>(stu);

            Console.ReadLine();

        }
    }
    public class Student
    {
        public string firstName;

        public string lastName;

        public string fullname;

        private enum gender
        {
            Male, Female
        }

        public string Gender { get; set; }
        private string email { get; set; }

        public Int64 phone { get; set; }

        private bool isValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            return Regex.IsMatch(email, pattern);
        }
        private bool isValidPhoneNumber(string phoneNumber)
        {

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            string pattern = @"^[6789]\d{9}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
    public class StudentDT
    {
        public string firstName { get; set; }
        public int lastName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
    }
}
