using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Services;

namespace PhoneBook.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var list = await _contactService.FindAllAsync();
            return View(list);
        }

       
       
    }
}
