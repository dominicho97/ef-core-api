using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationAPI.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Options;
using BookAPI.Models;


namespace RegistrationAPI.Controllers
{
 

    [ApiController] 
    public class BookController : ControllerBase
    {

        public BookController()
        {
 
        }


        [HttpGet]
        [Route("/locations")]
        public List<Author> GetLocations(){
            return null;
        }

        [HttpGet]
        [Route("/vaccins")]
        public List<Author> GetAuthors(){
            return null;
        }

        [HttpGet]
        [Route("/registrations")]
        public ActionResult<List<Book>> GetBooks(string date = ""){
            return Ok();
        }

        [HttpPost]
        [Route("/registration")]
        public ActionResult<Book> AddBook(Book book){
            
            return null;
        }

    }
}
