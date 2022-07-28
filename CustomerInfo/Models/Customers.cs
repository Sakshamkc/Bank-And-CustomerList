using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfo.Models
{
    public class Customers
    {
        [Key]

        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [Column(TypeName ="nvarchar(100")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Column(TypeName = "nvarchar(100")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [Column(TypeName = "nvarchar(100")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        [Column(TypeName = "nvarchar(100")]
        public string Description { get; set; }
    }
}
