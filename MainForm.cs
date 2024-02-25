using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel;
using System.Windows.Forms;

namespace PetShop
{
    public partial class MainForm : Form
    {
        private readonly Data.ZooContext context = new();

        private BindingList<Models.Stock> stockBindingList;
        private BindingList<Models.ShipmentGoodList> shipmentsBindingList;


        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Shown()
        {
            if (!this.Visible || !Program.isLogin)
                return;

            if (Program.UserType is null)
            {
                ShowNoValidUserError();
                return;
            }

            LoadStockData();
            if (Program.UserType.Name == "Seller")
            {
                RestrictSeller();
                LoadCartData();
            }
            else if (Program.UserType.Name == "Manager")
            {
                RestrictManager();
                LoadShipmentData();
            }
        }

        private void ShowNoValidUserError()
        {
            var loginRetry = MessageBox.Show(
                    caption: "ОШИБКА",
                    text: "Недопустимый тип учетной записи. Попробуйте войти с помощью другого аккаунта",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.RetryCancel);

            if (loginRetry == DialogResult.Retry)
                Program.SwitchToLogin();

            else if (loginRetry == DialogResult.Cancel)
                Application.ExitThread();
        }

        #region Restriction

        private void RestrictSeller()
        {
            shipmentTab.Parent = null;
            cartTab.Parent = tabControl1;
            stockPlusButton.Enabled = true;
        }

        private void RestrictManager()
        {
            shipmentTab.Parent = tabControl1;
            cartTab.Parent = null;
            stockPlusButton.Enabled = false;
            saveButton.Enabled = false;
            stockDataGridView.ReadOnly = true;
        }

        #endregion

        #region Load data

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

        private void LoadShipmentData()
        {
            shipmentDataGridView.AutoGenerateColumns = false;

            context.ShipmentGoodLists.Load();

            shipmentsBindingList = context.ShipmentGoodLists.Local.ToBindingList();

            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "ShipmentGoodsId",
                ReadOnly = true,
                ValueType = typeof(int)
            };
            shipmentDataGridView.Columns.Add(idColumn);

            var goodColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Поставленный товар",
                DataPropertyName = "ShipmentGoodId",
                DataSource = context.ShipmentGoods.ToList(),
                DisplayMember = "Name",
                ValueMember = "ShipmentGoodId"
            };
            shipmentDataGridView.Columns.Add(goodColumn);

            var providerColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Поставщик",
                DataPropertyName = "ProviderId",
                DataSource = context.Providers.ToList(),
                DisplayMember = "Name",
                ValueMember = "ProviderId"
            };
            shipmentDataGridView.Columns.Add(providerColumn);

            shipmentDataGridView.DataSource = shipmentsBindingList;
        }

        private void LoadCartData()
        {
            cartDataGridView.AutoGenerateColumns = false;

            context.Goods.Load();
            context.Prices.Load();

            var goodColumn = new DataGridViewComboBoxColumn
            {
                Name = "GoodId",
                HeaderText = "Товар",
                DataPropertyName = "GoodId",
                DataSource = context.Goods.ToList(),
                DisplayMember = "Name",
                ValueMember = "GoodId"
            };
            cartDataGridView.Columns.Add(goodColumn);


            var priceColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Цена",
                ReadOnly = true,
                ValueType = typeof(int)
            };
            cartDataGridView.Columns.Add(priceColumn);

            var amountColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Кол-во",
                ValueType = typeof(int)
            };
            cartDataGridView.Columns.Add(amountColumn);

        }

        #endregion

        #region Events

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Program.SwitchToLogin();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            stockDataGridView.EndEdit();
            shipmentDataGridView.EndEdit();
            context.SaveChanges();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                var goodPrice = (decimal)row.Cells[1].Value;
                var goodCount = (int)row.Cells[2].Value;
                sum += goodPrice * goodCount;
            }

            var dialogResult = new CheckoutForm{ moneyAmount = sum }.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddOrder();
            }
        }

        #endregion

        #region PlusButtons Events

        private void stockPlusButton_Click(object sender, EventArgs e)
        {
            var previousRow = stockDataGridView.RowCount - 1;
            var lastId = stockDataGridView.Rows[previousRow].Cells[0].Value;
            var newId = (int)lastId + 1;
            stockBindingList.Add(
                new Models.Stock()
                {
                    StockId = newId
                });
        }

        private void shipmentPlusButton_Click(object sender, EventArgs e)
        {
            var previousRow = shipmentDataGridView.RowCount - 1;
            var lastId = shipmentDataGridView.Rows[previousRow].Cells[0].Value;
            var newId = (int)lastId + 1;
            shipmentsBindingList.Add(
                new Models.ShipmentGoodList()
                {
                    ShipmentGoodsId = newId
                });
        }

        private void cartPlusButton_Click(object sender, EventArgs e)
        {
            int goodId = 0;

            var good = context.Goods.Include("Price").FirstOrDefault(g => g.GoodId == goodId);

            cartDataGridView.Rows.Add(0, good?.Price.Value, 1);
        }

        #endregion

        private void cartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                int goodId = Convert.ToInt32(cartDataGridView.Rows[e.RowIndex].Cells["GoodId"].Value);

                var good = context.Goods.Include("Price").FirstOrDefault(g => g.GoodId == goodId);

                if (good != null)
                {
                    cartDataGridView.Rows[e.RowIndex].Cells[1].Value = good.Price.Value;
                }
            }
        }

        private void AddOrder()
        {
            throw new NotImplementedException();
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

    }
}
