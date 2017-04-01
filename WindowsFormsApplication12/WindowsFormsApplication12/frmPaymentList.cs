using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class frmPaymentList : Form
    {
        public frmPaymentList()
        {
            InitializeComponent();
        }

        private void frmPaymentList_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(dtgridPaymentList);

            dtgridPaymentList.Columns[0].HeaderText = "Numarası";
            dtgridPaymentList.Columns[1].HeaderText = "Ödeme Şekli";
            dtgridPaymentList.Columns[2].HeaderText = "Miktar";
            dtgridPaymentList.Columns[3].HeaderText = "Ödeme Tipi";
            dtgridPaymentList.Columns[4].HeaderText = "Ödeme Cinsi";
            dtgridPaymentList.Columns[5].HeaderText = "Müşteri";
                      
            dtgridPaymentList.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
