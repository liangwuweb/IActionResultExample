using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/book")]
        public VirtualFileResult Index()
        {   
            ////Book id should be appield
            //if (!Request.Query.ContainsKey("book-id"))
            //{
            //    Response.StatusCode = 400;
            //    return Content("Book id is not applied");
            //}

            ////Book id cannot be empty
            //if (string.IsNullOrEmpty(Request.Query["book-id"])) {
            //    Response.StatusCode = 400;
            //    return Content("Book id is empty");
            
            //}

            //int bookId = Convert.ToInt16(Request.Query["book-id"]);
            //if (bookId <= 0 || bookId > 1000) {
            //    Response.StatusCode = 400;
            //    return Content("bookId is not in the range");

            //}

            ////islooedin is true
            //if (!Convert.ToBoolean(Request.Query["isloggedin"]))
            //{
            //    Response.StatusCode = 401;
            //    return Content("User must be authenticated");

            //}

            return File("/sample.pdf", "appliation/pdf");

        }
    }
}
