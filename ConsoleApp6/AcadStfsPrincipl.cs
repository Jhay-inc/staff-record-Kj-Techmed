﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class AcadStfsPrincipl : IAllStaffsFunctnalitis, IPrincplFunctnalitis
    {
        public bool id { get; set; }
        public string idColor { get; set; }
        public string name { get; set; }
        public bool carSpace { get; set; }
    }
}
