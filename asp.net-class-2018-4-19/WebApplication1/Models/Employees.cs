﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employees
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        ///
        [DisplayName("員工編號")]
        public int EmployeeId { get; set; }
        /// <summary>
        /// 員工姓
        /// </summary>
        /// 
        [DisplayName("員工姓")]
        public string EmployeeFirstName { get; set; }
        /// <summary>
        /// 員工名
        /// </summary>
        /// 
        [DisplayName("員工名")]
        public string EmployeeLastName { get; set; }
        
        }
    }
