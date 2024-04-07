namespace SomerenUI
{
    partial class ManagingStudent
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
            AddStudentButton = new System.Windows.Forms.Button();
            StudentNameBox = new System.Windows.Forms.TextBox();
            PhoneNumberBox = new System.Windows.Forms.TextBox();
            ClassNameBox = new System.Windows.Forms.ComboBox();
            RoomNrBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            DeleteStudentButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new System.Drawing.Point(132, 206);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new System.Drawing.Size(91, 45);
            AddStudentButton.TabIndex = 0;
            AddStudentButton.Text = "Add this student!";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new System.Drawing.Point(36, 101);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new System.Drawing.Size(187, 23);
            StudentNameBox.TabIndex = 1;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new System.Drawing.Point(229, 101);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new System.Drawing.Size(142, 23);
            PhoneNumberBox.TabIndex = 2;
            // 
            // ClassNameBox
            // 
            ClassNameBox.FormattingEnabled = true;
            ClassNameBox.Location = new System.Drawing.Point(378, 67);
            ClassNameBox.Name = "ClassNameBox";
            ClassNameBox.Size = new System.Drawing.Size(121, 23);
            ClassNameBox.TabIndex = 3;
            // 
            // RoomNrBox
            // 
            RoomNrBox.FormattingEnabled = true;
            RoomNrBox.Location = new System.Drawing.Point(378, 133);
            RoomNrBox.Name = "RoomNrBox";
            RoomNrBox.Size = new System.Drawing.Size(121, 23);
            RoomNrBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "Student's name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(229, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Phone number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(378, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Class:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(377, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Room:";
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new System.Drawing.Point(324, 206);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new System.Drawing.Size(91, 45);
            DeleteStudentButton.TabIndex = 9;
            DeleteStudentButton.Text = "Delete this student!";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // ManagingStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 298);
            Controls.Add(DeleteStudentButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RoomNrBox);
            Controls.Add(ClassNameBox);
            Controls.Add(PhoneNumberBox);
            Controls.Add(StudentNameBox);
            Controls.Add(AddStudentButton);
            Name = "ManagingStudent";
            Text = "ManagingStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.ComboBox ClassNameBox;
        private System.Windows.Forms.ComboBox RoomNrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteStudentButton;
    }
}