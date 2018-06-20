﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Daos
{
    public abstract class BaseDao
    {
        /// <summary>
        /// 連線用字串
        /// </summary>
        protected string ConnString;


        /// <summary>
        /// 建構子 取得連線字串
        /// </summary>
        protected BaseDao()
        {
            ConnString= ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }

        /// <summary>
        ///  取得SqlConnection
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnString);
        }
    }
}