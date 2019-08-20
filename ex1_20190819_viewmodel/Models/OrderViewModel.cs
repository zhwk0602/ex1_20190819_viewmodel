using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ex1_20190819_viewmodel.Models
{
    public class OrderViewModel
    {
        [Display(Name = "OrderID")]
        [Required(ErrorMessage = "OrderID未輸入")]
        public int OrderID { get; set; }

        [Display(Name = "CustomerID")]
        [Required(ErrorMessage = "CustomerID未輸入")]
        [MaxLength(5, ErrorMessage = "長度不可超過5")]
        public string CustomerID { get; set; }

        [Display(Name = "EmployeeID")]
        [Required(ErrorMessage = "EmployeeID未輸入")]
        public int EmployeeID { get; set; }

        [Display(Name = "OrderDate")]
        [Required(ErrorMessage = "OrderDate未輸入")]
        [DataType(DataType.Date, ErrorMessage = "請輸入正確的訂單日期")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "RequiredDate")]
        [Required(ErrorMessage = "RequiredDate未輸入")]
        [DataType(DataType.Date, ErrorMessage = "請輸入正確的RequiredDate")]
        public DateTime RequiredDate { get; set; }

        [Display(Name = "ShippedDate")]
        [Required(ErrorMessage = "EmployeeID未輸入")]
        [DataType(DataType.Date, ErrorMessage = "請輸入正確的ShippedDate")]
        public DateTime ShippedDate { get; set; }



        [Display(Name = "ShipVia")]
        [Required(ErrorMessage = "ShipVia未輸入")]
        
        public int ShipVia { get; set; }

        [Display(Name = "Freight")]
        [Required(ErrorMessage = "Freight未輸入")]
        public int Freight { get; set; }

        [Display(Name = "ShipName")]
        [Required(ErrorMessage = "ShipName未輸入")]
        [MaxLength(40, ErrorMessage = "長度不可超過40")]
        public string ShipName { get; set; }

        [Display(Name = "ShipAddress")]
        [Required(ErrorMessage = "ShipAddress未輸入")]
        [MaxLength(60, ErrorMessage = "長度不可超過60")]
        public string ShipAddress { get; set; }

        [Display(Name = "ShipCity")]
        [Required(ErrorMessage = "ShipCity未輸入")]
        [MaxLength(15, ErrorMessage = "長度不可超過15")]
        public string ShipCity { get; set; }

        [Display(Name = "ShipRegion")]
        [Required(ErrorMessage = "ShipRegion未輸入")]
        [MaxLength(15, ErrorMessage = "長度不可超過15")]
        public string ShipRegion { get; set; }

        [Display(Name = "ShipPostalCode")]
        [Required(ErrorMessage = "ShipPostalCode未輸入")]
        [MaxLength(10, ErrorMessage = "長度不可超過10")]
        public string ShipPostalCode { get; set; }

        [Display(Name = "ShipCountry")]
        [Required(ErrorMessage = "ShipCountry未輸入")]
        [MaxLength(15, ErrorMessage = "長度不可超過15")]
        public string ShipCountry { get; set; }
        //Orderdetail
        //[Display(Name = "ProductID")]
        //[Required(ErrorMessage = "ProductID未輸入")]
        //public int ProductID { get; set; }

        //[Display(Name = "UnitPrice")]
        //[Required(ErrorMessage = "UnitPrice未輸入")]
        //public int UnitPrice { get; set; }

        //[Display(Name = "Quantity")]
        //[Required(ErrorMessage = "Quantity未輸入")]
        //public int Quantity { get; set; }

        //[Display(Name = "Discount")]
        //[Required(ErrorMessage = "Discount未輸入")]
        //public float Discount { get; set; }



        public List<OrderDeatailViewModel> Detail { get; set; }






    }
    
}