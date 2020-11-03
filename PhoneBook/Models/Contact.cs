using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [StringLength(60, MinimumLength = 2, ErrorMessage ="{0} size between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage ="{0} Required")]
        [EmailAddress(ErrorMessage ="Enter a correct Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="{0} Required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        public string Number { get; set; }
    }
}
