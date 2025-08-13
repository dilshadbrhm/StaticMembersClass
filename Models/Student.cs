using StaticMembersClassTask.Interface;
using StaticMembersClassTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersClassTask.Models
{
    internal class Student : ICodeAcademy
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
               value= value.Trim();
                if (value.ChechName())
                {
                    value=value.Capitalize();
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value=value.Trim();
                if (value.ChechName())
                {
                   value= value.Capitalize();
                    _surname = value;
                }
                
            }
        }


        static int s_count = 0;
        public int Id { get; set; } = 0;
        public string CodeEmail { get; set; }

        public Student(string name,string surname)
        {
            s_count++;
            Id = s_count;
            Name = name;
            Surname = surname;
           
            GenerateEmail();
        }
        public void GetInfo()
        {
            Console.WriteLine($" {Id} {Name} {Surname} {CodeEmail}");
        }

        public void GenerateEmail()
        {
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
        }
    }
}
