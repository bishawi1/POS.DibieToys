using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class ReserveToysRoomCriteriaViewModel
    {
        public int? Reserve_Toy_Room_ID { get; set; }
        public int? Kids_No { get; set; }
        public int? Amount { get; set; }
        public string? Reserver_Name { get; set; }
        public DateTime? Due_Date { get; set; }
        public bool getDoneOnly { get; set; } = false;
        public bool getWaitingOnly { get; set; } = false;
        public bool getCanceledOnly { get; set; } = false;
        public string? Notes { get; set; }
        public string? User_Name { get; set; }
        public DateTime? Time_Stamp { get; set; }

    }
}
