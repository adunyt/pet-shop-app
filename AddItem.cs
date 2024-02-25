using PetShop.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PetShop
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            using var context = new Data.ZooContext();

            context.Goods.Load();
            context.ShipmentGoodLists.Load();
            context.StockLocations.Load();


            var data1 = context.Goods.ToList();

            comboBox1.DataSource = data1;
            comboBox1.DisplayMember = "Name"; // Column to display in the ComboBox
            comboBox1.ValueMember = "GoodId"; // Column to use as the value

            var data2 = context.ShipmentGoodLists.ToList();

            comboBox2.DataSource = data2;
            comboBox2.DisplayMember = "Time"; // Column to display in the ComboBox
            comboBox2.ValueMember = "ShipmentGoodsId"; // Column to use as the value

            var data3 = context.StockLocations.ToList();

            comboBox3.DataSource = data3;
            comboBox3.DisplayMember = "ShelfNumber"; // Column to display in the ComboBox
            comboBox3.ValueMember = "StockLocationId"; // Column to use as the value
        }
    }
}
