namespace SomerenUI
{
    partial class Deletion_Confirmation
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
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblDeletion = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new System.Drawing.Point(56, 158);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(94, 29);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(258, 159);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDeletion
            // 
            lblDeletion.Location = new System.Drawing.Point(12, 52);
            lblDeletion.Name = "lblDeletion";
            lblDeletion.Size = new System.Drawing.Size(405, 57);
            lblDeletion.TabIndex = 2;
            lblDeletion.Text = "Are you sure you want to delete ...";
            lblDeletion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deletion_Confirmation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(429, 218);
            Controls.Add(lblDeletion);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Name = "Deletion_Confirmation";
            Text = "Deletion_Confirmation";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeletion;
    }
}