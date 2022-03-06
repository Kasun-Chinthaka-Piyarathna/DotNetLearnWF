namespace DVDStore
{
    partial class RegisterView
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
            this.lblUserEnteredName = new System.Windows.Forms.Label();
            this.textRows = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserEnteredName
            // 
            this.lblUserEnteredName.AutoSize = true;
            this.lblUserEnteredName.Location = new System.Drawing.Point(49, 35);
            this.lblUserEnteredName.Name = "lblUserEnteredName";
            this.lblUserEnteredName.Size = new System.Drawing.Size(35, 13);
            this.lblUserEnteredName.TabIndex = 0;
            this.lblUserEnteredName.Text = "label1";
            // 
            // textRows
            // 
            this.textRows.Location = new System.Drawing.Point(193, 32);
            this.textRows.Name = "textRows";
            this.textRows.Size = new System.Drawing.Size(100, 20);
            this.textRows.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(305, 30);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.GenerateRows);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(53, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 3;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 241);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textRows);
            this.Controls.Add(this.lblUserEnteredName);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUserEnteredName;
        private System.Windows.Forms.TextBox textRows;
        private System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}