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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
