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
        String PaymentType;
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
            if ((tbName.Text == "") || (tbCode.Text == "") || (tbPieces.Text == "") || (tbCustomer.Text == "") || (tbBRAND.Text == ""))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {

                SqlClass sqlConn = new SqlClass();

                sqlConn.AddStock(tbName.Text, tbCode.Text, Convert.ToInt32(tbPieces.Text), tbCustomer.Text, tbBRAND.Text);
                tbName.Text = " ";
                tbCode.Text = " ";
                tbPieces.Text = " ";
                tbCustomer.Text = " ";
                tbBRAND.Text = " ";

                lblSave.Visible = true;

                FullCombobax();
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if ((cbStockCode.Text == "") || (tbSalePiece.Text == "") || (tbPrice.Text == "") || (cbType.Text == "") || (cbCinsi.Text == ""))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {
                SqlClass sqlConn = new SqlClass();

                sqlConn.AddSale(cbStockCode.Text, Convert.ToInt32(tbSalePiece.Text), Convert.ToInt32(tbPrice.Text), cbType.Text, cbCinsi.Text);
                cbStockCode.Text = " ";
                tbSalePiece.Text = " ";
                tbPrice.Text = " ";
                cbType.Text = " ";
                cbCinsi.Text = " ";

                lblSave2.Visible = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if ((tbPricePay.Text == "") || (cb2Cinsi.Text == "") || (cb2Type.Text == "") || ((cbGivePay.Checked == false) && (cbTakePay.Checked == false)))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {
                if (cbTakePay.Checked == true)
                    PaymentType = cbTakePay.Text;
                else if (cbGivePay.Checked == true)
                    PaymentType = cbGivePay.Text;


                SqlClass sqlConn = new SqlClass();
                sqlConn.AddPayment(PaymentType, Convert.ToInt32(tbPricePay.Text), cb2Cinsi.Text, cb2Type.Text);

                cbGivePay.Checked = false;
                cbTakePay.Checked = false;
                tbPricePay.Text = " ";
                cb2Cinsi.Text = " ";
                cb2Type.Text = " ";


                lblSave3.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmStockList frmStckList = new frmStockList();
            frmStckList.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSalesList frmSaleList = new frmSalesList();
            frmSaleList.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPaymentList frmPayList = new frmPaymentList();
            frmPayList.Show();
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            lblSave.Visible = false;

        }

        private void cbStockCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSave2.Visible = false;
        }

        private void tbPricePay_TextChanged(object sender, EventArgs e)
        {
            lblSave3.Visible = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            FullCombobax();
        }
        private void FullCombobax()
        {
            DataGridView DataGrView = new DataGridView();
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(DataGrView);
            cbStockCode.DataSource = DataGrView.DataSource;
            cbStockCode.DisplayMember = "CODE";

        }

        private void tbPieces_TextChanged(object sender, EventArgs e)
        {
            
        }
      

        private void tbPieces_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSalePiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbPricePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            frmMain.Show();
        }
    }
}
