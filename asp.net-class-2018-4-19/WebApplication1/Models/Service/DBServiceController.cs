using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.Service
{
    public class DBService
    {
        /// <summary>
        /// 資料庫連線服務
        /// </summary>
        /// <returns></returns>
        public string GetConnStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}