﻿namespace PublisherAppInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddAuthorButton = new Button();
            FirstName = new TextBox();
            LastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AuthorGridView = new DataGridView();
            SetUPDataBaseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AuthorGridView).BeginInit();
            SuspendLayout();
            // 
            // AddAuthorButton
            // 
            AddAuthorButton.Font = new Font("Segoe UI", 30F);
            AddAuthorButton.Location = new Point(41, 162);
            AddAuthorButton.Name = "AddAuthorButton";
            AddAuthorButton.Size = new Size(310, 415);
            AddAuthorButton.TabIndex = 0;
            AddAuthorButton.Text = "Add Author";
            AddAuthorButton.UseVisualStyleBackColor = true;
            AddAuthorButton.Click += button1_Click;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(167, 85);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(184, 27);
            FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.Location = new Point(167, 118);
            LastName.Name = "LastName";
            LastName.Size = new Size(184, 27);
            LastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 121);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // AuthorGridView
            // 
            AuthorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AuthorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AuthorGridView.Location = new Point(375, 12);
            AuthorGridView.Name = "AuthorGridView";
            AuthorGridView.RowHeadersWidth = 51;
            AuthorGridView.Size = new Size(611, 590);
            AuthorGridView.TabIndex = 5;
            // 
            // SetUPDataBaseButton
            // 
            SetUPDataBaseButton.Font = new Font("Segoe UI", 16F);
            SetUPDataBaseButton.Location = new Point(41, 12);
            SetUPDataBaseButton.Name = "SetUPDataBaseButton";
            SetUPDataBaseButton.Size = new Size(310, 55);
            SetUPDataBaseButton.TabIndex = 6;
            SetUPDataBaseButton.Text = "Setup DataBase";
            SetUPDataBaseButton.UseVisualStyleBackColor = true;
            SetUPDataBaseButton.Click += SetUPDataBaseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 614);
            Controls.Add(SetUPDataBaseButton);
            Controls.Add(AuthorGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Controls.Add(AddAuthorButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AuthorGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddAuthorButton;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label1;
        private Label label2;
        private DataGridView AuthorGridView;
        private Button SetUPDataBaseButton;
    }
}
