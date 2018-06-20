using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.Service
{
    public class EmployeeService
    {
        public List<SelectListItem> GetEmployeeName()
        {
            List<SelectListItem> item = new List<SelectListItem>();
            foreach (Employees i in NewEmployee)
            {
                item.Add(new SelectListItem() {
                    Value = i.EmployeeId.ToString(),
                    Text = i.EmployeeFirstName + i.EmployeeLastName
                });

                
                           }
            return item;
        }

        public static List<Employees> NewEmployee = new List<Employees>()
        {
            new Employees()
            {
                EmployeeId=1,
                EmployeeFirstName="green",
                EmployeeLastName="tea"
            },
            new Employees()
            {
                EmployeeId=2,
                EmployeeFirstName="red",
                EmployeeLastName="tea"
            },
             new Employees()
            {
                EmployeeId=3,
                EmployeeFirstName="blue",
                EmployeeLastName="tea"
            }
        };
    }


}