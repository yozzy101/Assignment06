namespace Assignment06
{
    partial class ViewMajor
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
            this.dgvMajor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMajor
            // 
            this.dgvMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMajor.Location = new System.Drawing.Point(78, 47);
            this.dgvMajor.Name = "dgvMajor";
            this.dgvMajor.RowHeadersWidth = 62;
            this.dgvMajor.RowTemplate.Height = 37;
            this.dgvMajor.Size = new System.Drawing.Size(630, 321);
            this.dgvMajor.TabIndex = 0;
            // 
            // ViewMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMajor);
            this.Name = "ViewMajor";
            this.Text = "ViewMajor";
            this.Load += new System.EventHandler(this.ViewMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMajor;
    }
}