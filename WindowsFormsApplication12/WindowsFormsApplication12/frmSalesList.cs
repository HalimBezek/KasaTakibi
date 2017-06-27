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
    public partial class frmSalesList : Form
    {
        public DataGridView lgvdtgridSalesList; 
        String bag;
        MySqlConnection baglanti;
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

             
        public frmSalesList()
        {
            InitializeComponent();
            lgvdtgridSalesList = dtgridSalesList;


            build.Server = "127.0.0.1";//	localhost
            build.UserID = "root";
            build.Password = "";
            build.Database = "case_follow";
            build.Port = 3306;


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();
        }

        private void frmSalesList_Load(object sender, EventArgs e)
        {
            string yr, m, d, yr2, m2, d2;

            yr = dateTimePicker1.Value.Year.ToString();
            m = dateTimePicker1.Value.Month.ToString();
            d = dateTimePicker1.Value.Day.ToString();
            yr2 = dateTimePicker2.Value.Year.ToString();
            m2 = dateTimePicker2.Value.Month.ToString();
            d2 = dateTimePicker2.Value.Day.ToString();

            String SQLTEXT = "SELECT concat(sl.NAME,' ',concat('(',sl.CODE,')')) as SNAME, CONCAT(CL.NAME, ' ', CL.SURNAME) AS FNAME, dsc.* from daily_sale_case dsc" +
                                " JOIN stock_list sl ON DSC.SL_ID = SL.ID JOIN customer_list CL ON CL.ID = DSC.CL_ID Where dsc.DATE BETWEEN '" +
                              yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";

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
             // baglanti.Open();
            adapter.Fill(dt);
            dtgridSalesList.DataSource = dt;
            baglanti.Close();

            dtgridSalesList.Columns[0].HeaderText = "Stok Adı";
            dtgridSalesList.Columns[1].HeaderText = "Müşteri";
            dtgridSalesList.Columns[2].HeaderText = "ID";
            dtgridSalesList.Columns[3].HeaderText = "CL_ID";
            dtgridSalesList.Columns[4].HeaderText = "SL_ID";
            dtgridSalesList.Columns[5].HeaderText = "TL";
            dtgridSalesList.Columns[6].HeaderText = "Dolar";
            dtgridSalesList.Columns[7].HeaderText = "Euro";
            dtgridSalesList.Columns[8].HeaderText = "Adet Sayısı";
            dtgridSalesList.Columns[9].HeaderText = "Ödeme Tipi";
            dtgridSalesList.Columns[10].HeaderText = "Tarih";

            dtgridSalesList.Columns[2].Visible = false;
            dtgridSalesList.Columns[3].Visible = false;
            dtgridSalesList.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

            String SQLTEXT = "SELECT concat(sl.NAME,' ',concat('(',sl.CODE,')')) as SNAME, CONCAT(CL.NAME, ' ', CL.SURNAME) AS FNAME, dsc.* from daily_sale_case dsc" +
                                " JOIN stock_list sl ON DSC.SL_ID = SL.ID JOIN customer_list CL ON CL.ID = DSC.CL_ID Where dsc.DATE BETWEEN '" +
                              yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";
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
            dtgridSalesList.DataSource = dt;
            baglanti.Close();

            dtgridSalesList.Columns[0].HeaderText = "Stok Adı";
            dtgridSalesList.Columns[1].HeaderText = "Müşteri";
            dtgridSalesList.Columns[2].HeaderText = "ID";
            dtgridSalesList.Columns[3].HeaderText = "CL_ID";
            dtgridSalesList.Columns[4].HeaderText = "SL_ID";
            dtgridSalesList.Columns[5].HeaderText = "TL";
            dtgridSalesList.Columns[6].HeaderText = "Dolar";
            dtgridSalesList.Columns[7].HeaderText = "Euro";
            dtgridSalesList.Columns[8].HeaderText = "Adet Sayısı";
            dtgridSalesList.Columns[9].HeaderText = "Ödeme Tipi";
            dtgridSalesList.Columns[10].HeaderText = "Tarih";

            dtgridSalesList.Columns[2].Visible = false;
            dtgridSalesList.Columns[3].Visible = false;
            dtgridSalesList.Columns[4].Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string yr, m, d, yr2, m2, d2;

            yr = dateTimePicker1.Value.Year.ToString();
            m = dateTimePicker1.Value.Month.ToString();
            d = dateTimePicker1.Value.Day.ToString();
            yr2 = dateTimePicker2.Value.Year.ToString();
            m2 = dateTimePicker2.Value.Month.ToString();
            d2 = dateTimePicker2.Value.Day.ToString();

            String SQLTEXT = "SELECT concat(sl.NAME,' ',concat('(',sl.CODE,')')) as SNAME, CONCAT(CL.NAME, ' ', CL.SURNAME) AS FNAME, dsc.* from daily_sale_case dsc" +
                                " JOIN stock_list sl ON DSC.SL_ID = SL.ID JOIN customer_list CL ON CL.ID = DSC.CL_ID Where sl.NAME LIKE '" + textBox1.Text + "%'" +
                                                   " AND dsc.DATE BETWEEN '" + yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";

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
            dtgridSalesList.DataSource = dt;
            baglanti.Close();

            dtgridSalesList.Columns[0].HeaderText = "Adı";
            dtgridSalesList.Columns[1].HeaderText = "Numarası";
            dtgridSalesList.Columns[2].HeaderText = "Satılan Ürün Kodu";
            dtgridSalesList.Columns[3].HeaderText = "Ödeme Tipi";
            dtgridSalesList.Columns[4].HeaderText = "Fiyatı";
            dtgridSalesList.Columns[5].HeaderText = "Ödeme Cinsi";
            dtgridSalesList.Columns[6].HeaderText = "Adet";
            dtgridSalesList.Columns[7].HeaderText = "Müşteri";
            dtgridSalesList.Columns[8].HeaderText = "Tarih";

            dtgridSalesList.Columns[1].Visible = false;
        }
    }
}
