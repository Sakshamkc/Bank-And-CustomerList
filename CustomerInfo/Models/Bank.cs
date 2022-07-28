using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfo.Models
{
    public class Bank
    {
        [Key]

        public int BankId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Column(TypeName = "nvarchar(100")]
        public string BankName { get; set; }

       

        [Required(ErrorMessage = "Branch is Required")]
        [Column(TypeName = "nvarchar(100")]
        public string Branch { get; set; }

       
    }
}
