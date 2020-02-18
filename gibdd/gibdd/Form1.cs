using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gibdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=303-16\\SQLSERVER; Initial Catalog=driverlist; Integrated Security=true;");
        private void auth_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand($"Select login FROM usrers WHERE login = '{textBox1.Text}' and pass = '{textBox2.Text}'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
                MessageBox.Show("good");
            else
            {
                if (Properties.Settings.Default.time <= DateTime.UtcNow)
                {
                    Properties.Settings.Default.attempts++;
                    if (Properties.Settings.Default.attempts == 3)
                    {
                        Properties.Settings.Default.time = DateTime.UtcNow.AddMinutes(1);
                        Properties.Settings.Default.attempts = 0;
                        button1.Enabled = false;

                    }
                }
                MessageBox.Show("bad");
            }
            con.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.time <= DateTime.UtcNow)
            {
                button1.Enabled = true;
            }
        }
    }
}
