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
    public partial class kullaniciSil : Form
    {

        string connstring = "Data Source=LAPTOP-OJP39STO\\SQLEXPRESS;Initial Catalog=SPORUYE;Integrated Security=True";

        public kullaniciSil()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.ActiveControl = textBox1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(textBox1.Text);

                using (SqlConnection con = new SqlConnection(connstring))
                {
                    con.Open();
                    string query = "DELETE FROM UYELER WHERE k_id = @k_id";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@k_id", id);

                        int bulunansatir = command.ExecuteNonQuery();

                        if (bulunansatir > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.");
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();
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
                MessageBox.Show("Bir hata olustu" + ex.Message);
            }
        }
    }
}
