﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
