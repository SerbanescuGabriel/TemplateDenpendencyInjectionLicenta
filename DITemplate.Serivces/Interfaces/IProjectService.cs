﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.Serivces.Entities;

namespace DITemplate.Serivces.Interfaces
{
    public interface IProjectService
    {
        List<ProjectEntity> GetAllProjectEntities();
    }
}