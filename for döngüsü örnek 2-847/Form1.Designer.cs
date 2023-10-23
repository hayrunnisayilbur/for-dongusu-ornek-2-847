namespace for_döngüsü_örnek_2_847
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(49, 81);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(145, 44);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(225, 81);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(142, 277);
            this.lbSayilar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

