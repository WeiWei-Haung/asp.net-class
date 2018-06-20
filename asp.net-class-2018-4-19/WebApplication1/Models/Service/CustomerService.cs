using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.Service
{
    public class CustomerService
    {
        /// <summary>
        /// 回傳customer的下拉式選單內容
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetCustomerList()
        {
            DBService DbService = new DBService();
            string conn = DbService.GetConnStr();
            SqlConnection sqlConnettion = new SqlConnection();  //資料庫連線物件
            string sql = "SELECT [CustomerID],[CompanyName] FROM [Sales].[Customers]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlConnettion); //橋接器
            DataSet dataSet = new DataSet();//資料儲存器(內可含多個dataTable
            dataAdapter.Fill(dataSet);//資料庫做動
            DataTable dataTable = dataSet.Tables[0];


            List<SelectListItem> item = new List<SelectListItem>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                item.Add(new SelectListItem()
                {
                    Text = dataTable.Rows[i][1].ToString(),
                    Value = dataTable.Rows[i][0].ToString()
                });
            }
            return item;
        }

        
    }
}