using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcHomeWork.Models
{
    [Table("Participants")]
    public class participant
    {
        [Key]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string SecondName { get; set; }
    }
}
