using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class ShowModel : FilmPageModel
     {
          [Required]
          [DataType(DataType.Date)]
          public DateTime Date { get; set; }
          [Required]
          [DataType(DataType.Time)]
          public TimeSpan Time { get; set; }
          [Required]
          [DataType(DataType.Currency)]
          public decimal Price { get; set; }
     }
}