using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class EditReserveToysRookRequestDto
    {
        public int Reserve_Toy_Room_ID { get; set; }
        public int Kids_No { get; set; }
        public decimal Amount { get; set; }
        public string Reserver_Name { get; set; }
        public DateTime Due_Date { get; set; } = DateTime.Now;
        public bool Done { get; set; } = false;
        public bool Canceled { get; set; } = false;
        public string? Notes { get; set; }
        public string User_Name { get; set; }
    }
}
