using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class WaitingFormDialog : Form
    {
        public WaitingFormDialog()
        {
            InitializeComponent();
        }
        public void setMessage(string Message)
        {
            lblWaitingMessage.Text = Message;
        }
    }
}
