namespace Assignment06
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
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnAddMaj = new System.Windows.Forms.Button();
            this.btnViewStu = new System.Windows.Forms.Button();
            this.btnViewMaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(77, 34);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(176, 120);
            this.btnAddStu.TabIndex = 0;
            this.btnAddStu.Text = "Add Student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnAddMaj
            // 
            this.btnAddMaj.Location = new System.Drawing.Point(356, 34);
            this.btnAddMaj.Name = "btnAddMaj";
            this.btnAddMaj.Size = new System.Drawing.Size(171, 120);
            this.btnAddMaj.TabIndex = 1;
            this.btnAddMaj.Text = "Add Major";
            this.btnAddMaj.UseVisualStyleBackColor = true;
            this.btnAddMaj.Click += new System.EventHandler(this.btnAddMaj_Click);
            // 
            // btnViewStu
            // 
            this.btnViewStu.Location = new System.Drawing.Point(77, 224);
            this.btnViewStu.Name = "btnViewStu";
            this.btnViewStu.Size = new System.Drawing.Size(174, 116);
            this.btnViewStu.TabIndex = 2;
            this.btnViewStu.Text = "View Student";
            this.btnViewStu.UseVisualStyleBackColor = true;
            this.btnViewStu.Click += new System.EventHandler(this.btnViewStu_Click);
            // 
            // btnViewMaj
            // 
            this.btnViewMaj.Location = new System.Drawing.Point(356, 224);
            this.btnViewMaj.Name = "btnViewMaj";
            this.btnViewMaj.Size = new System.Drawing.Size(171, 116);
            this.btnViewMaj.TabIndex = 3;
            this.btnViewMaj.Text = "View Major";
            this.btnViewMaj.UseVisualStyleBackColor = true;
            this.btnViewMaj.Click += new System.EventHandler(this.btnViewMaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 417);
            this.Controls.Add(this.btnViewMaj);
            this.Controls.Add(this.btnViewStu);
            this.Controls.Add(this.btnAddMaj);
            this.Controls.Add(this.btnAddStu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnAddMaj;
        private System.Windows.Forms.Button btnViewStu;
        private System.Windows.Forms.Button btnViewMaj;
    }
}

