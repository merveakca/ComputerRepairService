﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairService.Models;
public class ServiceStatus : BaseModel
{
    public string StatusName { get; set; }
    public string StatusDescription { get; set; }
}
