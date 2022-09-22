﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
   public interface IClassService : IEntityBaseRepository<Class>
    {
        //Functions that are implemented in ClassService

        public int GetClassGradeSection(int GradeId, int SectionId)


    }
}
