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
using RegistrationAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace RegistrationAPI.Controllers
{
 

    [ApiController] 
    public class BookController : ControllerBase
    {


        private BookContext _context;
        public BookController( BookContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/authors")]
        public async Task<List<Author>> GetAuthors(){
            return await _context.Authors.ToListAsync();
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
