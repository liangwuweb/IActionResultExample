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

        [Route("bookstore")]
        public IActionResult Index()
        {
            //Book id should be appield
            if (!Request.Query.ContainsKey("book-id"))
            {
         
                return BadRequest("no book id");
            }

            //Book id cannot be empty
            if (string.IsNullOrEmpty(Request.Query["book-id"]))
            {
                return BadRequest("Book id is empty");

            }

            int bookId = Convert.ToInt16(Request.Query["book-id"]);
            if (bookId <= 0 || bookId > 1000)
            {
                return NotFound("bookId is not in the range");

            }

            //islooedin is true
            if (!Convert.ToBoolean(Request.Query["isloggedin"]))
            {
                return Unauthorized("User must be authenticated");

            }
            //return new VirtualFileResult("/sample.pdf", "application/pdf");
            //return new RedirectToActionResult("Books", "Store", new object());//302 found
            //return RedirectToAction("Books", "Store", new { id = bookId});
            //return new RedirectToActionResult("Books", "Store", new object(), true); //301 move permantly
            //return RedirectToActionPermanent("Books", "Store", new { id = bookId });
            //return LocalRedirectPermanent($"store/book/{bookId}"); // 301
            return Redirect($"store/books/{bookId}");
        }
    }
}
