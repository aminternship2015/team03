using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class UsersModel
    {
        public int id_user { get; set; }
        [StringLength(30),Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^([a-zA-Z .&'-]+)$", ErrorMessage = "Invalid First Name")]
        public string First_Name { get; set; }
        [StringLength(30),Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^([a-zA-Z .&'-]+)$", ErrorMessage = "Invalid Last Name")]
        public string Last_Name { get; set; }
        [StringLength(32, MinimumLength = 8), Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        public string Roles { get; set; }
    }
}
