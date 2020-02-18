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
        SqlConnection con = new SqlConnection("Data Source=303-16\\SQLServer; Initial Catalog=gibdd; Integrated Security=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlComman con = new SqlCommand($"Select login FROM usrers where login = '{textBox1.Text}' and pass = '{textBox2.Text}'", con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
                MessageBox.Show("good");
            else
            {

            }
            string login = textBox1.Text;
            string password = textBox2.Text;
        }
    }
}
