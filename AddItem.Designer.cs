namespace WinFormsApp1
{
    partial class AddItem
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
            stockLocationBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            shipmentGoodListBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            goodBindingSource = new BindingSource(components);
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipmentGoodListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // stockLocationBindingSource
            // 
            stockLocationBindingSource.AllowNew = false;
            stockLocationBindingSource.DataSource = typeof(Models.StockLocation);
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 277);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 20F);
            label5.Location = new Point(43, 15);
            label5.Name = "label5";
            label5.Size = new Size(339, 33);
            label5.TabIndex = 8;
            label5.Text = "Добавить товар на склад";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(207, 143);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 24);
            numericUpDown1.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.DataSource = stockLocationBindingSource;
            comboBox3.DisplayMember = "PalleteNumber";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(206, 180);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            comboBox3.ValueMember = "StockLocationId";
            // 
            // comboBox2
            // 
            comboBox2.DataSource = shipmentGoodListBindingSource;
            comboBox2.DisplayMember = "Time";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(206, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.ValueMember = "ShipmentGoodsId";
            // 
            // shipmentGoodListBindingSource
            // 
            shipmentGoodListBindingSource.DataSource = typeof(Models.ShipmentGoodList);
            // 
            // comboBox1
            // 
            comboBox1.DataSource = goodBindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "GoodId";
            // 
            // goodBindingSource
            // 
            goodBindingSource.DataSource = typeof(Models.Good);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14F);
            label4.Location = new Point(32, 180);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 3;
            label4.Text = "Местоположение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 14F);
            label3.Location = new Point(129, 143);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 2;
            label3.Text = "Кол-во";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 14F);
            label2.Location = new Point(105, 104);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 1;
            label2.Text = "Поставка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 14F);
            label1.Location = new Point(137, 68);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "Товар";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 301);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить";
            Load += AddItem_Load;
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipmentGoodListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource stockLocationBindingSource;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource shipmentGoodListBindingSource;
        private BindingSource goodBindingSource;
    }
}