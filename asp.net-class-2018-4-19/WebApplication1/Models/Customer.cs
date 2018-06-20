﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        /// <summary>
        /// 客戶編號
        /// </summary>
        ///
        [DisplayName("客戶編號")]
        public int CustomerID { get; set; }
        /// <summary>
        /// 客戶名稱
        /// </summary>
        /// 
        [DisplayName("客戶名稱")]
        [Required()]
        public string CompanyName { get; set; }
        /// <summary>
        /// 聯繫人姓名
        /// </summary>
        /// 
        [DisplayName("聯繫人姓名")]
        public string ContactName { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        /// 
        [DisplayName("地址")]
        public string Address { get; set; }
    }
}