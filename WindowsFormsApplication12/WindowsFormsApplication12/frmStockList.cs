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
    public partial class frmStockList : Form
    {
        public frmStockList()
        {
            InitializeComponent();
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(dtgrdStockList);


            dtgrdStockList.Columns[0].HeaderText = "Numarası";
            dtgrdStockList.Columns[1].HeaderText = "Adı";
            dtgrdStockList.Columns[2].HeaderText = "Stok Kodu";
            dtgrdStockList.Columns[3].HeaderText = "Kaç Adet";
            dtgrdStockList.Columns[4].HeaderText = "Alan Firma/Kişi";
            dtgrdStockList.Columns[5].HeaderText = "Markası";
            dtgrdStockList.Columns[6].HeaderText = "Ödeme Cinsi";

            dtgrdStockList.Columns[0].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgrdStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
