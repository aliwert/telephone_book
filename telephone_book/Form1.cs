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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int c =dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[c].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[c].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[c].Cells[2].Value.ToString();
            mskPhone.Text = dataGridView1.Rows[c].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[c].Cells[4].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from PEOPLE where ID=" + txtID.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            list();
            clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update PEOPLE set NAME=@t1, SURNAME=@t2, PHONE=@t3, MAIL=@t4 where ID=@t5", con);
            cmd.Parameters.AddWithValue("@t1", txtName.Text);
            cmd.Parameters.AddWithValue("@t2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@t3", mskPhone.Text);
            cmd.Parameters.AddWithValue("@t4", txtMail.Text);
            cmd.Parameters.AddWithValue("@t5", txtID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            list();
            clear();
        }
    }
}
