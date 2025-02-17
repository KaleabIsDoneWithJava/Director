﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models;
using Director.Models.Forms;
using Director.Models.Services;


namespace Director.Models.Functions
{
    public class AddStaff
    {
        
        //Might use if there is more than one teacher teaching a single subject in a single grade,
        //otherwise there is no need. Plus I'm pretty sure that it isn't correct.
       /* public ICollection<Class> ArrayToICollection(FormModel model)
        {
            
            ICollection<Class> classStaffs = null;
            foreach (var section in model.SectionsTaught)
            {
                if (section == null) { continue; }

            }
            return classStaffs;
        }*/

        //passing the teacher detail from the form model class to the teacher model class/entity
        public Teacher PassTeacher(FormModel model)
        {
            //If there Homeroom class isn't set
            if (model.Section != 0) 
            {
                Teacher staff = new Teacher
                {
                    //object members must be initialized like this, otherwise they're will throw a null instance exception.
                    SubjectForGrade = new SubjectForGrade { GradeId = model.Grade, SubjectId = model.Subject }
                };

                staff.FirstName = model.FirstName;
                staff.FathersName = model.FathersName;
                staff.GrandFathersName = model.GrandFathersName;
                staff.DateOfBirth = model.DateOfBirth;
                staff.Gender = model.Gender;
                staff.Email = model.Email;
                staff.Phone = model.Phone;

            return staff;
            }
            else
            {
                Teacher staff = new Teacher
                {
                    //object members must be initialized like this, otherwise they're will throw a null instance exception.
                    Classes = new List<Class> { new Class { GradeId = model.Grade, SectionId = model.Section } },
                    SubjectForGrade = new SubjectForGrade { GradeId = model.Grade, SubjectId = model.Subject }
                };

                staff.FirstName = model.FirstName;
                staff.FathersName = model.FathersName;
                staff.GrandFathersName = model.GrandFathersName;
                staff.DateOfBirth = model.DateOfBirth;
                staff.Gender = model.Gender;
                staff.Email = model.Email;
                staff.Phone = model.Phone;

            return staff;
            }



        }

        //passing the office staff detail from the form model class to the OfficeStaff model class/entity.
        public OfficeStaff PassOfficeStaff(FormModel model) 
        {
            OfficeStaff staff = new();

            staff.FirstName = model.FirstName;
            staff.FathersName = model.FathersName;
            staff.GrandFathersName = model.Role;
            staff.DateOfBirth = model.DateOfBirth;
            staff.Gender = model.Gender;
            staff.Email = model.Email;
            staff.Phone = model.Phone;
            
        return staff;          
        }





    }
}
