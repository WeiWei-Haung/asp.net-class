using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.Daos;

namespace WebApplication1.Models.Service
{
    public class OrderService
    {
     

        /// <summary>
        /// 進行Order的查詢
        /// </summary>
        /// <param name="orderID">訂單編號</param>
        /// <returns></returns>
        public Orders GetOrder(int orderID)
        {
            OrderDao dao = new OrderDao();
            return dao.GetOrderById(orderID);
        }

        /// <summary>
        /// 取得 Orders by 條件
        /// </summary>
        /// <returns></returns>
        public IList<Orders> GetOrders(OrderQueryArg arg)
        {
            CustomerService customerService = new CustomerService();

            OrderDao orderDao = new OrderDao();
            // 取得所有訂單後進行篩選  (注意: 此處應將查詢條件串入SQL中為較好之寫法)
            IEnumerable<Orders> currentOrders = orderDao.GetAllOrders();

            // 訂單編號
            if (arg.OrderID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.OrderID == arg.OrderID.Value);
            }

            // 客戶名稱 (like 查詢)
            if (!string.IsNullOrWhiteSpace(arg.CompanyName))
            {
                currentOrders =
                    currentOrders.Where(
                        m => customerService.GetCompanyName(m.CustomerID).Contains(arg.CompanyName)
                    );
            }

            // 員工編號
            if (arg.EmployeeID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.EmployeeID == arg.EmployeeID.Value);
            }

            // 出貨公司
            if (arg.ShipperID.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.ShipperID == arg.ShipperID.Value);
            }

            // 訂購日期
            if (arg.OrderDate.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.OrderDate == arg.OrderDate.Value);
            }

            // 需要日期
            if (arg.RequiredDate.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.RequiredDate == arg.RequiredDate.Value);
            }

            // 出貨日期
            if (arg.ShipedDate.HasValue)
            {
                currentOrders = currentOrders.Where(m => m.ShippedDate == arg.ShipedDate.Value);
            }

            return currentOrders.OrderBy(m => m.OrderID).ToList();
        }

        /// <summary>
        /// 新增 Order
        /// </summary>
        /// <param name="order">欲新增的訂單資料</param>
        public void InsOrder(Orders order)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.AddNewOrderReturnNewOrderId(order);
        }

        /// <summary>
        /// 更新 Order
        /// </summary>
        /// <param name="order">欲更新的訂單資料</param>
        public void UpdOrder(Orders order)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.UpdateOrder(order);
        }

        /// <summary>
        /// 刪除 Order
        /// </summary>
        /// <param name="orderID">訂單編號</param>
        public void DelOrder(int orderID)
        {
            OrderDao orderDao = new OrderDao();
            orderDao.DeleteOrder(orderID);
        }
    */

    }
}