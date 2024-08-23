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
    public partial class uyeGuncelle : Form
    {

        string connstring = "Data Source=LAPTOP-OJP39STO\\SQLEXPRESS;Initial Catalog=SPORUYE;Integrated Security=True";
        private string kid;

        public uyeGuncelle(string id_)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.ActiveControl = textBox2;
            kid = id_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void uyeGuncelle_Load(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    
                    con.Open();
                    string query = "SELECT k_id, k_adi, k_sadi, k_yas, baslangic_t, bitis_t FROM UYELER WHERE k_id = @id";


                    using (SqlCommand command = new SqlCommand(query, con))
                    {

                        command.Parameters.AddWithValue("@id", kid);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.Read())
                            {

                                textBox1.Text = reader["k_id"].ToString();
                                textBox2.Text = reader["k_adi"].ToString();
                                textBox3.Text = reader["k_sadi"].ToString();
                                textBox4.Text = reader["k_yas"].ToString();

                                DateTime baslangicTarihi = Convert.ToDateTime(reader["baslangic_t"]);
                                DateTime bitisTarihi = Convert.ToDateTime(reader["bitis_t"]);

                                edBaslangic.Value = baslangicTarihi;
                                edBitis.Value = bitisTarihi;

                            }
                            else
                            {
                                MessageBox.Show("Kayıt bulunamadı.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = textBox2.Text;
                string soyad = textBox3.Text;
                string yas = textBox4.Text;
                string id = textBox1.Text;

                DateTime baslangicTarihi = edBaslangic.Value;
                DateTime bitisTarihi = edBitis.Value;



                using (SqlConnection con = new SqlConnection(connstring))
                {
                    con.Open();
                    string query = "UPDATE UYELER SET k_id = @id, k_adi = @ad, k_sadi = @soyad, k_yas = @yas, baslangic_t = @baslangicTarihi, bitis_t = @bitisTarihi WHERE k_id = @id";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                     
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@yas", int.Parse(yas));
                        command.Parameters.AddWithValue("@baslangicTarihi", baslangicTarihi);
                        command.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                        command.Parameters.AddWithValue("@id", kid);
                        

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt bulunamadı.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }
    }
}
