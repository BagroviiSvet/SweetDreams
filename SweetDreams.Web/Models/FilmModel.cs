using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class FilmModel : NavbarModel
     {
          public int Id { get; set; }
          [Required]
          public string Name { get; set; }
          [Required]
          [DataType(DataType.Duration)]
          public TimeSpan Duration { get; set; }
          [Required]
          [DataType(DataType.Url)]
          public string TrailerUrl { get; set; }
          [Required]
          [DataType(DataType.ImageUrl)]
          public string ImageUrl { get; set; }
     }
}