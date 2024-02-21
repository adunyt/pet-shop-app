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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            stockLocationBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(64, 42);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 24);
            numericUpDown1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = stockLocationBindingSource;
            comboBox1.DisplayMember = "ShelfNumber";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(64, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(43, 23);
            comboBox1.TabIndex = 7;
            // 
            // stockLocationBindingSource
            // 
            stockLocationBindingSource.AllowNew = false;
            stockLocationBindingSource.DataSource = typeof(Models.StockLocation);
            // 
            // comboBox2
            // 
            comboBox2.DataSource = stockLocationBindingSource;
            comboBox2.DisplayMember = "PalleteNumber";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(43, 23);
            comboBox2.TabIndex = 8;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 301);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockLocationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private BindingSource stockLocationBindingSource;
        private ComboBox comboBox2;
    }
}