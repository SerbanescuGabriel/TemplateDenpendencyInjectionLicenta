﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.DB;

namespace DITemplate.Repository.Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GetAllProjects();
    }
}
