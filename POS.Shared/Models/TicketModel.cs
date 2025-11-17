using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class TicketModel
    {
        [Key]
        public int Ticket_ID { get; set; }
        [Required]
        public int Batch_No { get; set; }

        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public byte Kids_Count { get; set; }
        [Required]
        public int Ticket_No { get; set; }
        [Required]
        public DateTime Ticket_Date { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Tim_Stamp { get; set; }
    }
}
