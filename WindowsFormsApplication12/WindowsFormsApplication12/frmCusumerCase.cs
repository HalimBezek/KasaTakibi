using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class frmCusumerCase : Form
    {
        public frmCusumerCase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCusumerCase_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);

            customer_list.Columns[0].HeaderText = "Numarası";
            customer_list.Columns[1].HeaderText = "Adı";
            customer_list.Columns[2].HeaderText = "Soyadı";
            customer_list.Columns[3].HeaderText = "Firma Adı";
            customer_list.Columns[4].HeaderText = "Telefon Numarası";
            customer_list.Columns[5].HeaderText = "Adres";
            //customer_list.Columns[6].HeaderText = "Müşteri";

            customer_list.Columns[0].Visible = false;
        }
    }
}
