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
       public String lvCL_ID;
        String bag;
        MySqlConnection baglanti;
           
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        //  String sql = "SELECT * FROM customer_list "; // +DataListesi;
        //if (DataGridList.Name == "dtgridSalesList")
        //    sql = sql + " ORDER BY  SALE_CODE";
        DataTable dt = new DataTable();
        DataSet dataSet;
        MySqlDataAdapter adapter;
        MySqlCommand command = new MySqlCommand();
        MySqlCommandBuilder cmdb ;
        
           
        public frmCusumerCase()
        {
            InitializeComponent();
            build.Server = "127.0.0.1";//	localhost
            build.UserID = "root";
            build.Password = "";
            build.Database = "case_follow";
            build.Port = 3306;



            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();
         

           


        }


        private void frmCusumerCase_Load(object sender, EventArgs e)
        {
            
            SqlClass sqlCon = new SqlClass();
            //sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);

            sqlCon.ConnectSql();
            String sql = "SELECT * FROM customer_list ";


                //" SELECT CL.*, CC.*,cl.DATE FROM customer_case cc INNER JOIN customer_list  cl ON cl.ID = cc.CL_ID";
            //if (DataGridList.Name == "dtgridSalesList")
            //    sql = sql + " ORDER BY  SALE_CODE";
            DataTable dt = new DataTable();

            
            adapter = new MySqlDataAdapter();//MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            //baglanti.Open();
            adapter.Fill(dt);
            customer_list.DataSource = dt;
            baglanti.Close();

            customer_list.Columns[0].HeaderText = "ID";
            customer_list.Columns[1].HeaderText = "Adı";
            customer_list.Columns[2].HeaderText = "Soyadı";
            customer_list.Columns[3].HeaderText = "Firma Adı";
            customer_list.Columns[4].HeaderText = "Telefon Numarası";
            customer_list.Columns[5].HeaderText = "Adres";
            customer_list.Columns[6].HeaderText = "Kayıt Tarihi";

            customer_list.Columns[0].Visible = false;

           // SqlClass sqlCon = new SqlClass();
            //sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);


            //sqlCon.ConnectSql();
            String sqlTotal2 = "SELECT CC.ODEMETIPI,SUM(CC.TL) AS TL, SUM(CC.EURO) AS EURO, SUM(CC.DOLAR) AS DOLAR FROM customer_case cc WHERE 1 GROUP BY CC.ODEMETIPI";
            //if (DataGridList.Name == "dtgridSalesList")
            //    sql = sql + " ORDER BY  SALE_CODE";
            DataTable dtTotal2 = new DataTable();

            MySqlDataAdapter adapterTotal2 = new MySqlDataAdapter();
            MySqlCommand commandTotal2 = new MySqlCommand();

            commandTotal2.CommandText = sqlTotal2;
            commandTotal2.Connection = baglanti;
            adapterTotal2.SelectCommand = commandTotal2;

            //baglanti.Open();
            adapterTotal2.Fill(dtTotal2);
            grdCase_Total.DataSource = dtTotal2;
            baglanti.Close();

            grdCase_Total.Columns[0].HeaderText = "Ödeme Tipi";
            grdCase_Total.Columns[1].HeaderText = "TL";
            grdCase_Total.Columns[2].HeaderText = "€";
            grdCase_Total.Columns[3].HeaderText = "$";

          //  customer_list.Columns[0].Visible = false;
            



            String id;
            int lvD=0;int lvT=0;int lvE=0;
                  
                
                
                //MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                //build.Server = "localhost";
                //build.UserID = "root";
                //build.Password = "12345678";
                //build.Database = "case_follow";
                //build.Port = 3306;


                //bag = build.ToString();
                //baglanti = new MySqlConnection(bag);

                //baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 

               /* //Nakit
    Kredi Kartı
    Veresiye*/

               
/*
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


                String sql2 = "SELECT * FROM customer_list ";

                command.CommandText = sql2;
                command.Connection = baglanti;
                adapter.SelectCommand = command;

                // baglanti.Open();
                adapter.Fill(dt);
                adapter.Fill(ds, "customer_list");

                customer_list.DataSource = ds.Tables[0];// dt;
                baglanti.Close();*/

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


        private void customer_list_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          //  String a = customer_list.item(0).
           // String a = customer_list.         // textBo            //textBox3.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["SURNAME"].ToString();
            //textBox4.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["DOLAR"].ToString();
            //textBox5.Text = ds.Tables["customer_list"].Rows[e.RowIndex]["TL"].ToString();
          //  textBox6.Text = ds.Tables["tablo"].Rows[e.RowIndex]["final"].ToString();
            //MessageBox.Show("cursor change  change3", "cursor changeEnter");
        }

     
        private void customer_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          String a =   customer_list.TabIndex.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        private void button1_Click_2(object sender, EventArgs e)
        {
            lvCL_ID = "0";
            try
            {
                if (customer_list.CurrentRow.Cells["CL_ID"].Value.ToString() == "")
                    lvCL_ID = "0";
                else
                  lvCL_ID = customer_list.CurrentRow.Cells["CL_ID"].Value.ToString();

            }
            catch
            {
                lvCL_ID = "0";
            }
            if (Convert.ToInt32(lvCL_ID) > 0)
            {
                frmCustomDetailList detail = new frmCustomDetailList();
                detail.ArrangeForm(lvCL_ID);
                // detail.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Veriyi güncellemek istiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //baglanti = new MySqlConnection(bag);
            if (result == DialogResult.Yes)
            { 
                try{
                   
                    cmdb = new MySqlCommandBuilder(adapter);
          /*  DataSet uds = new DataSet();
            uds = dataSet.GetChanges(DataRowState.Modified);
            
            adapter.Update(uds);*/

                    adapter.Update(dataSet, "customer_case");
                    if (baglanti.State == ConnectionState.Closed)
                      baglanti.Open();

                    String sqlTotal2 = "SELECT CC.ODEMETIPI,SUM(CC.TL) AS TL, SUM(CC.EURO) AS EURO, SUM(CC.DOLAR) AS DOLAR FROM customer_case cc WHERE 1 GROUP BY CC.ODEMETIPI";
                    //if (DataGridList.Name == "dtgridSalesList")
                    //    sql = sql + " ORDER BY  SALE_CODE";
                    DataTable dtTotal2 = new DataTable();

                    MySqlDataAdapter adapterTotal2 = new MySqlDataAdapter();
                    MySqlCommand commandTotal2 = new MySqlCommand();

                    commandTotal2.CommandText = sqlTotal2;
                    commandTotal2.Connection = baglanti;
                    adapterTotal2.SelectCommand = commandTotal2;

                    //baglanti.Open();
                    adapterTotal2.Fill(dtTotal2);
                    grdCase_Total.DataSource = dtTotal2;
                    baglanti.Close();

                    grdCase_Total.Columns[0].HeaderText = "Ödeme Tipi";
                    grdCase_Total.Columns[1].HeaderText = "TL";
                    grdCase_Total.Columns[2].HeaderText = "€";
                    grdCase_Total.Columns[3].HeaderText = "$";   




                }
                catch (global::System.Exception ex)
                {
                    MessageBox.Show((ex.Message + (" : " + "Bir hata olustu, lütfen daha sonra tekrar deneyiniz...")), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            
         
        }

        private void customer_list_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String lvCL_ID;
            //dataSet = null;
            try
            {
                lvCL_ID = customer_list.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch
            {
                lvCL_ID = "0";
            }

         /*   SqlClass sqlCon = new SqlClass();

            String bag;
            DataSet dSet = new DataSet();



            SqlClass connect = new SqlClass();
            connect.ConnectSql();*/

            String sqlTotal3 = "SELECT * FROM customer_case CC where CC.CL_ID = " + "'"+ lvCL_ID + "'";
            //if (DataGridList.Name == "dtgridSalesList")
            //    sql = sql + " ORDER BY  SALE_CODE";
            DataTable dtTotal3 = new DataTable();
            dataSet = new DataSet();

             adapter = new MySqlDataAdapter();
            MySqlCommand commandTotal3 = new MySqlCommand();

            commandTotal3.CommandText = sqlTotal3;
            commandTotal3.Connection = baglanti;
            adapter.SelectCommand = commandTotal3;
            if (baglanti.State == ConnectionState.Closed)
              baglanti.Open();

            adapter.Fill(dtTotal3);
            adapter.Fill(dataSet, "customer_case");
            grdCusCasDetail.DataSource = dataSet.Tables[0];//dtTotal3;
            baglanti.Close();

            grdCusCasDetail.Columns[0].HeaderText = "CL_ID";
            grdCusCasDetail.Columns[1].HeaderText = "TL";
            grdCusCasDetail.Columns[2].HeaderText = "€";
            grdCusCasDetail.Columns[3].HeaderText = "$";
            grdCusCasDetail.Columns[4].HeaderText = "Ödeme Tipi";
            grdCusCasDetail.Columns[5].HeaderText = "ID";

            grdCusCasDetail.Columns[0].Visible = false;
            grdCusCasDetail.Columns[5].Visible = false;
        }
    }
}
