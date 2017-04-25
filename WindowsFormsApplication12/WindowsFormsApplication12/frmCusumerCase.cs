using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class frmCusumerCase : Form
    {   
        String bag;
        MySqlConnection baglanti;
           
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        //  String sql = "SELECT * FROM customer_list "; // +DataListesi;
        //if (DataGridList.Name == "dtgridSalesList")
        //    sql = sql + " ORDER BY  SALE_CODE";
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        MySqlCommandBuilder cmdb ;
        
           
        public frmCusumerCase()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            //SqlClass sqlCon = new SqlClass();
           // sqlCon.UpdateData(customer_list);
            
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
            customer_list.Columns[6].HeaderText = "tl";
            customer_list.Columns[7].HeaderText = "$";
         //   customer_list.Columns[7].ValueType = typeof(double);
            customer_list.Columns[8].HeaderText = "€";
            customer_list.Columns[9].HeaderText = "Ödeme Tipi";
            customer_list.Columns[10].HeaderText = "Ödeme Tipi";//"Tarih";


            customer_list.Columns[5].Visible = false;
            customer_list.Columns[3].Visible = false;
            customer_list.Columns[0].Visible = false;
            customer_list.Columns[9].Visible = false;

            

            String id;
            int lvD=0;int lvT=0;int lvE=0;
                  
                
                
                MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345678";
                build.Database = "case_follow";
                build.Port = 3306;


                bag = build.ToString();
                baglanti = new MySqlConnection(bag);

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 

                /*Nakit
    Kredi Kartı
    Veresiye*/

               

                String sql3 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Nakit'";
                String sql4 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Nakit'";
                String sql5 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Nakit'";
                String sql6 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Kredi Kartı'";
                String sql7 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Kredi Kartı'";
                String sql8 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Kredi Kartı'";
                String sql9 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Veresiye'";
                String sql11 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Veresiye'";
                String sql12 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Veresiye'";
                MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
                String SonucTL = komut3.ExecuteScalar().ToString();
                MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
                String SonucDOLAR = komut4.ExecuteScalar().ToString();
                MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
                String SonucEURO = komut5.ExecuteScalar().ToString();
                MySqlCommand komut6 = new MySqlCommand(sql6, baglanti);
                String SonucKKTL = komut6.ExecuteScalar().ToString();
                MySqlCommand komut7 = new MySqlCommand(sql7, baglanti);
                String SonucKKDOLAR = komut7.ExecuteScalar().ToString();
                MySqlCommand komut8 = new MySqlCommand(sql8, baglanti);
                String SonucKKEURO = komut8.ExecuteScalar().ToString();
                MySqlCommand komut9 = new MySqlCommand(sql9, baglanti);
                String SonucVTL = komut9.ExecuteScalar().ToString();
                MySqlCommand komut10 = new MySqlCommand(sql11, baglanti);
                String SonucVDOLAR = komut10.ExecuteScalar().ToString();
                MySqlCommand komut11 = new MySqlCommand(sql12, baglanti);
                String SonucVEURO = komut11.ExecuteScalar().ToString();
                komut3.ExecuteNonQuery();//
                textBoxNTL.Text = SonucTL;
                textBoxNDOLAR.Text = SonucDOLAR;
                textBoxNEURO.Text = SonucEURO;
                textBoxKKTL.Text = SonucKKTL;
                textBoxKKDOLAR.Text = SonucKKDOLAR;
                textBoxKKEURO.Text = SonucKKEURO;
                textBoxVTL.Text = SonucVTL;
                textBoxVDOLAR.Text = SonucVDOLAR;
                textBoxVEURO.Text = SonucVEURO;


                String sql = "SELECT * FROM customer_list ";

                command.CommandText = sql;
                command.Connection = baglanti;
                adapter.SelectCommand = command;

                // baglanti.Open();
                adapter.Fill(dt);
                adapter.Fill(ds, "customer_list");

                customer_list.DataSource = ds.Tables[0];// dt;
                baglanti.Close();

            }

        private void btnQueryStock_Click(object sender, EventArgs e)
        {
            //string yr, m, d, yr2, m2, d2;

            //yr = dateTimePicker1.Value.Year.ToString();
            //m = dateTimePicker1.Value.Month.ToString();
            //d = dateTimePicker1.Value.Day.ToString();
            //yr2 = dateTimePicker2.Value.Year.ToString();
            //m2 = dateTimePicker2.Value.Month.ToString();
            //d2 = dateTimePicker2.Value.Day.ToString();

            //String SQLTEXT = " SELECT * FROM customer_list Where DATE BETWEEN '" + yr + "-" + m + "-" + d + "' AND " + "'" + yr2 + "-" + m2 + "-" + d2 + "'";

            //String sql = SQLTEXT;//"SELECT * FROM stock_list Where DATE BETWEEN @tar1 and @tar2 ";
            ////if (DataGridList.Name == "dtgridSalesList")
            ////    sql = sql + " ORDER BY  SALE_CODE";
            //DataTable dt = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand();

            //command.CommandText = sql;
            //command.Connection = baglanti;
            //adapter.SelectCommand = command;

            ////if (baglanti.State =Close )  
            ////   baglanti.Open();
            //adapter.Fill(dt);
            //customer_list.DataSource = dt;
            //baglanti.Close();

            //customer_list.Columns[0].HeaderText = "Numarası";
            //customer_list.Columns[1].HeaderText = "Adı";
            //customer_list.Columns[2].HeaderText = "Soyadı";
            //customer_list.Columns[3].HeaderText = "Firma Adı";
            //customer_list.Columns[4].HeaderText = "Telefon Numarası";
            //customer_list.Columns[5].HeaderText = "Adres";
            //customer_list.Columns[6].HeaderText = "tl";
            //customer_list.Columns[7].HeaderText = "$";
            //customer_list.Columns[7].ValueType = typeof(double);
            //customer_list.Columns[8].HeaderText = "€";
            //customer_list.Columns[9].HeaderText = "Tarih";
            //customer_list.Columns[9].HeaderText = "Ödeme Tipi";

            //customer_list.Columns[0].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        
        }

        private void btnQueryStock_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_list_CausesValidationChanged(object sender, EventArgs e)
        {
         
        }

        private void customer_list_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void customer_list_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void customer_list_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void customer_list_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          //  String a = customer_list.item(0).
           // String a = customer_list.         // textBo            //textBox3.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["SURNAME"].ToString();
            //textBox4.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["DOLAR"].ToString();
            //textBox5.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["TL"].ToString();
          //  textBox6.Text = ds.Tables["tablo"].Rows[e.RowIndex]["final"].ToString();
            //MessageBox.Show("cursor change  change3", "cursor changeEnter");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void customer_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          String a =   customer_list.TabIndex.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customer_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           // this.adapter.Update(this.dt);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            baglanti = new MySqlConnection(bag);

           
            cmdb = new MySqlCommandBuilder(adapter);
            adapter.Update(ds, "customer_list");
            baglanti.Open();
            String sql3 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Nakit'";
            String sql4 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Nakit'";
            String sql5 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Nakit'";
            String sql6 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Kredi Kartı'";
            String sql7 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Kredi Kartı'";
            String sql8 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Kredi Kartı'";
            String sql9 = "SELECT SUM(cl.TL) FROM customer_list cl WHERE cl.ODEMETIPI= 'Veresiye'";
            String sql11 = "SELECT SUM(cl.DOLAR) FROM customer_list cl WHERE cl.ODEMETIPI='Veresiye'";
            String sql12 = "SELECT SUM(cl.EURO) FROM customer_list cl WHERE cl.ODEMETIPI= 'Veresiye'";
            MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
            String SonucTL = komut3.ExecuteScalar().ToString();
            MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
            String SonucDOLAR = komut4.ExecuteScalar().ToString();
            MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
            String SonucEURO = komut5.ExecuteScalar().ToString();
            MySqlCommand komut6 = new MySqlCommand(sql6, baglanti);
            String SonucKKTL = komut6.ExecuteScalar().ToString();
            MySqlCommand komut7 = new MySqlCommand(sql7, baglanti);
            String SonucKKDOLAR = komut7.ExecuteScalar().ToString();
            MySqlCommand komut8 = new MySqlCommand(sql8, baglanti);
            String SonucKKEURO = komut8.ExecuteScalar().ToString();
            MySqlCommand komut9 = new MySqlCommand(sql9, baglanti);
            String SonucVTL = komut9.ExecuteScalar().ToString();
            MySqlCommand komut10 = new MySqlCommand(sql11, baglanti);
            String SonucVDOLAR = komut10.ExecuteScalar().ToString();
            MySqlCommand komut11 = new MySqlCommand(sql12, baglanti);
            String SonucVEURO = komut11.ExecuteScalar().ToString();
            komut3.ExecuteNonQuery();//
            textBoxNTL.Text = SonucTL;
            textBoxNDOLAR.Text = SonucDOLAR;
            textBoxNEURO.Text = SonucEURO;
            textBoxKKTL.Text = SonucKKTL;
            textBoxKKDOLAR.Text = SonucKKDOLAR;
            textBoxKKEURO.Text = SonucKKEURO;
            textBoxVTL.Text = SonucVTL;
            textBoxVDOLAR.Text = SonucVDOLAR;
            textBoxVEURO.Text = SonucVEURO;



            MessageBox.Show("Kayıt güncellendi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
           
        }
    }
}
