using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms
{
    public partial class NumericKeyBoardDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Result { get; set; } = string.Empty;

        public NumericKeyBoardDialog()
        {
            InitializeComponent();
        }

        public void initForm(bool numbersOnly)
        {
            btnSlash.Enabled = !numbersOnly;
            btnStar.Enabled = !numbersOnly;
            btnMinus.Enabled = !numbersOnly;
            btnPlus.Enabled = !numbersOnly;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = lblResult.Text;
            Accepted = true;
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}.";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}3";
        }

        private void btnSlash_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}/";

        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{lblResult.Text.Trim()}+";
        }
    }
}
