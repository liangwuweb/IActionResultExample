using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        //[Route("/")]
        //public ContentResult Index()
        //{

        //    return Content("<h3>Hello from Index<h3>", "text / html");

        //}

        [Route("bookstore/{bookid?}/{isloggedin?}")]
        public IActionResult Index(int? bookid, bool? isloggedin)
        {
            //Book id should be appield
            if (!bookid.HasValue)
            {
         
                return BadRequest("no book id");
            }


            if (bookid <= 0 || bookid > 1000)
            {
                return NotFound("bookId is not in the range");

            }

            //islooedin is true
            if ((bool)!isloggedin)
            {
                return Unauthorized("User must be authenticated");

            }
            return Content($"Book id: {bookid}", "text/plain");
        }
    }
}
