using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcHomeWork.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [StringLength(50),Required(ErrorMessage ="İsim Boş bırakılamaz")]
        public string FirstName { get; set; }
        [StringLength(50), Required(ErrorMessage = "Soyisim Boş bırakılamaz")]
        public string SecondName { get; set; }
        [StringLength(100), Required(ErrorMessage = "Email Boş bırakılamaz")]
        public string Email { get; set; }
        [Required]
        public Boolean JoinStatus { get; set; }
    }
}
