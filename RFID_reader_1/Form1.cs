using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace RFID_reader_1
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string kId;

        private void txt_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    kId = txt_rfid.Text;
                    GetUserInformation(kId);
                }

            }
        }

        private void GetUserInformation(string kId)
        {
            string connectionString = "Data Source=LAPTOP-OJP39STO\\SQLEXPRESS;Initial Catalog=SPORUYE;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM UYELER WHERE k_id = @k_id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@k_id", kId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime baslangic = (DateTime)reader["baslangic_t"];
                            DateTime bitis = (DateTime)reader["bitis_t"];
                            DateTime now = DateTime.Now;

                            if (now < baslangic)
                            {
                                MessageBox.Show("Uyeliginizin baslangic gununu bekleyiniz.");
                            }
                            else if (now > bitis)
                            {
                                MessageBox.Show("Uyeliginiz sona erdi.");
                            }
                            else if (now >= baslangic && now <= bitis)
                            {
                                string id = reader["k_id"].ToString();
                                txt_rfid.Text = id;
                                ShowUyelikBilgiForm();
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz tarih aralığı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID bulunamadı.");
                        }
                    }
                }
            }
        }


        private void ShowUyelikBilgiForm()
        {
            uyelikBilgi uyelikb = new uyelikBilgi(kId);
            uyelikb.Show();
            this.Hide();
        }


        private void btn_kyt_Click(object sender, EventArgs e)
        {
            kullaniciKayit k_kayit = new kullaniciKayit();
            k_kayit.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            kullaniciSil k_sil = new kullaniciSil();
            k_sil.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            idokut i_re = new idokut();
            i_re.Show();
            this.Hide();
        }
    }
}
