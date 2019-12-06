using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {


        [BindNever]
        public int id { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage ="Failed Firstname")]
        public string name { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Lastname")]
        public string lastname { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Country")]
        public string country { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Street")]
        public string street { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Number Street")]
        public string numberstreet { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed City")]
        public string city { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Code")]
        public int code { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Required(ErrorMessage = "Failed Phone")]
        public string phone { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Failed E-mail")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDeteil> orderDeteils { get; set; }



    }
}
