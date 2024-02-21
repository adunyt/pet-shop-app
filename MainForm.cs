using WinFormsApp1.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly BindingSource stockBindingSource = new();
        private readonly BindingSource shipmentBindingSource = new();
        private BindingList<Stock> stockLocalList;
        private BindingList<ShipmentGoodList> shipmentLocalList;


        public MainForm()
        {
            InitializeComponent();
        }

        public async void MainForm_Shown()
        {
            if (!this.Visible || !Program.isLogin)
            {
                return;
            }

            if (Program.UserType is null)
            {
                var loginRetry = MessageBox.Show(
                    caption: "ОШИБКА",
                    text: "Недопустимый тип учетной записи. Попробуйте войти с помощью другого аккаунта",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.RetryCancel);
                if (loginRetry == DialogResult.Retry)
                {
                    Program.SwitchToLogin();
                }
                else if (loginRetry == DialogResult.Cancel)
                {
                    Application.ExitThread();
                }
                return;
            }

            if (Program.UserType.Name == "Seller")
            {
                shipmentTab.Parent = null;
                cartTab.Parent = tabControl1;
                stockPlusButton.Enabled = true;
                LoadStockData();
            }
            else if (Program.UserType.Name == "Manager")
            {
                shipmentTab.Parent = tabControl1;
                cartTab.Parent = null;
                stockPlusButton.Enabled = false;
                LoadShipmentData();
                LoadStockData();
            }
        }

        private void LoadStockData()
        {
            stockDataGridView.AutoGenerateColumns = false;
            using var context = new Data.ZooContext();

            context.Stocks.Load();

            var stocksData = context.Stocks.Include(s => s.Good).Include(s => s.StockLocation).ToList();
            stockDataGridView.DataSource = stocksData;
        }

        private void stockDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using var context = new Data.ZooContext();
            if (e.ColumnIndex == 0)
            {
                if (e.Value != null)
                {
                    int goodID = (int)e.Value;
                    var goodName = context.Goods.FirstOrDefault(g => g.GoodId == goodID)?.Name;
                    e.Value = goodName;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    int stockLocId = (int)e.Value;
                    var stockLoc = context.StockLocations.FirstOrDefault(s => s.StockLocationId == stockLocId);
                    e.Value = $"Стеллаж: {stockLoc?.ShelfNumber}, Полка: {stockLoc?.PalleteNumber}";
                }
            }
        }


        private void shipmentDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using var context = new Data.ZooContext();
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    int shipGoodId = (int)e.Value;
                    var shipGoodName = context.ShipmentGoods.FirstOrDefault(g => g.ShipmentGoodId == shipGoodId)?.Name;
                    e.Value = shipGoodName;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    int providerId = (int)e.Value;
                    var providerName = context.Providers.FirstOrDefault(s => s.ProviderId == providerId)?.Name;
                    e.Value = providerName;
                }
            }
        }

        private void LoadShipmentData()
        {
            shipmentDataGridView.AutoGenerateColumns = false;
            using var context = new Data.ZooContext();

            context.ShipmentGoodLists.Load();

            var shipmentData = context.ShipmentGoodLists.Include(s => s.ShipmentGoods).Include(s => s.Provider).ToList();
            shipmentDataGridView.DataSource = shipmentData;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Application.ExitThread();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Program.SwitchToLogin();
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
