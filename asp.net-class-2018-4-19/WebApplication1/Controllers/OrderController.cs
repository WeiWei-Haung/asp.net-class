using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Service;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            EmployeeService employeeService = new EmployeeService();
            ViewBag.employeeService = employeeService.GetEmployeeName();

            ShipperService shipperService = new ShipperService();
            ViewBag.shipperService = shipperService.GetShipperName();

            return View();
        }

        /// <summary>
        ///查詢訂單 
        /// </summary>
        /// <param name="sea"></param>
        /// <returns></returns>
        [HttpPost] 
        public ActionResult Search(Search sea)
        {
            OrderService OrderService = new OrderService();
            
            return View(OrderService.GetOrderCondition(sea));
        }

        /// <summary>
        /// 修改訂單
        /// </summary>
        /// <param name="oederID"></param>
        /// <returns></returns>
        public ActionResult Update(int orderID)
        {
            ///連結orderService
            OrderService orderService = new OrderService();
            ///員工下拉式選單
            EmployeeService employeeService = new EmployeeService();
            List<SelectListItem> employeeitems = employeeService.GetEmployeeName();
            ViewBag.employeeService = employeeitems;
            ///出貨公司下拉式選單
            ShipperService shipperService = new ShipperService();
            List<SelectListItem> shipperitems = shipperService.GetShipperName();
            ViewBag.shipperService = shipperitems;
            ///顧客下拉式選單
            CustomerService customerService = new CustomerService();
            List<SelectListItem> selectListItems = customerService.GetCustomerList();
            ViewBag.customerService = selectListItems;
            return View(orderService.GetOrder(orderID));
        }
    
    }
}