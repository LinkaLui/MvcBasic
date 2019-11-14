using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Family
    {
        
        public int Id { get; set; }
        [Display(Name = "身份證字號")]
        public string IdNumber { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "電話")]
        public string Phone { get; set; }
        [Display(Name = "年齡")]
        public int Age { get; set; }
        [Display(Name = "城市")]
        public string City { get; set; }
    }
}