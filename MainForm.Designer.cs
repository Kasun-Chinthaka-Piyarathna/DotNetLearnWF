﻿namespace FinancialManagementStore
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
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Location = new System.Drawing.Point(39, 64);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(100, 23);
            this.btnDataEntry.TabIndex = 5;
            this.btnDataEntry.Text = "Add Inome";
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.ShowAddIncomeForm);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(312, 92);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View Info";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.ShowTheData);
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Location = new System.Drawing.Point(39, 125);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(100, 23);
            this.buttonAddExpense.TabIndex = 7;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.ShowAddExpenseForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 273);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDataEntry);
            this.Name = "MainForm";
            this.Text = "Financial Management and Prediction";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button buttonAddExpense;
    }
}

