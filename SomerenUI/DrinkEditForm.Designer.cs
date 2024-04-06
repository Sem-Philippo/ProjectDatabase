namespace SomerenUI
{
    partial class DrinkEditForm
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
            DrinkSelectBox = new System.Windows.Forms.ComboBox();
            pnlEditDrink = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            txtDrinkPrice = new System.Windows.Forms.TextBox();
            lblPrice = new System.Windows.Forms.Label();
            lblAlcoholic = new System.Windows.Forms.Label();
            ComboBoxAlcoholic = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            numStock = new System.Windows.Forms.NumericUpDown();
            lblAmount = new System.Windows.Forms.Label();
            lblDrinkName = new System.Windows.Forms.Label();
            txtDrinkName = new System.Windows.Forms.TextBox();
            pnlNewDrink = new System.Windows.Forms.Panel();
            btnSaveNewDrink = new System.Windows.Forms.Button();
            txtNewPrice = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ComboBoxNewAlcoholic = new System.Windows.Forms.ComboBox();
            numNewStock = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNewName = new System.Windows.Forms.TextBox();
            pnlEditDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            pnlNewDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewStock).BeginInit();
            SuspendLayout();
            // 
            // DrinkSelectBox
            // 
            DrinkSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DrinkSelectBox.FormattingEnabled = true;
            DrinkSelectBox.Items.AddRange(new object[] { "Add new drink" });
            DrinkSelectBox.Location = new System.Drawing.Point(197, 30);
            DrinkSelectBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DrinkSelectBox.Name = "DrinkSelectBox";
            DrinkSelectBox.Size = new System.Drawing.Size(132, 23);
            DrinkSelectBox.TabIndex = 0;
            DrinkSelectBox.SelectedIndexChanged += DrinkSelectBox_SelectedIndexChanged;
            // 
            // pnlEditDrink
            // 
            pnlEditDrink.Controls.Add(btnDelete);
            pnlEditDrink.Controls.Add(txtDrinkPrice);
            pnlEditDrink.Controls.Add(lblPrice);
            pnlEditDrink.Controls.Add(lblAlcoholic);
            pnlEditDrink.Controls.Add(ComboBoxAlcoholic);
            pnlEditDrink.Controls.Add(btnSave);
            pnlEditDrink.Controls.Add(numStock);
            pnlEditDrink.Controls.Add(lblAmount);
            pnlEditDrink.Controls.Add(lblDrinkName);
            pnlEditDrink.Controls.Add(txtDrinkName);
            pnlEditDrink.Location = new System.Drawing.Point(0, 56);
            pnlEditDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlEditDrink.Name = "pnlEditDrink";
            pnlEditDrink.Size = new System.Drawing.Size(509, 207);
            pnlEditDrink.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnDelete.Location = new System.Drawing.Point(300, 155);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(170, 44);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Drink";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDrinkPrice
            // 
            txtDrinkPrice.Location = new System.Drawing.Point(306, 35);
            txtDrinkPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDrinkPrice.Name = "txtDrinkPrice";
            txtDrinkPrice.Size = new System.Drawing.Size(122, 23);
            txtDrinkPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(241, 38);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(36, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price:";
            // 
            // lblAlcoholic
            // 
            lblAlcoholic.AutoSize = true;
            lblAlcoholic.Location = new System.Drawing.Point(236, 88);
            lblAlcoholic.Name = "lblAlcoholic";
            lblAlcoholic.Size = new System.Drawing.Size(60, 15);
            lblAlcoholic.TabIndex = 6;
            lblAlcoholic.Text = "Alcoholic:";
            // 
            // ComboBoxAlcoholic
            // 
            ComboBoxAlcoholic.FormattingEnabled = true;
            ComboBoxAlcoholic.Items.AddRange(new object[] { "Alcoholic", "Not Alcoholic" });
            ComboBoxAlcoholic.Location = new System.Drawing.Point(306, 86);
            ComboBoxAlcoholic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ComboBoxAlcoholic.Name = "ComboBoxAlcoholic";
            ComboBoxAlcoholic.Size = new System.Drawing.Size(122, 23);
            ComboBoxAlcoholic.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(39, 155);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(170, 44);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numStock
            // 
            numStock.Location = new System.Drawing.Point(108, 87);
            numStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numStock.Name = "numStock";
            numStock.Size = new System.Drawing.Size(109, 23);
            numStock.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(53, 88);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(39, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Stock:";
            // 
            // lblDrinkName
            // 
            lblDrinkName.AutoSize = true;
            lblDrinkName.Location = new System.Drawing.Point(53, 38);
            lblDrinkName.Name = "lblDrinkName";
            lblDrinkName.Size = new System.Drawing.Size(45, 15);
            lblDrinkName.TabIndex = 1;
            lblDrinkName.Text = "Name: ";
            // 
            // txtDrinkName
            // 
            txtDrinkName.Location = new System.Drawing.Point(108, 36);
            txtDrinkName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDrinkName.Name = "txtDrinkName";
            txtDrinkName.Size = new System.Drawing.Size(110, 23);
            txtDrinkName.TabIndex = 0;
            // 
            // pnlNewDrink
            // 
            pnlNewDrink.Controls.Add(btnSaveNewDrink);
            pnlNewDrink.Controls.Add(txtNewPrice);
            pnlNewDrink.Controls.Add(label1);
            pnlNewDrink.Controls.Add(label2);
            pnlNewDrink.Controls.Add(ComboBoxNewAlcoholic);
            pnlNewDrink.Controls.Add(numNewStock);
            pnlNewDrink.Controls.Add(label3);
            pnlNewDrink.Controls.Add(label4);
            pnlNewDrink.Controls.Add(txtNewName);
            pnlNewDrink.Location = new System.Drawing.Point(0, 57);
            pnlNewDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlNewDrink.Name = "pnlNewDrink";
            pnlNewDrink.Size = new System.Drawing.Size(509, 207);
            pnlNewDrink.TabIndex = 3;
            // 
            // btnSaveNewDrink
            // 
            btnSaveNewDrink.Location = new System.Drawing.Point(170, 150);
            btnSaveNewDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSaveNewDrink.Name = "btnSaveNewDrink";
            btnSaveNewDrink.Size = new System.Drawing.Size(170, 44);
            btnSaveNewDrink.TabIndex = 9;
            btnSaveNewDrink.Text = "Save Drink";
            btnSaveNewDrink.UseVisualStyleBackColor = true;
            btnSaveNewDrink.Click += btnSaveNewDrink_Click;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new System.Drawing.Point(306, 35);
            txtNewPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new System.Drawing.Size(122, 23);
            txtNewPrice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(241, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(236, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Alcoholic:";
            // 
            // ComboBoxNewAlcoholic
            // 
            ComboBoxNewAlcoholic.FormattingEnabled = true;
            ComboBoxNewAlcoholic.Items.AddRange(new object[] { "Alcoholic", "Not Alcoholic" });
            ComboBoxNewAlcoholic.Location = new System.Drawing.Point(306, 86);
            ComboBoxNewAlcoholic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ComboBoxNewAlcoholic.Name = "ComboBoxNewAlcoholic";
            ComboBoxNewAlcoholic.Size = new System.Drawing.Size(122, 23);
            ComboBoxNewAlcoholic.TabIndex = 5;
            // 
            // numNewStock
            // 
            numNewStock.Location = new System.Drawing.Point(108, 87);
            numNewStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numNewStock.Name = "numNewStock";
            numNewStock.Size = new System.Drawing.Size(109, 23);
            numNewStock.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 38);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 1;
            label4.Text = "Name: ";
            // 
            // txtNewName
            // 
            txtNewName.Location = new System.Drawing.Point(108, 36);
            txtNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new System.Drawing.Size(110, 23);
            txtNewName.TabIndex = 0;
            // 
            // DrinkEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(511, 271);
            Controls.Add(pnlNewDrink);
            Controls.Add(DrinkSelectBox);
            Controls.Add(pnlEditDrink);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximumSize = new System.Drawing.Size(527, 310);
            MinimumSize = new System.Drawing.Size(527, 310);
            Name = "DrinkEditForm";
            ShowIcon = false;
            Text = "Edit Drinks";
            pnlEditDrink.ResumeLayout(false);
            pnlEditDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            pnlNewDrink.ResumeLayout(false);
            pnlNewDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox DrinkSelectBox;
        private System.Windows.Forms.Panel pnlEditDrink;
        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAlcoholic;
        private System.Windows.Forms.ComboBox ComboBoxAlcoholic;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlNewDrink;
        private System.Windows.Forms.Button btnSaveNewDrink;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxNewAlcoholic;
        private System.Windows.Forms.NumericUpDown numNewStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewName;
    }
}