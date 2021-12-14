using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace Nshop.Views.ViewComponents.Menu
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponents : ViewComponent
    {
        public MenuViewComponents() { }
      
        public IViewComponentResult Invoke() => View("Menu");
    }
}
