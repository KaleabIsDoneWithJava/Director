﻿using Director.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class StaffService : EntityBaseRepository<Staff>, IStaffService
    {
        private readonly SMSContext _context;
        public StaffService(SMSContext context) : base(context)
        {
            _context = context;

           
            
            
        }
                        
         


    }
}
