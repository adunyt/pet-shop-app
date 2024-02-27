namespace PetShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            stockTab = new TabPage();
            toolStrip1 = new ToolStrip();
            stockPlusButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            stockDataGridView = new DataGridView();
            formLabel = new Label();
            shipmentTab = new TabPage();
            toolStrip2 = new ToolStrip();
            shipmentPlusButton = new ToolStripButton();
            saveShipmentButton = new ToolStripButton();
            button3 = new Button();
            shipmentDataGridView = new DataGridView();
            label1 = new Label();
            cartTab = new TabPage();
            toolStrip3 = new ToolStrip();
            cartPlusButton = new ToolStripButton();
            checkoutButton = new Button();
            cartDataGridView = new DataGridView();
            label2 = new Label();
            shipmentGoodListBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            goodBindingSource = new BindingSource(components);
            stockLocationBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            stockTab.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockDataGridView).BeginInit();
            shipmentTab.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shipmentDataGridView).BeginInit();
            cartTab.SuspendLayout();
            toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipmentGoodListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(stockTab);
            tabControl1.Controls.Add(shipmentTab);
            tabControl1.Controls.Add(cartTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(687, 413);
            tabControl1.TabIndex = 9;
            // 
            // stockTab
            // 
            stockTab.BackColor = Color.FromArgb(192, 64, 0);
            stockTab.Controls.Add(toolStrip1);
            stockTab.Controls.Add(stockDataGridView);
            stockTab.Controls.Add(formLabel);
            stockTab.Location = new Point(26, 4);
            stockTab.Name = "stockTab";
            stockTab.Padding = new Padding(3);
            stockTab.Size = new Size(657, 405);
            stockTab.TabIndex = 0;
            stockTab.Text = "Склад";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { stockPlusButton, saveButton });
            toolStrip1.Location = new Point(21, 351);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(58, 25);
            toolStrip1.TabIndex = 7;
            // 
            // stockPlusButton
            // 
            stockPlusButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stockPlusButton.Image = Properties.Resources.Add;
            stockPlusButton.ImageTransparentColor = Color.Magenta;
            stockPlusButton.Name = "stockPlusButton";
            stockPlusButton.Size = new Size(23, 22);
            stockPlusButton.Text = "Добавить запись";
            stockPlusButton.Click += stockPlusButton_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveButton.Image = Properties.Resources.Save;
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(23, 22);
            saveButton.Text = "Сохранить";
            saveButton.Click += saveButton_Click;
            // 
            // stockDataGridView
            // 
            stockDataGridView.AllowUserToAddRows = false;
            stockDataGridView.AllowUserToResizeColumns = false;
            stockDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            stockDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            stockDataGridView.BackgroundColor = SystemColors.Control;
            stockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockDataGridView.Location = new Point(21, 56);
            stockDataGridView.Name = "stockDataGridView";
            stockDataGridView.Size = new Size(616, 292);
            stockDataGridView.TabIndex = 5;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.BackColor = Color.Transparent;
            formLabel.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            formLabel.ForeColor = SystemColors.ControlLightLight;
            formLabel.Location = new Point(21, 21);
            formLabel.Margin = new Padding(0);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(118, 29);
            formLabel.TabIndex = 3;
            formLabel.Text = "📦 Склад";
            // 
            // shipmentTab
            // 
            shipmentTab.BackColor = Color.FromArgb(192, 192, 255);
            shipmentTab.Controls.Add(toolStrip2);
            shipmentTab.Controls.Add(button3);
            shipmentTab.Controls.Add(shipmentDataGridView);
            shipmentTab.Controls.Add(label1);
            shipmentTab.Location = new Point(26, 4);
            shipmentTab.Name = "shipmentTab";
            shipmentTab.Padding = new Padding(3);
            shipmentTab.Size = new Size(657, 405);
            shipmentTab.TabIndex = 1;
            shipmentTab.Text = "Поставки";
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { shipmentPlusButton, saveShipmentButton });
            toolStrip2.Location = new Point(21, 349);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(58, 25);
            toolStrip2.TabIndex = 10;
            // 
            // shipmentPlusButton
            // 
            shipmentPlusButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            shipmentPlusButton.Image = Properties.Resources.Add;
            shipmentPlusButton.ImageTransparentColor = Color.Magenta;
            shipmentPlusButton.Name = "shipmentPlusButton";
            shipmentPlusButton.Size = new Size(23, 22);
            shipmentPlusButton.Text = "Добавить запись";
            // 
            // saveShipmentButton
            // 
            saveShipmentButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveShipmentButton.Image = Properties.Resources.Save;
            saveShipmentButton.ImageTransparentColor = Color.Magenta;
            saveShipmentButton.Name = "saveShipmentButton";
            saveShipmentButton.Size = new Size(23, 22);
            saveShipmentButton.Text = "toolStripButton3";
            saveShipmentButton.Click += saveButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(714, 21);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(32, 32);
            button3.TabIndex = 9;
            button3.Text = "✏️";
            button3.UseVisualStyleBackColor = false;
            // 
            // shipmentDataGridView
            // 
            shipmentDataGridView.AllowUserToAddRows = false;
            shipmentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shipmentDataGridView.BackgroundColor = SystemColors.Control;
            shipmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shipmentDataGridView.Location = new Point(21, 56);
            shipmentDataGridView.Name = "shipmentDataGridView";
            shipmentDataGridView.Size = new Size(617, 290);
            shipmentDataGridView.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 21);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 6;
            label1.Text = "🚚 Поставки";
            // 
            // cartTab
            // 
            cartTab.BackColor = Color.FromArgb(128, 255, 255);
            cartTab.Controls.Add(toolStrip3);
            cartTab.Controls.Add(checkoutButton);
            cartTab.Controls.Add(cartDataGridView);
            cartTab.Controls.Add(label2);
            cartTab.Location = new Point(26, 4);
            cartTab.Name = "cartTab";
            cartTab.Padding = new Padding(3);
            cartTab.Size = new Size(657, 405);
            cartTab.TabIndex = 2;
            cartTab.Text = "Корзина";
            // 
            // toolStrip3
            // 
            toolStrip3.Dock = DockStyle.None;
            toolStrip3.Items.AddRange(new ToolStripItem[] { cartPlusButton });
            toolStrip3.Location = new Point(21, 351);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(35, 25);
            toolStrip3.TabIndex = 11;
            // 
            // cartPlusButton
            // 
            cartPlusButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cartPlusButton.Image = Properties.Resources.Add;
            cartPlusButton.ImageTransparentColor = Color.Magenta;
            cartPlusButton.Name = "cartPlusButton";
            cartPlusButton.Size = new Size(23, 22);
            cartPlusButton.Text = "Добавить запись";
            cartPlusButton.Click += cartPlusButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkoutButton.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkoutButton.Location = new Point(548, 351);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(101, 25);
            checkoutButton.TabIndex = 10;
            checkoutButton.Text = "Оформить";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // cartDataGridView
            // 
            cartDataGridView.AllowUserToAddRows = false;
            cartDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            cartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartDataGridView.Location = new Point(21, 56);
            cartDataGridView.Name = "cartDataGridView";
            cartDataGridView.Size = new Size(628, 289);
            cartDataGridView.TabIndex = 9;
            cartDataGridView.CellValueChanged += cartDataGridView_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 21);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(143, 29);
            label2.TabIndex = 7;
            label2.Text = "\U0001f6d2 Корзина";
            // 
            // shipmentGoodListBindingSource
            // 
            shipmentGoodListBindingSource.DataSource = typeof(Models.ShipmentGoodList);
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Stock);
            // 
            // goodBindingSource
            // 
            goodBindingSource.DataSource = typeof(Models.Good);
            // 
            // stockLocationBindingSource
            // 
            stockLocationBindingSource.DataSource = typeof(Models.StockLocation);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(687, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(54, 20);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(687, 437);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "АИС Зоомагазин";
            tabControl1.ResumeLayout(false);
            stockTab.ResumeLayout(false);
            stockTab.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockDataGridView).EndInit();
            shipmentTab.ResumeLayout(false);
            shipmentTab.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shipmentDataGridView).EndInit();
            cartTab.ResumeLayout(false);
            cartTab.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipmentGoodListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage stockTab;
        private DataGridView stockDataGridView;
        private Label formLabel;
        private TabPage shipmentTab;
        private DataGridView shipmentDataGridView;
        private ToolStripButton shipmentPlusButton;
        private Label label1;
        private TabPage cartTab;
        private Button checkoutButton;
        private DataGridView cartDataGridView;
        private Label label2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton stockPlusButton;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip3;
        private ToolStripButton cartPlusButton;
        private BindingSource goodBindingSource;
        private BindingSource stockLocationBindingSource;
        private BindingSource bindingSource1;
        private BindingSource shipmentGoodListBindingSource;
        private ToolStripButton saveButton;
        private ToolStripButton saveShipmentButton;
    }
}