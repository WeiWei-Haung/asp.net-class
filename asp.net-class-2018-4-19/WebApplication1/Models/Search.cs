using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 作為首頁(查詢頁面)用的model
    /// </summary>
    public class Search
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        [DisplayName("訂單編號")]
        public int? OrderID { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        /// 
        [DisplayName("客戶名稱")]
        [Required]
        public string CompanyName { get; set; }

        /// <summary>
        /// 負責員工
        /// </summary>
        /// 
        [DisplayName("負責員工")]
        [Required]
        public int? EmployeeId { get; set; }

        /// <summary>
        /// 出貨公司
        /// </summary>
        /// 
        [DisplayName("出貨公司")]
        [Required]
        public int? ShipperID { get; set; }

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
    }
}