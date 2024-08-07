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
namespace telephone_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\SQLEXPRESS;Initial Catalog=TelephoneBook;Integrated Security=True");

        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From PEOPLE", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void clear()
        {
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtSurname.Text = string.Empty;
            mskPhone.Text = string.Empty;
            txtName.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PEOPLE(NAME,SURNAME,MAIL,PHONE)values(@p1,@p2,@p3,@p4)",con);
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", txtMail.Text);
            cmd.Parameters.AddWithValue("@p4", mskPhone.Text);
            cmd.ExecuteNonQuery(); // run sql 
            con.Close();
            MessageBox.Show("Information has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
