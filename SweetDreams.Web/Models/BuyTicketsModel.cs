using SweetDreams.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SweetDreams.Web.Models
{
     public class BuyTicketsModel : NavbarModel
     {
          public BuyTicketsModel()
          {
               SelectedTickets = new bool[14, 10];
               TicketsId = new int[14, 10];
               for (int row = 0; row < 14; row++)
               {
                    for (int seat = 0; seat < 10; seat++)
                    {
                         SelectedTickets[row, seat] = false;
                         TicketsId[row, seat] = 0;
                    }
               }
          }
          public ShowDTO Show { get; set; }
          public int[,] TicketsId { get; set; }
          public bool[,] SelectedTickets { get; set; }
     }
}