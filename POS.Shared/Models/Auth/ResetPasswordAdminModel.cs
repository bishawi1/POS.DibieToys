using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models.Auth
{
    public class ResetPasswordAdminModel
    {
        [Required(ErrorMessage = "Username is required!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "New Password is Required!")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm New Password is required!")]
        public string ConfirmNewPassword { get; set; }

    }
}
