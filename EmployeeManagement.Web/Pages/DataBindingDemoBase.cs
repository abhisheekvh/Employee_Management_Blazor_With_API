﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DataBindingDemoBase: ComponentBase
    {
        public string description { get; set; } = string.Empty;
    }
}
