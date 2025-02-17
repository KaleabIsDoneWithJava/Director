﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Forms
{
    public class FormModel
    {
        public FormModel()
        {
            //SectionsTaught = new string[10];
        }
        
        //public Staff MiniStaff { get; set; }
        //public string SubjectName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Father's Name")]
        public string FathersName { get; set; }
        [DisplayName("Grandfather's Name")]
        public string GrandFathersName { get; set; }
        [DisplayName("Staff Type")]
        public string Role { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string Phone { get; set; }
        [DisplayName("Subject")]

        //Exclusively Teacher's fields
        public int Subject { get; set; }
        [DisplayName("Grade")]
        public short Grade { get; set; }
        [DisplayName("Homeroom")]
        public int Section { get; set; }
        
        //public string Homeroom { get { return Grade + Section; } }
        //public string[] SectionsTaught { get; set; }

        public bool IsEmpty()
        {
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(FathersName) || String.IsNullOrEmpty(GrandFathersName)
                || String.IsNullOrEmpty(Role) || String.IsNullOrEmpty(Gender)
                || String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Phone)) 
            { return true; }
            return false;
        }        

    }
}
