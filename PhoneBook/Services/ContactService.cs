using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public class ContactService
    {
        private readonly PhoneBookContext _context;

        public ContactService(PhoneBookContext context)
        {
            _context = context;
        }

        public async Task InsertContact(Contact ctt)
        {
            _context.Add(ctt);
             await _context.SaveChangesAsync();
        }

        public async Task<List<Contact>> FindAllAsync()
        {
            return await _context.Contact.ToListAsync();
        }
    }
}
