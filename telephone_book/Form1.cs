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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\\SQLEXPRESS;Initial Catalog=TelephoneBook;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
