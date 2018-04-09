using System.Web.Mvc;
using System.Collections.Generic;
namespace MvcPrint.Models
{
    public class HomeModel 
    {
        public List<SelectListItem> LocalPrinters { get; set; }
        public List<SelectListItem> NetworkPrinters { get; set; }
    }
}