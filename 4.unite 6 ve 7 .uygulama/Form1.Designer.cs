namespace _4.unite_6_ve_7.uygulama
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
            this.btnBagla = new System.Windows.Forms.Button();
            this.listeveri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBagla
            // 
            this.btnBagla.Location = new System.Drawing.Point(136, 59);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(75, 23);
            this.btnBagla.TabIndex = 0;
            this.btnBagla.Text = "veri Bagla";
            this.btnBagla.UseVisualStyleBackColor = true;
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // listeveri
            // 
            this.listeveri.FormattingEnabled = true;
            this.listeveri.Location = new System.Drawing.Point(290, 59);
            this.listeveri.Name = "listeveri";
            this.listeveri.Size = new System.Drawing.Size(120, 95);
            this.listeveri.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeveri);
            this.Controls.Add(this.btnBagla);
            this.Name = "Form1";
            this.Text = "VeriİBagla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBagla;
        private System.Windows.Forms.ListBox listeveri;
    }
}

