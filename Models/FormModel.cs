﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models
{
    public class FormModel
    {
        public FormModel()
        {
        }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Role { get; set; }

        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SubjectName { get; set; }
        public short Grade { get; set; }
        public string Section { get; set; }
        public string Homeroom { get; set; }



    }
}
