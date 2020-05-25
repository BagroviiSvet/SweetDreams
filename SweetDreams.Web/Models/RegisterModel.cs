using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class RegisterModel
     {
          [Required]
          [DataType(DataType.EmailAddress)]
          public string Mail { get; set; }
          [Required]
          [DataType(DataType.Text)]
          public string Name { get; set; }
          [Required]
          [DataType(DataType.PhoneNumber)]
          public string PhoneNumber { get; set; }
          [Required]
          [DataType(DataType.Password)]
          public string Password { get; set; }
          [Required]
          [DataType(DataType.Password)]
          [Compare("Password")]
          public string ConfirmPassword { get; set; }
     }
}