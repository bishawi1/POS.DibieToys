using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class UsersModel
    {
        [Key]
        public int User_ID { get; set; }

        public bool IsActive { get; set; }

        public string User_Name { get; set; }

        public string Password { get; set; }

    }
}
