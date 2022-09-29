﻿using Director.Models.Forms;
using Director.Models.Functions;
using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Controllers
{
    public class StudentController : Controller
    {
        // Delclaring the student service to have access to the dbContext class and any other special classes
        // that are involved in the student class interacting with the database.
        private readonly IStudentService _studentService;
        private readonly IClassService _classService;
        private readonly IAppointmentService _appointmentService;

        public StudentController(IStudentService studentService, IClassService classService, IAppointmentService appointmentService)
        {
            // the service is instantiated in the controller's constructor
            _studentService = studentService;
            _classService = classService;
            _appointmentService = appointmentService;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            AddAppointment.AppointmentFormAndStudentData model = new();
            
            //Gets all students along with their parents info from the db synchronously
            model.allStudentsWithParents = _studentService.GetAllStudentDetail();

            //Doing this because the MakeAppointment popup is a partial view.
            model.Form = new AppointmentFormModel();

            return View(model);
        }

        public ActionResult MakeAppointment()
        {
            return View();
        }


        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/AddStudent
        public async Task<ActionResult> AddStudentAsync(StudentFormModel model)
        {
            //Can't use the builtin method ModelState. IsValid because the Role property that 
            //StudentFormModel has inherited isn't going to be needed.

            if (!model.IsEmpty())
            {
                    AddStudent addStudent = new(_classService);
                    await _studentService.AddAsync(addStudent.PassStudentAsync(model));                   
            }
            else 
            {
                return View();
            }
           
        return View(model);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
