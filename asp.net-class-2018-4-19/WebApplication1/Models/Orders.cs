using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    /// <summary>
    /// 訂單的資料
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        [DisplayName("訂單編號")]
        [Required()]
        public int? OrderID { get; set; }

        /// <summary>
        ///客戶編號 
        /// </summary>
        [DisplayName("客戶ID")]
        [Required()]
        public int? CustomerID { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工ID")]
        [Required()]
        public int? EmployeeID { get; set; }

        /// <summary>
        /// 訂購日期
        /// </summary>
        [DisplayName("訂購日期")]
        [Required()]
        public DateTime? OrderDate { get; set; }


        /// <summary>
        /// 客戶需要日期
        /// </summary>
        [DisplayName("需要日期")]
        [Required()]
        public DateTime? RequiredDate { get; set; }


        /// <summary>
        /// 貨物出貨日期
        /// </summary>
        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; }


        /// <summary>
        /// 出貨編號
        /// </summary>
        [DisplayName("出貨編號")]
        public int? ShipperID { get; set; }


        /// <summary>
        /// 貨物運費
        /// </summary>
        [DisplayName("貨物運費")]
        public Decimal Freight { get; set; }


        /// <summary>
        /// 出貨地址
        /// </summary>
        [DisplayName("出貨地址")]
        public string ShipAddress { get; set; }

        /// <summary>
        /// 出貨城市
        /// </summary>
        [DisplayName("出貨城市")]
        public string ShipCity { get; set; }

        /// <summary>
        /// 出貨地區
        /// </summary>
        [DisplayName("出貨地區")]
        public string ShipRegion { get; set; }

        /// <summary>
        /// 出貨地點郵遞區號
        /// </summary>
        [DisplayName("郵遞區號")]
        public int? ShipPostalCode { get; set; }

        /// <summary>
        /// 出貨國家
        /// </summary>
        [DisplayName("出貨國家")]
        public string ShipCountry { get; set; }
    }
}