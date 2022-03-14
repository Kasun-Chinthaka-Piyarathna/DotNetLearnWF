namespace DVDStore
{
    partial class TransactionView
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
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTransactionViewTotalIncome = new System.Windows.Forms.Label();
            this.labelTransactionViewTotalExpenses = new System.Windows.Forms.Label();
            this.labelTransactionViewTotalBalance = new System.Windows.Forms.Label();
            this.labelTransactionViewFuturePrediction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Location = new System.Drawing.Point(69, 86);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.Size = new System.Drawing.Size(579, 150);
            this.transactionDataGridView.TabIndex = 0;
            this.transactionDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Location = new System.Drawing.Point(69, 57);
            this.buttonUpdateRecord.Name = "buttonUpdateRecord";
            this.buttonUpdateRecord.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdateRecord.TabIndex = 1;
            this.buttonUpdateRecord.Text = "Update Record";
            this.buttonUpdateRecord.UseVisualStyleBackColor = true;
            this.buttonUpdateRecord.Click += new System.EventHandler(this.UpdateRecord);
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(173, 57);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(99, 23);
            this.buttonDeleteRecord.TabIndex = 2;
            this.buttonDeleteRecord.Text = "Delete Record";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.DeleteRecord);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Weekly View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowWeeklyReport);
            // 
            // labelTransactionViewTotalIncome
            // 
            this.labelTransactionViewTotalIncome.AutoSize = true;
            this.labelTransactionViewTotalIncome.Location = new System.Drawing.Point(66, 281);
            this.labelTransactionViewTotalIncome.Name = "labelTransactionViewTotalIncome";
            this.labelTransactionViewTotalIncome.Size = new System.Drawing.Size(124, 13);
            this.labelTransactionViewTotalIncome.TabIndex = 4;
            this.labelTransactionViewTotalIncome.Text = "Your total income amout ";
            // 
            // labelTransactionViewTotalExpenses
            // 
            this.labelTransactionViewTotalExpenses.AutoSize = true;
            this.labelTransactionViewTotalExpenses.Location = new System.Drawing.Point(66, 308);
            this.labelTransactionViewTotalExpenses.Name = "labelTransactionViewTotalExpenses";
            this.labelTransactionViewTotalExpenses.Size = new System.Drawing.Size(103, 13);
            this.labelTransactionViewTotalExpenses.TabIndex = 5;
            this.labelTransactionViewTotalExpenses.Text = "Your total expenses ";
            // 
            // labelTransactionViewTotalBalance
            // 
            this.labelTransactionViewTotalBalance.AutoSize = true;
            this.labelTransactionViewTotalBalance.Location = new System.Drawing.Point(66, 336);
            this.labelTransactionViewTotalBalance.Name = "labelTransactionViewTotalBalance";
            this.labelTransactionViewTotalBalance.Size = new System.Drawing.Size(70, 13);
            this.labelTransactionViewTotalBalance.TabIndex = 6;
            this.labelTransactionViewTotalBalance.Text = "Your balance";
            // 
            // labelTransactionViewFuturePrediction
            // 
            this.labelTransactionViewFuturePrediction.AutoSize = true;
            this.labelTransactionViewFuturePrediction.Location = new System.Drawing.Point(66, 363);
            this.labelTransactionViewFuturePrediction.Name = "labelTransactionViewFuturePrediction";
            this.labelTransactionViewFuturePrediction.Size = new System.Drawing.Size(185, 13);
            this.labelTransactionViewFuturePrediction.TabIndex = 7;
            this.labelTransactionViewFuturePrediction.Text = "Financial predication per a future date";
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTransactionViewFuturePrediction);
            this.Controls.Add(this.labelTransactionViewTotalBalance);
            this.Controls.Add(this.labelTransactionViewTotalExpenses);
            this.Controls.Add(this.labelTransactionViewTotalIncome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonUpdateRecord);
            this.Controls.Add(this.transactionDataGridView);
            this.Name = "TransactionView";
            this.Text = "TransactionView";
            this.Load += new System.EventHandler(this.TransactionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.Button buttonUpdateRecord;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelTransactionViewTotalIncome;
        public System.Windows.Forms.Label labelTransactionViewTotalExpenses;
        public System.Windows.Forms.Label labelTransactionViewTotalBalance;
        public System.Windows.Forms.Label labelTransactionViewFuturePrediction;
    }
}