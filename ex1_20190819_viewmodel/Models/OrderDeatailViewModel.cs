using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ex1_20190819_viewmodel.Models
{
    public class OrderDeatailViewModel
    {
        //Orderdetail
        [Display(Name = "ProductID")]
        [Required(ErrorMessage = "ProductID未輸入")]
        public int ProductID { get; set; }

        [Display(Name = "UnitPrice")]
        [Required(ErrorMessage = "UnitPrice未輸入")]
        public int UnitPrice { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity未輸入")]
        public int Quantity { get; set; }

        [Display(Name = "Discount")]
        [Required(ErrorMessage = "Discount未輸入")]
        public float Discount { get; set; }

    }
}