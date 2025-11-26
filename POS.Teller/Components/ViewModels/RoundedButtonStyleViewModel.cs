using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Teller.Components.ViewModels
{
    public class RoundedButtonStyleViewModel
    {
        public int BorderSize { get; set; } = 0;
        public Size? ButtonSize { get; set; }

        public int ButtonHeight { get; set; }
        public Font? ButtonFont { get; set; }
        public Color? TextColor { get; set; }
        public Color? BackColor { get; set; }

    }
}
