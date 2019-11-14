using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.ViewModels
{
    public class PeopleViewModel
    {
        public List<Employee> employee { get; set; }
        public List<Friend> friend { get; set; }
    }
}