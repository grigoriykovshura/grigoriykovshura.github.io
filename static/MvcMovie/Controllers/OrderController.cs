using Microsoft.AspNetCore.Mvc;

    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return PartialView();
        }
    
    }