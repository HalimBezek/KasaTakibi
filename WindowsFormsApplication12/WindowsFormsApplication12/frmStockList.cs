using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Net;
using System.Net.Mail;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf.fonts;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace WindowsFormsApplication12
{
    public partial class frmStockList : Form
    {      String bag;
           MySqlConnection baglanti;
           
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            
        public frmStockList()
        {
            InitializeComponent();


            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "case_follow";
            build.Port = 3306;


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            SqlClass sqlCon = new SqlClass();
            sqlCon.ListData(dtgrdStockList, DateTime.Now,DateTime.Now);


            dtgrdStockList.Columns[0].HeaderText = "Numarası";
            dtgrdStockList.Columns[1].HeaderText = "Adı";
            dtgrdStockList.Columns[2].HeaderText = "Stok Kodu";
            dtgrdStockList.Columns[3].HeaderText = "Kaç Adet";
            dtgrdStockList.Columns[4].HeaderText = "Alan Firma/Kişi";
            dtgrdStockList.Columns[5].HeaderText = "Fiyatı";
            dtgrdStockList.Columns[6].HeaderText = "Ödeme Cinsi";
            dtgrdStockList.Columns[7].HeaderText = "Kayıt Tarihi";

            dtgrdStockList.Columns[0].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgrdStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQueryStock_Click(object sender, EventArgs e)
        {
            string yr, m, d, yr2, m2, d2;  
            
            yr = dateTimePicker1.Value.Year.ToString();
            m = dateTimePicker1.Value.Month.ToString();
            d = dateTimePicker1.Value.Day.ToString();
            yr2 = dateTimePicker2.Value.Year.ToString();
            m2 = dateTimePicker2.Value.Month.ToString();
            d2 = dateTimePicker2.Value.Day.ToString();

            String SQLTEXT = " SELECT * FROM stock_list Where DATE BETWEEN '" + yr + "-" + m + "-" + d + "' AND "+"'" + yr2 + "-" + m2 + "-" + d2 + "'";

            String sql = SQLTEXT;//"SELECT * FROM stock_list Where DATE BETWEEN @tar1 and @tar2 ";
                //if (DataGridList.Name == "dtgridSalesList")
                //    sql = sql + " ORDER BY  SALE_CODE";
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;

            //if (baglanti.State =Close )  
             //   baglanti.Open();
                adapter.Fill(dt);
                dtgrdStockList.DataSource = dt;
                baglanti.Close();

            dtgrdStockList.Columns[0].HeaderText = "Numarası";
            dtgrdStockList.Columns[1].HeaderText = "Adı";
            dtgrdStockList.Columns[2].HeaderText = "Stok Kodu";
            dtgrdStockList.Columns[3].HeaderText = "Kaç Adet";
            dtgrdStockList.Columns[4].HeaderText = "Alan Firma/Kişi";
            dtgrdStockList.Columns[5].HeaderText = "Fiyatı";
            dtgrdStockList.Columns[6].HeaderText = "Ödeme Cinsi";

            dtgrdStockList.Columns[0].Visible = false;
        }
    }
}
