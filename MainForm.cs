using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PetShop
{
    public partial class MainForm : Form
    {
        private readonly Data.ZooContext context = new();

        private BindingList<Models.Stock> stockBindingList;


        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Shown()
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

            context.Stocks.Load();

            stockBindingList = context.Stocks.Local.ToBindingList();

            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "StockID",
                ReadOnly = true,
                ValueType = typeof(int)
            };
            stockDataGridView.Columns.Add(idColumn);

            var goodColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Товар",
                DataPropertyName = "GoodID",
                DataSource = context.Goods.ToList(),
                DisplayMember = "Name",
                ValueMember = "GoodID"
            };
            stockDataGridView.Columns.Add(goodColumn);

            var amountColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Кол-во",
                DataPropertyName = "Amount",
                ValueType = typeof(int)
            };
            stockDataGridView.Columns.Add(amountColumn);

            var locationColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Местонахождение",
                DataPropertyName = "StockLocationID",
                DataSource = context.StockLocations.ToList(),
                DisplayMember = "LocationDesc",
                ValueMember = "StockLocationID"
            };
            stockDataGridView.Columns.Add(locationColumn);

            var timeColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Поставка",
                DataPropertyName = "ShipmentGoodsId",
                DataSource = context.ShipmentGoodLists.ToList(),
                DisplayMember = "Time",
                ValueMember = "ShipmentGoodsId"
            };
            stockDataGridView.Columns.Add(timeColumn);

            stockDataGridView.DataSource = stockBindingList;

        }

        private void stockDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

            context.ShipmentGoodLists.Load();

            var shipmentData = context.ShipmentGoodLists.Local.ToBindingList();
            shipmentDataGridView.DataSource = shipmentData;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            stockDataGridView.EndEdit();
            shipmentDataGridView.EndEdit();
            context.SaveChanges();
            context.Dispose();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            stockDataGridView.EndEdit();
            context.SaveChanges();
        }

        private void stockDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void stockPlusButton_Click(object sender, EventArgs e)
        {
            var previousRow = stockDataGridView.RowCount - 1;
            var lastId = stockDataGridView.Rows[previousRow].Cells[0].Value;
            var newId = (int)lastId + 1;
            Console.WriteLine($"Change row StockId to {newId}");
            stockBindingList.Add(
                new Models.Stock(){
                    StockId = newId
                });
        }
    }
}
