
namespace RFID_reader_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_rfid = new System.Windows.Forms.TextBox();
            this.btn_kyt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.txt_rfid);
            this.panel1.Controls.Add(this.btn_kyt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 351);
            this.panel1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(466, 176);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(182, 39);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Üye Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sil.Location = new System.Drawing.Point(264, 176);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(196, 39);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Üye Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_rfid
            // 
            this.txt_rfid.Location = new System.Drawing.Point(65, 138);
            this.txt_rfid.Name = "txt_rfid";
            this.txt_rfid.Size = new System.Drawing.Size(265, 22);
            this.txt_rfid.TabIndex = 0;
            this.txt_rfid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keydown);
            // 
            // btn_kyt
            // 
            this.btn_kyt.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kyt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kyt.Location = new System.Drawing.Point(65, 176);
            this.btn_kyt.Name = "btn_kyt";
            this.btn_kyt.Size = new System.Drawing.Size(193, 39);
            this.btn_kyt.TabIndex = 4;
            this.btn_kyt.Text = "Üye Kayıt";
            this.btn_kyt.UseVisualStyleBackColor = true;
            this.btn_kyt.Click += new System.EventHandler(this.btn_kyt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giriş için Kartı Okutunuz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(702, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SporSalonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kyt;
        private System.Windows.Forms.TextBox txt_rfid;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_update;
    }
}

