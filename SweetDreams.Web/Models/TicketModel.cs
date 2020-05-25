using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class TicketModel
     {
          [Required]
          public int Row { get; set; }
          [Required]
          public int Seat { get; set; }
     }
}