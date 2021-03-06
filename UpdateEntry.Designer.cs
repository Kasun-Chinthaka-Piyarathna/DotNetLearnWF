namespace FinancialMgtTool
{
    partial class UpdateEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.UpdateTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(230, 55);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 20);
            this.textAmount.TabIndex = 2;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(230, 100);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 20);
            this.textDescription.TabIndex = 3;
            // 
            // UpdateTransaction
            // 
            this.UpdateTransaction.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateTransaction.Location = new System.Drawing.Point(41, 152);
            this.UpdateTransaction.Name = "UpdateTransaction";
            this.UpdateTransaction.Size = new System.Drawing.Size(97, 23);
            this.UpdateTransaction.TabIndex = 4;
            this.UpdateTransaction.Text = "Update Record";
            this.UpdateTransaction.UseVisualStyleBackColor = false;
            this.UpdateTransaction.Click += new System.EventHandler(this.UpdateTransactionNow);
            // 
            // UpdateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 319);
            this.Controls.Add(this.UpdateTransaction);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UpdateEntry";
            this.Text = "UpdateEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button UpdateTransaction;
    }
}