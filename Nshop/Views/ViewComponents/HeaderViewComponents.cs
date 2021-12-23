using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nshop.Views.ViewComponents.Header
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponents : ViewComponent
    {
        public HeaderViewComponents(){}
        public IViewComponentResult Invoke()
        {
            return View("Header");

        }
    }
}
