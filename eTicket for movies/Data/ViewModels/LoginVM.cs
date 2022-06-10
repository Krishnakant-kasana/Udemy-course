using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email addess")]
        [Required(ErrorMessage = "Emaill address is required")]
        public string EmailAddress { get; set; }

        
        [Required]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
    }
}
