namespace GrocerySystem
{
    partial class Form1
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GroceryListBox = new System.Windows.Forms.ListBox();
            this.LoadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadGroceryButton = new System.Windows.Forms.Button();
            this.UpdateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SortItemButton = new System.Windows.Forms.Button();
            this.UpdateQtySoldButton = new System.Windows.Forms.Button();
            this.UpdateQtyRestockedButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.QtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.QtySoldTextBox = new System.Windows.Forms.TextBox();
            this.QtyRestockedLabel = new System.Windows.Forms.Label();
            this.QtySoldLabel = new System.Windows.Forms.Label();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveRestockReportButton = new System.Windows.Forms.Button();
            this.SaveSalesReportButton = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LoadDataGroupBox.SuspendLayout();
            this.UpdateDataGroupBox.SuspendLayout();
            this.SaveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaderLabel.Location = new System.Drawing.Point(1, 3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Padding = new System.Windows.Forms.Padding(10);
            this.HeaderLabel.Size = new System.Drawing.Size(1477, 89);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Super Store Grocery Management System";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroceryListBox
            // 
            this.GroceryListBox.BackColor = System.Drawing.Color.White;
            this.GroceryListBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroceryListBox.ForeColor = System.Drawing.Color.Black;
            this.GroceryListBox.FormattingEnabled = true;
            this.GroceryListBox.ItemHeight = 23;
            this.GroceryListBox.Location = new System.Drawing.Point(39, 86);
            this.GroceryListBox.Name = "GroceryListBox";
            this.GroceryListBox.Size = new System.Drawing.Size(1390, 280);
            this.GroceryListBox.TabIndex = 1;
            // 
            // LoadDataGroupBox
            // 
            this.LoadDataGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoadDataGroupBox.Controls.Add(this.LoadGroceryButton);
            this.LoadDataGroupBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataGroupBox.Location = new System.Drawing.Point(39, 387);
            this.LoadDataGroupBox.Name = "LoadDataGroupBox";
            this.LoadDataGroupBox.Size = new System.Drawing.Size(404, 115);
            this.LoadDataGroupBox.TabIndex = 2;
            this.LoadDataGroupBox.TabStop = false;
            this.LoadDataGroupBox.Text = "Load Data";
            // 
            // LoadGroceryButton
            // 
            this.LoadGroceryButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LoadGroceryButton.Location = new System.Drawing.Point(43, 41);
            this.LoadGroceryButton.Name = "LoadGroceryButton";
            this.LoadGroceryButton.Size = new System.Drawing.Size(320, 50);
            this.LoadGroceryButton.TabIndex = 0;
            this.LoadGroceryButton.Text = "Load Grocery Data";
            this.LoadGroceryButton.UseVisualStyleBackColor = false;
            this.LoadGroceryButton.Click += new System.EventHandler(this.LoadGroceryButton_Click);
            // 
            // UpdateDataGroupBox
            // 
            this.UpdateDataGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UpdateDataGroupBox.Controls.Add(this.SortItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateQtySoldButton);
            this.UpdateDataGroupBox.Controls.Add(this.UpdateQtyRestockedButton);
            this.UpdateDataGroupBox.Controls.Add(this.DeleteItemButton);
            this.UpdateDataGroupBox.Controls.Add(this.QtyRestockedTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.QtySoldTextBox);
            this.UpdateDataGroupBox.Controls.Add(this.QtyRestockedLabel);
            this.UpdateDataGroupBox.Controls.Add(this.QtySoldLabel);
            this.UpdateDataGroupBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataGroupBox.Location = new System.Drawing.Point(476, 387);
            this.UpdateDataGroupBox.Name = "UpdateDataGroupBox";
            this.UpdateDataGroupBox.Size = new System.Drawing.Size(953, 262);
            this.UpdateDataGroupBox.TabIndex = 3;
            this.UpdateDataGroupBox.TabStop = false;
            this.UpdateDataGroupBox.Text = "Update Data";
            // 
            // SortItemButton
            // 
            this.SortItemButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SortItemButton.Location = new System.Drawing.Point(449, 167);
            this.SortItemButton.Name = "SortItemButton";
            this.SortItemButton.Size = new System.Drawing.Size(470, 50);
            this.SortItemButton.TabIndex = 7;
            this.SortItemButton.TabStop = false;
            this.SortItemButton.Text = "Sort Item Based on Sales";
            this.SortItemButton.UseVisualStyleBackColor = false;
            this.SortItemButton.Click += new System.EventHandler(this.SortItemButton_Click);
            // 
            // UpdateQtySoldButton
            // 
            this.UpdateQtySoldButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateQtySoldButton.Location = new System.Drawing.Point(449, 41);
            this.UpdateQtySoldButton.Name = "UpdateQtySoldButton";
            this.UpdateQtySoldButton.Size = new System.Drawing.Size(470, 50);
            this.UpdateQtySoldButton.TabIndex = 4;
            this.UpdateQtySoldButton.Text = "Update Sold Qty For Selected Item";
            this.UpdateQtySoldButton.UseVisualStyleBackColor = false;
            this.UpdateQtySoldButton.Click += new System.EventHandler(this.UpdateQtySoldButton_Click);
            // 
            // UpdateQtyRestockedButton
            // 
            this.UpdateQtyRestockedButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateQtyRestockedButton.Location = new System.Drawing.Point(449, 104);
            this.UpdateQtyRestockedButton.Name = "UpdateQtyRestockedButton";
            this.UpdateQtyRestockedButton.Size = new System.Drawing.Size(470, 50);
            this.UpdateQtyRestockedButton.TabIndex = 6;
            this.UpdateQtyRestockedButton.Text = "Update Restocked Qty For Selected Item";
            this.UpdateQtyRestockedButton.UseVisualStyleBackColor = false;
            this.UpdateQtyRestockedButton.Click += new System.EventHandler(this.UpdateQtyRestockedButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteItemButton.Location = new System.Drawing.Point(37, 167);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(380, 50);
            this.DeleteItemButton.TabIndex = 5;
            this.DeleteItemButton.Text = "Delete Selected Grocery Item";
            this.DeleteItemButton.UseVisualStyleBackColor = false;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // QtyRestockedTextBox
            // 
            this.QtyRestockedTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.QtyRestockedTextBox.Location = new System.Drawing.Point(258, 113);
            this.QtyRestockedTextBox.Name = "QtyRestockedTextBox";
            this.QtyRestockedTextBox.Size = new System.Drawing.Size(159, 31);
            this.QtyRestockedTextBox.TabIndex = 3;
            // 
            // QtySoldTextBox
            // 
            this.QtySoldTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.QtySoldTextBox.Location = new System.Drawing.Point(203, 52);
            this.QtySoldTextBox.Name = "QtySoldTextBox";
            this.QtySoldTextBox.Size = new System.Drawing.Size(214, 31);
            this.QtySoldTextBox.TabIndex = 2;
            // 
            // QtyRestockedLabel
            // 
            this.QtyRestockedLabel.AutoSize = true;
            this.QtyRestockedLabel.Location = new System.Drawing.Point(33, 116);
            this.QtyRestockedLabel.Name = "QtyRestockedLabel";
            this.QtyRestockedLabel.Size = new System.Drawing.Size(219, 23);
            this.QtyRestockedLabel.TabIndex = 1;
            this.QtyRestockedLabel.Text = "Quantity Restocked:";
            // 
            // QtySoldLabel
            // 
            this.QtySoldLabel.AutoSize = true;
            this.QtySoldLabel.Location = new System.Drawing.Point(33, 55);
            this.QtySoldLabel.Name = "QtySoldLabel";
            this.QtySoldLabel.Size = new System.Drawing.Size(164, 23);
            this.QtySoldLabel.TabIndex = 0;
            this.QtySoldLabel.Text = "Quantity Sold:";
            // 
            // SaveDataGroupBox
            // 
            this.SaveDataGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SaveDataGroupBox.Controls.Add(this.SaveRestockReportButton);
            this.SaveDataGroupBox.Controls.Add(this.SaveSalesReportButton);
            this.SaveDataGroupBox.Controls.Add(this.SaveDataButton);
            this.SaveDataGroupBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDataGroupBox.Location = new System.Drawing.Point(39, 524);
            this.SaveDataGroupBox.Name = "SaveDataGroupBox";
            this.SaveDataGroupBox.Size = new System.Drawing.Size(404, 233);
            this.SaveDataGroupBox.TabIndex = 4;
            this.SaveDataGroupBox.TabStop = false;
            this.SaveDataGroupBox.Text = "Save Data";
            // 
            // SaveRestockReportButton
            // 
            this.SaveRestockReportButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SaveRestockReportButton.Location = new System.Drawing.Point(43, 157);
            this.SaveRestockReportButton.Name = "SaveRestockReportButton";
            this.SaveRestockReportButton.Size = new System.Drawing.Size(320, 50);
            this.SaveRestockReportButton.TabIndex = 2;
            this.SaveRestockReportButton.Text = "Save Restock Needs Report";
            this.SaveRestockReportButton.UseVisualStyleBackColor = false;
            this.SaveRestockReportButton.Click += new System.EventHandler(this.SaveRestockReportButton_Click);
            // 
            // SaveSalesReportButton
            // 
            this.SaveSalesReportButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SaveSalesReportButton.Location = new System.Drawing.Point(43, 99);
            this.SaveSalesReportButton.Name = "SaveSalesReportButton";
            this.SaveSalesReportButton.Size = new System.Drawing.Size(320, 50);
            this.SaveSalesReportButton.TabIndex = 1;
            this.SaveSalesReportButton.Text = "Save Sales Report";
            this.SaveSalesReportButton.UseVisualStyleBackColor = false;
            this.SaveSalesReportButton.Click += new System.EventHandler(this.SaveSalesReportButton_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SaveDataButton.Location = new System.Drawing.Point(43, 41);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(320, 50);
            this.SaveDataButton.TabIndex = 0;
            this.SaveDataButton.Text = "Save Grocery Data";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(476, 681);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(10);
            this.StatusLabel.Size = new System.Drawing.Size(953, 76);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Operation Status Update Displayed Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 793);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveDataGroupBox);
            this.Controls.Add(this.UpdateDataGroupBox);
            this.Controls.Add(this.LoadDataGroupBox);
            this.Controls.Add(this.GroceryListBox);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoadDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.ResumeLayout(false);
            this.UpdateDataGroupBox.PerformLayout();
            this.SaveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox GroceryListBox;
        private System.Windows.Forms.GroupBox LoadDataGroupBox;
        private System.Windows.Forms.Button LoadGroceryButton;
        private System.Windows.Forms.GroupBox UpdateDataGroupBox;
        private System.Windows.Forms.TextBox QtyRestockedTextBox;
        private System.Windows.Forms.TextBox QtySoldTextBox;
        private System.Windows.Forms.Label QtyRestockedLabel;
        private System.Windows.Forms.Label QtySoldLabel;
        private System.Windows.Forms.Button SortItemButton;
        private System.Windows.Forms.Button UpdateQtyRestockedButton;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button UpdateQtySoldButton;
        private System.Windows.Forms.GroupBox SaveDataGroupBox;
        private System.Windows.Forms.Button SaveRestockReportButton;
        private System.Windows.Forms.Button SaveSalesReportButton;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

