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
    public partial class frmSalesList : Form
    {
        public DataGridView lgvdtgridSalesList; 
        public frmSalesList()
        {
            InitializeComponent();
            lgvdtgridSalesList = dtgridSalesList;
        }

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(dtgridSalesList, DateTime.Now, DateTime.Now);

            dtgridSalesList.Columns[0].HeaderText = "Numarası";
            dtgridSalesList.Columns[1].HeaderText = "Satılan Ürün Kodu";
            dtgridSalesList.Columns[2].HeaderText = "Ödeme Tipi";
            dtgridSalesList.Columns[3].HeaderText = "Fiyatı";
            dtgridSalesList.Columns[4].HeaderText = "Ödeme Cinsi";
            dtgridSalesList.Columns[5].HeaderText = "Adet";
            dtgridSalesList.Columns[6].HeaderText = "Müşteri";

            dtgridSalesList.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
