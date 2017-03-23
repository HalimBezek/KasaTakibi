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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();

            sqlConn.AddStock(tbName.Text, tbCode.Text, Convert.ToInt32(tbPieces.Text), tbCustomer.Text, tbBRAND.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlClass sqlConn = new SqlClass();

            sqlConn.AddSale(cbStockCode.Text, Convert.ToInt32(tbSalePiece.Text), Convert.ToInt32(tbPrice.Text), cbType.Text, cbCinsi.Text);

        }
    }
}
