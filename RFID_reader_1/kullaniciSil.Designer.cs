
namespace RFID_reader_1
{
    partial class kullaniciSil
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
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_del = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_back.Location = new System.Drawing.Point(148, 208);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 36);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "GERİ";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 34);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_del
            // 
            this.lbl_del.AutoSize = true;
            this.lbl_del.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_del.Location = new System.Drawing.Point(217, 86);
            this.lbl_del.Name = "lbl_del";
            this.lbl_del.Size = new System.Drawing.Size(134, 33);
            this.lbl_del.TabIndex = 2;
            this.lbl_del.Text = "ÜYE ID ";
            this.lbl_del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_delete.Location = new System.Drawing.Point(282, 208);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // kullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(580, 368);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_del);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "kullaniciSil";
            this.Text = "kullaniciSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_del;
        private System.Windows.Forms.Button btn_delete;
    }
}