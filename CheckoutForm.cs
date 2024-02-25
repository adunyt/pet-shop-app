using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class CheckoutForm : Form
    {
        public decimal moneyAmount = 0;

        public CheckoutForm()
        {
            InitializeComponent();
            this.Shown += CheckoutForm_Shown;
        }

        private void CheckoutForm_Shown(object? sender, EventArgs e)
        {
            moneyLabel.Text = $"{moneyAmount} р.";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
