using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCProject.Models
{
    public class Customer
    {
       
        public int? Id { get; set; }

        [Required(ErrorMessage = "Customer code is required")]
        public string CustomerCode { get; set; }

        public double? Amount { get; set; }

    }
    
}