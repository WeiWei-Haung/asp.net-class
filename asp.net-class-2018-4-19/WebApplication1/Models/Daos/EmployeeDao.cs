using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Daos
{
    public class EmployeeDao : BaseDao
    {
        public List<Employees> GetEmployees()
        {
            List<Employees> result = new List<Employees>();
            using (SqlConnection conn = GetSqlConnection())
            {
                string sql = "select * from HR.Employees";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new Employees
                    {
                        EmployeeId = int.Parse(row["EmployeeID"].ToString()),
                        EmployeeLastName = row["LastName"].ToString(),
                        EmployeeFirstName = row["FirstName"].ToString()
                    });
                }
            }
            return result;
        }
         
    }
}