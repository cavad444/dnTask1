using Microsoft.AspNetCore.Mvc;

namespace dnTask1.Controllers
{
    public class ProductController:Controller
    {
        public ContentResult Detail(int id)
        {
            return Content(id.ToString());
        }
    }
}
