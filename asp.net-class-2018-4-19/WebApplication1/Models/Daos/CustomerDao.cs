using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Daos
{
    public class CustomerDao : BaseDao
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> result = new List<Customer>();
            using (SqlConnection conn = GetSqlConnection())
            {
                string sql = "select * from Sales.Customers";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds);


                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new Customer
                    {
                        CustomerID = int.Parse(row["CustomerID"].ToString()),
                        CompanyName = row["CompanyName"].ToString(),
                        ContactName=row["ConractName"].ToString(),
                        Address=row["Address"].ToString()
                    });

                }
            }
            return result;
    

        }
    }
}