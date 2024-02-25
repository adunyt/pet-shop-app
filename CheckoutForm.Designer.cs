namespace PetShop
{
    partial class CheckoutForm
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
            label1 = new Label();
            moneyLabel = new Label();
            cancelButton = new Button();
            payButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 16F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(174, 27);
            label1.TabIndex = 0;
            label1.Text = "Сумма платежа";
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Font = new Font("Roboto", 16F);
            moneyLabel.Location = new Point(187, 25);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(24, 27);
            moneyLabel.TabIndex = 1;
            moneyLabel.Text = "0";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(248, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // payButton
            // 
            payButton.Location = new Point(329, 80);
            payButton.Name = "payButton";
            payButton.Size = new Size(84, 23);
            payButton.TabIndex = 3;
            payButton.Text = "Оплачено";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // CheckoutForm
            // 
            AcceptButton = payButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(425, 115);
            Controls.Add(payButton);
            Controls.Add(cancelButton);
            Controls.Add(moneyLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформление заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label moneyLabel;
        private Button cancelButton;
        private Button payButton;
    }
}