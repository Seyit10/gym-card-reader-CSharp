using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_reader_1
{
    public partial class kullaniciKayit : Form
    {

        string connstring = "Data Source=LAPTOP-OJP39STO\\SQLEXPRESS;Initial Catalog=SPORUYE;Integrated Security=True";

        public kullaniciKayit()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.ActiveControl = textBox6;
        }

        private void btn_kaydet(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(textBox6.Text);
                string ad = textBox1.Text;
                string soyad = textBox2.Text;
                int yas = int.Parse(textBox3.Text);

                DateTime baslangicTarihi = edBaslangic.Value;
                DateTime bitisTarihi = edBitis.Value;

                using (SqlConnection con = new SqlConnection(connstring))
                {
                    con.Open();
                    string query = "INSERT INTO UYELER (k_id, k_adi, k_sadi, k_yas, baslangic_t, bitis_t) VALUES (@k_id, @k_adi, @k_sadi, @k_yas, @baslangic_t, @bitis_t)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@k_id", id);
                        command.Parameters.AddWithValue("@k_adi", ad);
                        command.Parameters.AddWithValue("@k_sadi", soyad);
                        command.Parameters.AddWithValue("@k_yas", yas);
                        command.Parameters.AddWithValue("@baslangic_t", baslangicTarihi);
                        command.Parameters.AddWithValue("@bitis_t", bitisTarihi);

                        command.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Kullanıcı başarıyla kaydedildi.");


            }catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            

        }

        private void btn_back(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void kullaniciKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
