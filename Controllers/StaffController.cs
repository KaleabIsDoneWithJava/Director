﻿using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Threading.Tasks;
using Director.Models;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Director.Models.Forms;
using Director.Models.Functions;

namespace Director.Controllers
{
    public class StaffController : Controller
    {
        // Delclaring the services to have access to the dbContext class and any other special classes
        // that are involved in their respective entity classes interacting with the database.

        private readonly IOfficeStaffService _officestaffService;
        private readonly ITeacherService _teacherService;

        private readonly IAppointmentService _appointmentService;
        private readonly ISubjectService _subjectService;
        private readonly IClassService _classService;



        /*
        public StaffController(IStaffService service)
        {
            _staffService = service;
        }*/
        
        
        public StaffController(IOfficeStaffService ss, IAppointmentService ass, ISubjectService sss, IClassService cs, ITeacherService ts)
        {
            // the services are instantiated in the controller's constructor

            _officestaffService = ss;
            _appointmentService = ass;
            _subjectService = sss;
            _classService = cs;
            _teacherService = ts;
        }
        
        //Appointments, Teachers & OfficeStaff lists are on the My Staff page

        public async Task<ActionResult> IndexAsync()
        {
            //ViewBag.Title = "My Staff";
            dynamic myStaff = new ExpandoObject();
            //myStaff.Appointments = await _appointmentService.GetListByIdAsync(staffId);
            // myStaff.Notifications = await _notificationService.GetListByIdAsync(staffId);

            myStaff.OfficeStaff = await _officestaffService.GetAllAsync();
            myStaff.Teacher = _teacherService.GetAllTeacherDetail();


            //myStaff.Teacher = await _teacherService.GetAllAsync();

            //myStaff.Classes = await _classService.GetAllAsync();


            return View(myStaff);

        }
        
        public async Task<ActionResult> AddStaffAsync(FormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                if (!model.IsEmpty())
                {

                    if(model.Role == "Teacher")
                    {
                        AddStaff addTeacher = new();

                        await _teacherService.AddAsync(addTeacher.PassTeacher(model));
                        //await _subjectService.AddAsync(staff);
                        //await _classService.AddAsync(classesTaught);

                    }
                    else //model.Role == "OfficeStaff"
                    {
                        AddStaff addOfficeStaff = new();

                        await _officestaffService.AddAsync(addOfficeStaff.PassOfficeStaff(model));
                    }

                }

            }
            return View(model);               
        }
              
        // GET: StaffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
