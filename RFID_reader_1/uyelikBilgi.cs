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

namespace RFID_reader_1
{
    public partial class uyelikBilgi : Form
    {

        private Timer timer;

        public uyelikBilgi(string kId)
        {

            InitializeComponent();

            this.ControlBox = false;

            string connstring = "Data Source=LAPTOP-OJP39STO\\SQLEXPRESS;Initial Catalog=SPORUYE;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connstring))
            {

                

                con.Open();
                string sql = "SELECT * FROM UYELER WHERE k_id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@id", kId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string baslangicString = reader["baslangic_t"].ToString();
                            string bitisString = reader["bitis_t"].ToString();

                            DateTime baslangicDate = DateTime.Parse(baslangicString);
                            DateTime bitisDate = DateTime.Parse(bitisString);

                            string formattedBaslangicDate = baslangicDate.ToString("yyyy-MM-dd");
                            string formattedBitisDate = bitisDate.ToString("yyyy-MM-dd");

                            string baslangic = formattedBaslangicDate;
                            string bitis = formattedBitisDate;
                            string id = reader["k_id"].ToString();
                            string ad = reader["k_adi"].ToString();
                            string soyad = reader["k_sadi"].ToString();
                            string yas = reader["k_yas"].ToString();

                            textBox1.Text = ad;
                            textBox2.Text = soyad;
                            textBox3.Text = yas;
                            textBox4.Text = baslangic;
                            textBox5.Text = bitis;
                            textBox6.Text = id;

                            textBox1.ReadOnly = true;
                            textBox2.ReadOnly = true;
                            textBox3.ReadOnly = true;
                            textBox4.ReadOnly = true;
                            textBox5.ReadOnly = true;
                            textBox6.ReadOnly = true;

                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox6.Enabled = false;

                        }

                    }

                }
            }

            timer = new Timer();
            timer.Interval = 5000; 
            timer.Tick += timer1_Tick;
            timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}
