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
    public partial class AddForm : Form
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
        MySqlCommandBuilder cmdb;
        
        String lgvCustumer;
        String PaymentType;

        String userid;
        String stocklist_id;
       public AddForm()
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
            userid = "0";
            stocklist_id = "0";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStock_Click(object sender, EventArgs e)//private void button1_Click(object sender, EventArgs e)
        {
            String CustomName;
            int lvD = 0; int lvT = 0; int lvE = 0;
       
            if ((tbName.Text.Trim() == "") || (tbCode.Text.Trim() == "") || (tbPieces.Text.Trim() == "") || ((tbCustomer.Text.Trim() == "") && (tbCustomerOto.Text.Trim() == "")) ||
                (tcPrices.Text.Trim() == "") || (cbCinsi.Text.Trim() == "") || (cbODEMECINSI.Text.Trim() == ""))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {
                if (tbCustomer.Text.Trim() != "")
                   CustomName = tbCustomer.Text;
                else CustomName = tbCustomerOto.Text;

               SqlClass sqlConn = new SqlClass();

                sqlConn.AddStock(tbName.Text, tbCode.Text, Convert.ToInt32(tbPieces.Text), CustomName, Convert.ToDouble(tcPrices.Text), cbCinsi.Text, cbODEMECINSI.Text);



                if (String.Equals(cbCinsi.Text, "$"))
                { lvD = Convert.ToInt32(tcPrices.Text) ; }
                if (String.Equals(cbCinsi.Text, "TL"))
                { lvT = Convert.ToInt32(tcPrices.Text); }
                if (String.Equals(cbCinsi.Text, "€"))
                { lvE = Convert.ToInt32(tcPrices.Text); }


                String bag;
                String textt;
                String sqlNew1;
                String Sqlsonuc;

            Sqlsonuc = null;
            sqlNew1 = null;

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 

                sqlNew1 = "SELECT sl.ID FROM stock_list sl WHERE sl.CODE = '" + tbCode.Text.Trim() + "'";
                MySqlCommand komutSql = new MySqlCommand(sqlNew1, baglanti);
                Sqlsonuc = komutSql.ExecuteScalar().ToString();
                if (Sqlsonuc != "")
                {
                //    MessageBox.Show("Aynı kayıt sistemde mevcut!");                       
                }              
                /*String sql3 = "SELECT cl.TL FROM customer_list cl WHERE CL.ID=" + id;
                String sql4 = "SELECT cl.DOLAR FROM customer_list cl WHERE CL.ID=" + id;
                String sql5 = "SELECT cl.EURO FROM customer_list cl WHERE CL.ID= " + id;
                MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
                String SonucTL = komut3.ExecuteScalar().ToString();
                MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
                String SonucDOLAR = komut4.ExecuteScalar().ToString();
                MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
                String SonucEURO = komut5.ExecuteScalar().ToString();
                komut3.ExecuteNonQuery();*/
               // lvT = Convert.ToInt32(SonucTL) - (lvT * Convert.ToInt32(tbPieces.Text));
               // lvE = Convert.ToInt32(SonucEURO)- (lvE * Convert.ToInt32(tbPieces.Text));
                //lvD = Convert.ToInt32(SonucDOLAR)- (lvD * Convert.ToInt32(tbPieces.Text));


               // textt = "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(id);
                //case_name
                //baglanti.Open();
                textt = "INSERT INTO stock_list_case(CL_ID, TL, DOLAR, EURO, ODEMETIPI,PIECES, KISI_ADI, CODE) VALUES (" + Convert.ToInt64(userid) +
                         "," + lvT + " ," + lvD + " ," + lvE + " ," + "'" + cbODEMECINSI.Text + "'" + " ," + Convert.ToInt64(tbPieces.Text) + " ," + "'" +
                         CustomName + "'" + " ," + "'" + tbCode.Text + "'" + ")"; 

                string sql2 = textt;

                MySqlCommand komut2 = new MySqlCommand(sql2, baglanti);

                komut2.ExecuteNonQuery();//

                baglanti.Close();

                if (String.Equals(cbCinsi.Text, "$"))
                { lvD = Convert.ToInt32(tcPrices.Text) * Convert.ToInt32(tbPieces.Text); }
                if (String.Equals(cbCinsi.Text, "TL"))
                { lvT = Convert.ToInt32(tcPrices.Text) * Convert.ToInt32(tbPieces.Text); }
                if (String.Equals(cbCinsi.Text, "€"))
                { lvE = Convert.ToInt32(tcPrices.Text) * Convert.ToInt32(tbPieces.Text); }

                baglanti.Open();
                String sqlNewCase = "SELECT COUNT(*) FROM customer_case CC WHERE CC.CL_ID =" + Convert.ToInt64(userid) + " AND CC.ODEMETIPI = " + "'" + cbODEMECINSI.Text + "'";
                MySqlCommand komutCase = new MySqlCommand(sqlNewCase, baglanti);
                String Case = komutCase.ExecuteScalar().ToString();
                if (Case != "0")
                {
                    
                    textt = "UPDATE customer_case SET TL = TL + " + lvT + ",EURO = EURO + " + lvE + ",DOLAR = DOLAR + " + lvD + " WHERE CL_ID = " + Convert.ToInt64(userid) +
                             " and ODEMETIPI = " + "'" + cbODEMECINSI.Text + "'";

                    string sqlUpdate = textt;

                    MySqlCommand komutUpdate = new MySqlCommand(sqlUpdate, baglanti);

                    komutUpdate.ExecuteNonQuery();//

                    baglanti.Close();

                }
                else
                {
                    
                    textt = "INSERT INTO CUSTOMER_CASE (CL_ID, TL,DOLAR, EURO, ODEMETIPI) VALUES (" + Convert.ToInt64(userid) +
                             "," + lvT + " ," + lvD + " ," + lvE + " ," + "'" + cbODEMECINSI.Text + "'" + ")";

                    string sqlCustom = textt;

                    MySqlCommand komutCustom = new MySqlCommand(sqlCustom, baglanti);

                    komutCustom.ExecuteNonQuery();//

                    baglanti.Close();
                }

                tbName.Text = " ";
                tbCode.Text = " ";
                tbPieces.Text = " ";
                tbCustomer.Text = " ";
                tbCustomerOto.Text = " ";
                tcPrices.Text = " ";
                cbCinsi.Text = " ";
                lblSave.Visible = true;

                FullCombobax();
            
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
           // String id;
            int lvD=0;int lvT=0;int lvE=0;
            //id = cbIDtutar.Text;
            if ((cbStockCode.Text == "") || (tbSalePiece.Text == "") || (tbPrice.Text == "") || (cbType.Text == "") || (cbSalePayType.Text == "") || ((tbCustumerManuel.Text == "") && (cbCustomerOto.Text == "")))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {
                lgvCustumer = "";
                if (cbCustomerOto.Text.Trim() != "")
                {
                    lgvCustumer = cbCustomerOto.Text;
                //    id = cbID.GetItemText(1).ToString();
                }
                else
                    lgvCustumer = tbCustumerManuel.Text;

                SqlClass sqlConn = new SqlClass();

               // sqlConn.AddSale(cbStockCode.Text, Convert.ToInt32(tbSalePiece.Text),
                //    Convert.ToInt32(tbPrice.Text), cbType.Text, cbSalePayType.Text, lgvCustumer);

                if (String.Equals(cbSalePayType.Text, "$"))
                 {lvD =Convert.ToInt32(tbPrice.Text);}
                if (String.Equals(cbSalePayType.Text,"TL"))
                 {lvT =Convert.ToInt32(tbPrice.Text);}
                if (String.Equals(cbSalePayType.Text,"€"))
                 {lvE =Convert.ToInt32(tbPrice.Text);}
                       
                
                String bag;
                String textt, textinsert;
                //MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                //build.Server = "localhost";
                //build.UserID = "root";
                //build.Password = "12345678";
                //build.Database = "case_follow";
                //build.Port = 3306;


                //bag = build.ToString();
                //baglanti = new MySqlConnection(bag);

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 


               /* String sql3 = "SELECT cl.TL FROM customer_list cl WHERE CL.ID=" + id ;
                String sql4 = "SELECT cl.DOLAR FROM customer_list cl WHERE CL.ID=" + id;
                String sql5 = "SELECT cl.EURO FROM customer_list cl WHERE CL.ID= " + id;
                MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
                String SonucTL = komut3.ExecuteScalar().ToString();
                MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
                String SonucDOLAR = komut4.ExecuteScalar().ToString();
                MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
                String SonucEURO = komut5.ExecuteScalar().ToString();
                komut3.ExecuteNonQuery();//
                lvT = (lvT * Convert.ToInt32(tbSalePiece.Text)) + Convert.ToInt32(SonucTL);
                lvE = (lvE * Convert.ToInt32(tbSalePiece.Text))  + Convert.ToInt32(SonucEURO);
                lvD = (lvD * Convert.ToInt32(tbSalePiece.Text)) + Convert.ToInt32(SonucDOLAR);*/
                
                
              //  textt = "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(id);

               // string sql2 = textt;

               // MySqlCommand komut2 = new MySqlCommand(sql2, baglanti);

                //komut2.ExecuteNonQuery();//

                // "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(id);//
             
               textinsert = "INSERT INTO daily_sale_case(CL_ID, SL_ID, TL, DOLAR, EURO, PIECES, ODEMETIPI) VALUES (" + Convert.ToInt32(userid) + ","+ Convert.ToInt32(stocklist_id) +
                            "," + lvT + " ," + lvD + " ," + lvE + " ," + Convert.ToInt32(tbSalePiece.Text) + " ," + "'" + cbType.Text + "'" + ")";
                string sqlinsert = textinsert;

                MySqlCommand komutinsert = new MySqlCommand(sqlinsert, baglanti);

                komutinsert.ExecuteNonQuery();
                
                baglanti.Close();


                if (String.Equals(cbSalePayType.Text, "$"))
                { lvD = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbSalePiece.Text); }
                if (String.Equals(cbSalePayType.Text, "TL"))
                { lvT = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbSalePiece.Text); }
                if (String.Equals(cbSalePayType.Text, "€"))
                { lvE = Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbSalePiece.Text); }

                baglanti.Open();
                String sqlNewCase = "SELECT COUNT(*) FROM customer_case CC WHERE CC.CL_ID =" + Convert.ToInt64(userid) + " AND CC.ODEMETIPI = " + "'" + cbType.Text + "'";
                MySqlCommand komutCase = new MySqlCommand(sqlNewCase, baglanti);
                String Case = komutCase.ExecuteScalar().ToString();
                if (Case != "0")
                {

                    textt = "UPDATE customer_case SET TL = TL + " + lvT + ",EURO = EURO + " + lvE + ",DOLAR = DOLAR + " + lvD + " WHERE CL_ID = " + Convert.ToInt64(userid) + " and ODEMETIPI = " + "'" + cbType.Text + "'";

                    string sqlUpdate = textt;

                    MySqlCommand komutUpdate = new MySqlCommand(sqlUpdate, baglanti);

                    komutUpdate.ExecuteNonQuery();//

                    baglanti.Close();

                }
                else
                {

                    textt = "INSERT INTO CUSTOMER_CASE (CL_ID, TL,DOLAR, EURO, ODEMETIPI) VALUES (" + Convert.ToInt64(userid) +
                             "," + lvT + " ," + lvD + " ," + lvE + " ," + "'" + cbType.Text + "'" + ")";

                    string sqlCustom = textt;

                    MySqlCommand komutCustom = new MySqlCommand(sqlCustom, baglanti);

                    komutCustom.ExecuteNonQuery();//

                    baglanti.Close();
                }




           
                cbStockCode.Text = " ";
                tbSalePiece.Text = " ";
                tbPrice.Text = " ";
                cbType.Text = " ";
                cbCinsi.Text = " ";
                tbCustumerManuel.Text = " ";
                cbCustomerOto.Text = " ";

                lblSave2.Visible = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
           // String id;
            int lvD = 0; int lvT = 0; int lvE = 0;
           // id = cbIDtutar1.Text;
            if ((tbPricePay.Text == "") || (cb2Cinsi.Text == "") || (cb2Type.Text == "") || ((cbGivePay.Checked == false) && (cbTakePay.Checked == false)) || ((cbCustumerOto2.Text == "") && (tbCustumerManuel2.Text == "")))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {
                if (cbTakePay.Checked == true)
                    PaymentType = cbTakePay.Text;
                else if (cbGivePay.Checked == true)
                    PaymentType = cbGivePay.Text;
                lgvCustumer = "";
                if (cbCustumerOto2.Text.Trim() != "")
                {   
                    lgvCustumer = cbCustumerOto2.Text;
                }
                else
                    lgvCustumer = tbCustumerManuel2.Text;

                //SqlClass sqlConn = new SqlClass();
                //sqlConn.AddPayment(PaymentType, Convert.ToInt32(tbPricePay.Text), cb2Cinsi.Text, cb2Type.Text, lgvCustumer);//


                ////
                if (cb2Cinsi.Text.Trim() == "$")//if (String.Equals(cb2Cinsi.Text, "$"))
                { lvD = Convert.ToInt32(tbPricePay.Text); }
                if (cb2Cinsi.Text.Trim() == "TL")
                { lvT = Convert.ToInt32(tbPricePay.Text); }
                if (cb2Cinsi.Text.Trim() == "€")
                { lvE = Convert.ToInt32(tbPricePay.Text); }


                String bag;
                String textt, textinsert2;
                //MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                //build.Server = "localhost";
                //build.UserID = "root";
                //build.Password = "12345678";
                //build.Database = "case_follow";
                //build.Port = 3306;


                //bag = build.ToString();
                //baglanti = new MySqlConnection(bag);

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 

                /*
                String sql3 = "SELECT cl.TL FROM customer_list cl WHERE CL.ID=" + userid;
                String sql4 = "SELECT cl.DOLAR FROM customer_list cl WHERE CL.ID=" + userid;
                String sql5 = "SELECT cl.EURO FROM customer_list cl WHERE CL.ID= " + userid;
                MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
                String SonucTL = komut3.ExecuteScalar().ToString();
                MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
                String SonucDOLAR = komut4.ExecuteScalar().ToString();
                MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
                String SonucEURO = komut5.ExecuteScalar().ToString();
                komut3.ExecuteNonQuery();//
                if (cbTakePay.Checked)
                {
                    lvT = lvT + Convert.ToInt32(SonucTL);
                    lvE = lvE + Convert.ToInt32(SonucEURO);
                    lvD = lvD + Convert.ToInt32(SonucDOLAR);
                }
                else
                {
                    lvT = lvT - Convert.ToInt32(SonucTL);
                    lvE = lvE - Convert.ToInt32(SonucEURO);
                    lvD = lvD - Convert.ToInt32(SonucDOLAR);
                }

                textt = "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(userid);

                string sql2 = textt;

                MySqlCommand komut2 = new MySqlCommand(sql2, baglanti);

                komut2.ExecuteNonQuery();//
                */

                string sql = "INSERT INTO payments (PAY_TYPE, PAY_CARNEL, TL, EURO, DOLAR, CL_ID, CUSTOMER) VALUES ('" + PaymentType + "','" +
                          cb2Type.Text + "','" + lvT + "','" + lvE + "','" + lvD + "','" + Convert.ToInt64(userid) + "','" + lgvCustumer + "')";
               // textinsert2 = textt = "INSERT INTO payments_case(CL_ID, TL, DOLAR, EURO, ODEMETIPI ) VALUES (" + Convert.ToInt32(userid) + "," + lvT + " ," + lvD + " ," + lvE + " ," + "'" + cbType.Text + "'" + ")";
                string sqlinsert2 = sql;

                MySqlCommand komutinsert2 = new MySqlCommand(sqlinsert2, baglanti);

                komutinsert2.ExecuteNonQuery();//
                

                baglanti.Close();

                if (String.Equals(cb2Cinsi.Text, "$"))
                { lvD = Convert.ToInt32(tbPricePay.Text); }
                if (String.Equals(cb2Cinsi.Text, "TL"))
                { lvT = Convert.ToInt32(tbPricePay.Text); }
                if (String.Equals(cb2Cinsi.Text, "€"))
                { lvE = Convert.ToInt32(tbPricePay.Text); }

                if (cbTakePay.Checked)
                {
                    lvT = lvT *1;
                    lvE = lvE *1;
                    lvD = lvD *1;
                }
                else
                {
                    lvT = lvT * -1;
                    lvE = lvE * -1;
                    lvD = lvD * -1;
                }


                baglanti.Open();
                String sqlNewCase = "SELECT COUNT(*) FROM customer_case CC WHERE CC.CL_ID =" + Convert.ToInt64(userid) + " AND CC.ODEMETIPI = " + "'" + cb2Type.Text + "'";
                MySqlCommand komutCase = new MySqlCommand(sqlNewCase, baglanti);
                String Case = komutCase.ExecuteScalar().ToString();
                if (Case != "0")
                {

                    textt = "UPDATE customer_case SET TL = TL + " + lvT + ",EURO = EURO + " + lvE + ",DOLAR = DOLAR + " + lvD + " WHERE CL_ID = " + Convert.ToInt64(userid) +
                        " and ODEMETIPI = " + "'" + cb2Type.Text + "'";

                    string sqlUpdate = textt;

                    MySqlCommand komutUpdate = new MySqlCommand(sqlUpdate, baglanti);

                    komutUpdate.ExecuteNonQuery();//

                    baglanti.Close();

                }
                else
                {

                    textt = "INSERT INTO CUSTOMER_CASE (CL_ID, TL,DOLAR, EURO, ODEMETIPI) VALUES (" + Convert.ToInt64(userid) +
                             "," + lvT + " ," + lvD + " ," + lvE + " ," + "'" + cb2Type.Text + "'" + ")";

                    string sqlCustom = textt;

                    MySqlCommand komutCustom = new MySqlCommand(sqlCustom, baglanti);

                    komutCustom.ExecuteNonQuery();//

                    baglanti.Close();
                }



                cbGivePay.Checked = false;
                cbTakePay.Checked = false;
                tbPricePay.Text = " ";
                cb2Cinsi.Text = " ";
                cb2Type.Text = " ";
                cbCustumerOto2.Text = " ";
                tbCustumerManuel2.Text = " ";



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
            

        }

        private void tbPricePay_TextChanged(object sender, EventArgs e)
        {
            lblSave3.Visible = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           
            FullCombobax();
        }
        public void FullCombobax()
        {//customer_list
            //
            String bag;
       //     MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            DataSet dSet = new DataSet();


            //build.Server = "localhost";
            //build.UserID = "root";
            //build.Password = "12345678";
            //build.Database = "case_follow";
            //build.Port = 3306;
            //

            DataGridView stock_list = new DataGridView();
            stock_list.Name = "stock_list";
            DataGridView customer_list = new DataGridView();
            customer_list.Name = "customer_list";
            SqlClass sqlCon = new SqlClass();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql2 = "SELECT CONCAT(SL.NAME, ' (', SL.CODE,')') AS NAME, SL.* FROM stock_list SL ";
            //if (DataGridList.Name == "dtgridSalesList")
              //  sql = sql + " ORDER BY  SALE_CODE";
            DataTable dtable2 = new DataTable();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand();

            


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            command2.CommandText = sql2;
            command2.Connection = baglanti;
            adapter2.SelectCommand = command2;

            baglanti.Open();
            adapter2.Fill(dtable2);
            adapter2.Fill(dSet);
            stock_list.DataSource = dtable2;
            baglanti.Close();

            //foreach (DataRow dr in dSet.Tables[0].Rows)
            //{
            //    tbSalePiece.Text = dr[0].ToString() + " " + dr[1].ToString();
            //}
            
           // sqlCon.ListData(stock_list, DateTime.Now, DateTime.Now);
           //cbStockCode.DataSource = stock_list.DataSource;
           //cbStockCode.DisplayMember = "NAME";
           //cbStockCode.DisplayMember = cbStockCode.DisplayMember;

            
            String sql = "SELECT CONCAT(NAME, ' ', SURNAME) AS NAME, ID FROM customer_list ";
            DataTable dtable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;
            dSet.Clear();
            baglanti.Open();
            adapter.Fill(dtable);
            adapter.Fill(dSet);
            customer_list.DataSource = dtable;
            baglanti.Close();
            //cbCustumerOto2.DataSource = customer_list.DataSource;
            //cbCustumerOto2.DisplayMember = "NAME";
            //cbIDtutar1.DataSource = customer_list.DataSource;
            //cbIDtutar1.DisplayMember = "ID";
          //  sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);

            String sql3 = "SELECT CONCAT(NAME, ' ', SURNAME) AS NAME, ID FROM customer_list ";
            DataTable dtable3 = new DataTable();

            MySqlDataAdapter adapter3 = new MySqlDataAdapter();
            MySqlCommand command3 = new MySqlCommand();

            command3.CommandText = sql3;
            command3.Connection = baglanti;
            adapter3.SelectCommand = command3;
            dSet.Clear();
            baglanti.Open();
            adapter3.Fill(dtable3);
            adapter3.Fill(dSet);
            customer_list.DataSource = dtable3;
            baglanti.Close();
            //cbCustomerOto212.DataSource = customer_list.DataSource;
            //cbCustomerOto212.DisplayMember = "NAME"; //
         
//            cbIDtutar.DataSource = customer_list.DataSource;
  //          cbIDtutar.DisplayMember = "ID";


            String sql4 = "SELECT CONCAT(NAME, ' ', SURNAME) AS NAME, ID FROM customer_list ";
            DataTable dtable4 = new DataTable();

            MySqlDataAdapter adapter4 = new MySqlDataAdapter();
            MySqlCommand command4 = new MySqlCommand();

            command4.CommandText = sql4;
            command4.Connection = baglanti;
            adapter4.SelectCommand = command4;
            dSet.Clear();
            baglanti.Open();
            adapter4.Fill(dtable4);
            adapter4.Fill(dSet);
            customer_list.DataSource = dtable4;
            baglanti.Close();
            //tbCustomerOto2.DataSource = customer_list.DataSource;
            //tbCustomerOto2.DisplayMember = "NAME"; //

            //cbIDCustom.DataSource = customer_list.DataSource;
            //cbIDCustom.DisplayMember = "ID";

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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void tbSalePiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbPricePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // SqlClass sqlCon = new SqlClass();
            //frmSalesList frmSList = new frmSalesList();
            //sqlCon.ListData(frmSList.lgvdtgridSalesList, DateTime.Now, DateTime.Now);
            //frmStockList frmSList = new frmStockList();
            //sqlCon.ListData(frmSList.lgvdtgridStockList, DateTime.Now, DateTime.Now);
            frmGrid grid = new frmGrid();
          /*
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
            baglanti.Close();*/
            //textBoxNTL.Text = SonucTL;
            //textBoxNDOLAR.Text = SonucDOLAR;
            //textBoxNEURO.Text = SonucEURO;
            //textBoxKKTL.Text = SonucKKTL;
            //textBoxKKDOLAR.Text = SonucKKDOLAR;
            //textBoxKKEURO.Text = SonucKKEURO;
            //textBoxVTL.Text = SonucVTL;
            //textBoxVDOLAR.Text = SonucVDOLAR;
            //textBoxVEURO.Text = SonucVEURO;

            String sql = "SELECT sl.NAME  FROM stock_list  sl"; //, sl.PIECE, sl.PRICE, sl.ODEMECINSI, sl.CUSTOMER

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            grid.lgvgriddata.DataSource = dt;

          //  adapter.Fill(ds, "customer_list");

            //customer_list.DataSource = ds.Tables[0];// dt;
            baglanti.Close();
            
            /////////////////////
    
            
            string dosyakayityolu;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               dosyakayityolu =  saveFileDialog1.FileName.ToString() + ".pdf";
               int strsayisi = grid.lgvgriddata.Columns.Count;
               
            iTextSharp.text.Document raporum = new iTextSharp.text.Document();

            raporum.AddCreationDate();
            raporum.AddAuthor("ae-robotic");//yazar
            raporum.AddHeader("Başlık", "Pdf uygulaması oluştur");
            raporum.AddTitle("Test pdf");
                
           

            PdfWriter.GetInstance(raporum, new FileStream(dosyakayityolu, FileMode.OpenOrCreate));

            PdfPTable table = new PdfPTable(5);
            PdfPTable table2 = new PdfPTable(4);
            PdfPTable table3 = new PdfPTable(2);
            PdfPTable table4 = new PdfPTable(4);
            PdfPTable table5 = new PdfPTable(4);
            PdfPTable table6 = new PdfPTable(4);
            #region  font ayarları
            //BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            table.HorizontalAlignment = 1;
            table.PaddingTop = 10f;
            table.WidthPercentage = 100;
            table2.HorizontalAlignment = 2;
            table2.PaddingTop = 5f;

            table3.HorizontalAlignment = 0;
            table3.PaddingTop = 10f;
            table3.WidthPercentage = 100;
          

            table4.HorizontalAlignment = 2;
            table4.PaddingTop = 5f;
            table5.HorizontalAlignment = 2;
            table5.PaddingTop = 5f;
            table6.HorizontalAlignment = 1;
            table6.PaddingTop = 5f;
            table6.WidthPercentage = 100;

            BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\Corbel.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            // en ust reklam yazı ADEM OLGUNER
            iTextSharp.text.Font font = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD); 
            // tablonun içeriğinin oldugu yermakalenin özellikleri  ve detaylar
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(arial, 8, iTextSharp.text.Font.NORMAL); 
            // tablo baslıkları hangi alanlar   baslik makaleid gibi a
            iTextSharp.text.Font font3 = new iTextSharp.text.Font(arial, 10, iTextSharp.text.Font.NORMAL,BaseColor.WHITE);
            iTextSharp.text.Font font4 = new iTextSharp.text.Font(arial, 8, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font5 = new iTextSharp.text.Font(arial, 8, iTextSharp.text.Font.NORMAL); 

            #endregion
            #region tablo ana başlık firma adı
            string frmadi = "STOK KAYDI";
            PdfPCell cell = new PdfPCell(new Phrase(frmadi, font));
            cell.Colspan = 7;
            cell.PaddingBottom = 7f;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
          //  cell.BackgroundColor = BaseColor.RED;
            table.AddCell(cell);
            #endregion
            #region tablo başlıkları için
          
            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cell2 = new PdfPCell(new Phrase("ÜRÜN ADI", font3));
            PdfPCell cell3 = new PdfPCell(new Phrase("ADET", font3));
            PdfPCell cell4 = new PdfPCell(new Phrase("TL", font3));
            PdfPCell cell5 = new PdfPCell(new Phrase("$", font3));
            PdfPCell cell6 = new PdfPCell(new Phrase("€", font3));
            //PdfPCell cell7 = new PdfPCell(new Phrase("TUTAR", font3));
            //PdfPCell cell8 = new PdfPCell(new Phrase("Tarih", font3));
          //  cell1.Colspan = 1;
          //  cell1.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
          //  cell1.BackgroundColor = BaseColor.YELLOW;
            cell2.Colspan = 1;
            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell2.BackgroundColor = BaseColor.BLUE;
            cell3.Colspan = 1;
            cell3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell3.BackgroundColor = BaseColor.BLUE;
            cell4.Colspan = 1;
            cell4.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell4.BackgroundColor = BaseColor.BLUE;
            cell5.Colspan = 1;
            cell5.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell5.BackgroundColor = BaseColor.BLUE;
            cell6.Colspan = 1;
            cell6.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell6.BackgroundColor = BaseColor.BLUE;
            //cell7.Colspan = 1;
            //cell7.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cell7.BackgroundColor = BaseColor.BLUE;
            //cell8.Colspan = 1;
            //cell8.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cell8.BackgroundColor = BaseColor.BLUE;
             
            cell4.BorderWidthLeft = 0f;          
               
           // table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);
            table.AddCell(cell4);
            table.AddCell(cell5);
            table.AddCell(cell6);
            //table.AddCell(cell7);
            //table.AddCell(cell8);
     
            #endregion

            
            #region tablo2 ana başlık kasa adı
            string PdfAdi = "KASA DEVİR";
            PdfPCell cellT2 = new PdfPCell(new Phrase(PdfAdi, font));
            cellT2.Colspan =4;
            cellT2.PaddingBottom = 5f;
            cellT2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cell2.BorderColor = BaseColor.BLUE;
           // cellT2.AddElement(table);
             
            table2.AddCell(cellT2);
            #endregion

            #region tablo3 ana başlık kasa adı
            string PdfAdi3 = DateTime.Now.ToLongDateString(); //"KASA DEVİR";
            PdfPCell cellT3 = new PdfPCell(new Phrase(PdfAdi3, font));
            cellT3.Colspan = 2;
            cellT3.PaddingBottom = 5f;
            cellT3.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cell3.BorderColor = BaseColor.BLUE;
          //  cellT3.AddElement(table);

            cellT3.Border = 0;
            cellT3.BorderWidth = 0;


            table3.AddCell(cellT3);
          #endregion
            #region tablo4 ana başlık kasa adı
            string PdfAdi4 = "VERESİYE SATIŞLAR";
            PdfPCell cellT4 = new PdfPCell(new Phrase(PdfAdi4, font));
            cellT4.Colspan = 4;
            cellT4.PaddingBottom = 5f;
            cellT4.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cell4.BorderColor = BaseColor.BLUE;
            //  cellT3.AddElement(table);

            table4.AddCell(cellT4);
            #endregion

            #region tablo5 ana başlık kasa adı
            string PdfAdi5 = "VERESİYE TAHSİLATLAR";
            PdfPCell cellT5 = new PdfPCell(new Phrase(PdfAdi5, font));
            cellT5.Colspan = 4;
            cellT5.PaddingBottom = 5f;
            cellT5.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cell5.BorderColor = BaseColor.BLUE;
            //  cellT3.AddElement(table);

            table5.AddCell(cellT5);
            #endregion

            #region tablo6 ana başlık kasa adı
            string PdfAdi6 = "GİDERLER";
            PdfPCell cellT6 = new PdfPCell(new Phrase(PdfAdi6, font));
            cellT6.Colspan = 4;
            cellT6.PaddingBottom = 5f;
            cellT6.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cellT6.BorderColor = BaseColor.BLUE;
            //  cellT3.AddElement(table);

            table6.AddCell(cellT6);
            #endregion


            #region tablo başlıkları için  

            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cellT11 = new PdfPCell(new Phrase("Genel", font3));
            PdfPCell cellT21 = new PdfPCell(new Phrase("TL", font3));
            PdfPCell cellT22 = new PdfPCell(new Phrase("$", font3));
            PdfPCell cellT23 = new PdfPCell(new Phrase("€", font3));
          
            //  cell1.Colspan = 1;
            //  cell1.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //  cell1.BackgroundColor = BaseColor.YELLOW;
            cellT11.Colspan = 1;
            cellT11.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT11.BackgroundColor = BaseColor.BLUE;
            cellT21.Colspan = 1;
            cellT21.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT21.BackgroundColor = BaseColor.BLUE;
            cellT22.Colspan = 1;
            cellT22.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT22.BackgroundColor = BaseColor.BLUE;
            cellT23.Colspan = 1;
            cellT23.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT23.BackgroundColor = BaseColor.BLUE;

            

            table2.AddCell(cellT11);
            table2.AddCell(cellT21);
            table2.AddCell(cellT22);
            table2.AddCell(cellT23);

            #endregion


            #region tablo başlıkları için

            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cellT31 = new PdfPCell(new Phrase("Genel", font3));
            PdfPCell cellT32 = new PdfPCell(new Phrase("TL", font3));

            cellT31.Colspan =1;
            cellT31.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT31.BackgroundColor = BaseColor.BLUE;
             

            cellT32.Colspan = 9;
            cellT32.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT32.BackgroundColor = BaseColor.BLUE;

            table3.AddCell(cellT31);
            table3.AddCell(cellT32);

            #endregion

            #region tablo başlıkları için

            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cellT41 = new PdfPCell(new Phrase("ÜRÜN ADI", font4));
            PdfPCell cellT42 = new PdfPCell(new Phrase("TL", font4));
            PdfPCell cellT43 = new PdfPCell(new Phrase("$", font4));
            PdfPCell cellT44 = new PdfPCell(new Phrase("€", font4));

            cellT41.Colspan = 1;
            cellT41.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT41.BackgroundColor = BaseColor.BLUE;
            cellT42.Colspan = 1;
            cellT42.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT42.BackgroundColor = BaseColor.BLUE;
            cellT43.Colspan = 1;
            cellT43.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT43.BackgroundColor = BaseColor.BLUE;
            cellT44.Colspan = 1;
            cellT44.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT44.BackgroundColor = BaseColor.BLUE;

            table4.AddCell(cellT41);
            table4.AddCell(cellT42);
            table4.AddCell(cellT43);
            table4.AddCell(cellT44);

            #endregion

            #region tablo başlıkları için

            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cellT51 = new PdfPCell(new Phrase("ÜRÜN ADI", font5));
            PdfPCell cellT52 = new PdfPCell(new Phrase("TL", font5));
            PdfPCell cellT53 = new PdfPCell(new Phrase("$", font5));
            PdfPCell cellT54 = new PdfPCell(new Phrase("€", font5));

            cellT51.Colspan = 1;
            cellT51.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT51.BackgroundColor = BaseColor.BLUE;
            cellT52.Colspan = 1;
            cellT52.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT52.BackgroundColor = BaseColor.BLUE;
            cellT53.Colspan = 1;
            cellT53.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT53.BackgroundColor = BaseColor.BLUE;
            cellT54.Colspan = 1;
            cellT54.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT54.BackgroundColor = BaseColor.BLUE;

            table5.AddCell(cellT51);
            table5.AddCell(cellT52);
            table5.AddCell(cellT53);
            table5.AddCell(cellT54);

            #endregion
            #region tablo başlıkları için

            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cellT61 = new PdfPCell(new Phrase("ÜRÜN ADI", font5));
            PdfPCell cellT62 = new PdfPCell(new Phrase("TL", font5));
            PdfPCell cellT63 = new PdfPCell(new Phrase("$", font5));
            PdfPCell cellT64 = new PdfPCell(new Phrase("€", font5));

            cellT61.Colspan = 1;
            cellT61.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT61.BackgroundColor = BaseColor.BLUE;
            cellT62.Colspan = 1;
            cellT62.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT62.BackgroundColor = BaseColor.BLUE;
            cellT63.Colspan = 1;
            cellT63.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT63.BackgroundColor = BaseColor.BLUE;
            cellT64.Colspan = 1;
            cellT64.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellT64.BackgroundColor = BaseColor.BLUE;

            table6.AddCell(cellT61);
            table6.AddCell(cellT62);
            table6.AddCell(cellT63);
            table6.AddCell(cellT64);

            #endregion


            if (raporum.IsOpen() == false)
            { raporum.Open(); }

            Paragraph eklenecekmetin = new Paragraph("paragraf");
          //  raporum.AddHeader("HEADER",null);

 
           //raporum.Add(eklenecekmetin);

            int SatirNumarası = 0;
            int SutunNumarası = 0;
            string yazi;

            foreach (DataGridViewRow Satir in grid.lgvgriddata.Rows)
            {
                
                SutunNumarası = 0;
                foreach (DataGridViewColumn Sutun in grid.lgvgriddata.Columns)
                {
                    
                    if (SutunNumarası < strsayisi)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if (grid.lgvgriddata.Rows[SatirNumarası].Cells[SutunNumarası].Value == null)
                            yazi = " ";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        table.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                        //table.AddCell(table2);

                    }
                    SutunNumarası = SutunNumarası + 1;
                }
            //    if (SatirNumarası == 4)
            //        SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;
                  
            }
                /////////////////

            String sql2 = "SELECT sl.NAME FROM  stock_list sl ";
            //  "SELECT sl.NAME, ds.PIECES, ds.ODEMECINSI, ds.PRICE FROM daily_sale ds JOIN stock_list sl on sl.CODE = ds.SALE_CODE where ds.PAY_CARNEL = 'Veresiye'";

            dt.Clear();
            command.CommandText = sql2;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            grid.lgvgriddata.DataSource = dt;

            //VERESİYE SATIS TABLOSU DOLDUR
            baglanti.Close();
            int strsayisi2 = grid.lgvgriddata.Columns.Count;

            /////////////////////

            SatirNumarası = 0;
            foreach (DataGridViewRow Satir in grid.lgvgriddata.Rows)
            {

                SutunNumarası = 0;
                foreach (DataGridViewColumn Sutun in grid.lgvgriddata.Columns)
                {

                    if (SutunNumarası < strsayisi2)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if (grid.lgvgriddata.Rows[SatirNumarası].Cells[SutunNumarası].Value == null)
                            yazi = " ";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        table4.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                        //table.AddCell(table2);

                    }
                    SutunNumarası = SutunNumarası + 1;
                }
                //    if (SatirNumarası == 4)
                //        SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;

            }


            SatirNumarası = 0;
            foreach (DataGridViewRow Satir in grid.lgvgriddata.Rows)
            {

                SutunNumarası = 0;
                foreach (DataGridViewColumn Sutun in grid.lgvgriddata.Columns)
                {

                    if (SutunNumarası < strsayisi2)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if (grid.lgvgriddata.Rows[SatirNumarası].Cells[SutunNumarası].Value == null)
                            yazi = " ";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        table5.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                        //table.AddCell(table2);

                    }
                    SutunNumarası = SutunNumarası + 1;
                }
                //    if (SatirNumarası == 4)
                //        SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;

            }
            
            SatirNumarası = 0;
            for (int i = 1; i < 4;i++ )
            {

                SutunNumarası = 0;
                for (int k = 1; k < 10;k++ )
                {
                    SutunNumarası = SutunNumarası + 1;
                    if (SutunNumarası < 12)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if ((SatirNumarası == 0) && (SutunNumarası == 1))
                            yazi = "Günlüş Satış";
                        else if ((SatirNumarası == 1)&&(SutunNumarası ==1))
                            yazi = "Veresiye Tahsilat";
                        else if ((SatirNumarası == 2) && (SutunNumarası == 1))
                            yazi = "Kaparo";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Convert.ToString(SutunNumarası);//Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                       
                        table2.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                    }


                }
                if (SatirNumarası == 5)
                    SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;

            }
                ////
            SatirNumarası = 0;
            for (int i = 1; i < 3; i++)
            {

                SutunNumarası = 0;
                for (int k = 1; k < 3; k++)
                {
                    SutunNumarası = SutunNumarası + 1;
                    if (SutunNumarası < 8)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if ((SatirNumarası == 0) && (SutunNumarası == 1))
                            table3.AddCell(table2);// yazi = "Günlüş Satış";
                        else if ((SatirNumarası == 0) && (SutunNumarası == 2))
                            table3.AddCell(table2);//  yazi = "Veresiye Tahsilat";
                        else if ((SatirNumarası == 1) && (SutunNumarası == 1))
                        {
                            table3.AddCell(table4);
                        }
                        else if ((SatirNumarası == 1) && (SutunNumarası == 2))     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            table3.AddCell(table5); //    yazi = Convert.ToString(SutunNumarası);//Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        else if ((SatirNumarası == 2) && (SutunNumarası == 2))    //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            table3.AddCell(table);
                        else table3.AddCell(table);
                      //  table3.AddCell(table2);
                       // table3.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                    }


                }
                //if (SatirNumarası == 3)
                //    SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;

            }

//////////
            SatirNumarası = 0;
            foreach (DataGridViewRow Satir in grid.lgvgriddata.Rows)
            {

                SutunNumarası = 0;
                foreach (DataGridViewColumn Sutun in grid.lgvgriddata.Columns)
                {

                    if (SutunNumarası < strsayisi2)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if (grid.lgvgriddata.Rows[SatirNumarası].Cells[SutunNumarası].Value == null)
                            yazi = " ";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        table6.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                        //table.AddCell(table2);

                    }
                    SutunNumarası = SutunNumarası + 1;
                }
                //    if (SatirNumarası == 4)
                //        SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;

            }


            //table2.DeleteRow(1);

            
            raporum.Add(table3);
            raporum.Add(table6);
            raporum.Add(table);
            //raporum.Add(table2);
            //raporum.Add(table);
            
            raporum.Close();
            MessageBox.Show("Fatura pdf i oluşturuldu");
            }
            else
            { MessageBox.Show("Lütfen kayıt yolu secin"); }
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddPerson frmPerson = new AddPerson();
            frmPerson.Show();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tcPrices_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            //float num = float.Parse(textBox1.Text);
          //  string stringValue = num.ToString().Replace(',', '.');
        }

        private void tbCustumerManuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void tbCustumerManuel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCusumerCase frmCase = new frmCusumerCase();
            frmCase.Show();
        }

        private void tbCustumerManuel_TextChanged(object sender, EventArgs e)
        {
            if (tbCustumerManuel.Text.Trim() != "")
            {
                cbCustomerOto.Enabled = false;
            }
            else cbCustomerOto.Enabled = true;
        }

        private void tbCustumerManuel2_TextChanged(object sender, EventArgs e)
        {
            if (tbCustumerManuel2.Text.Trim() != "")
            {
                cbCustumerOto2.Enabled = false;
            }
            else cbCustumerOto2.Enabled = true;
        }

        private void cbCustomerOto_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbCustumerOto2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTakePay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTakePay.Checked == true)
            {
                cbGivePay.Checked = false;
                cbGivePay.Enabled = false;
            }
            else cbGivePay.Enabled = true;
        }

        private void cbGivePay_CheckedChanged(object sender, EventArgs e)
        {

            if (cbGivePay.Checked == true)
            {
                cbTakePay.Checked = false;
                cbTakePay.Enabled = false;
            }
            else cbTakePay.Enabled = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomer.Text.Trim() != "")
            {
                tbCustomerOto.Enabled = false;
            }
            else tbCustomerOto.Enabled = true;
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            stocklist_id = "0";
            frmListe frmListe = new frmListe();
            if (frmListe.ShowDialog() == DialogResult.OK)
            {
                cbStockCode.Text = frmListe.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " ( "+ frmListe.dtgrdList.CurrentRow.Cells["CODE"].Value.ToString() + " )";    //tbName.Text;
                stocklist_id = frmListe.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
          
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lblSave2.Visible = false;
        }

        private void buttonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            userid = "0";
            frmKisiListesi kl = new frmKisiListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                cbCustomerOto.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " " + kl.dtgrdList.CurrentRow.Cells["SURNAME"].Value.ToString();    //tbName.Text;
                userid = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void cbCustomerOto_TextChanged_1(object sender, EventArgs e)
        {

            if (cbCustomerOto.Text.Trim() != "")
            {
                tbCustumerManuel.Enabled = false;
            }
            else tbCustumerManuel.Enabled = true;

        }

        private void buttonEdit1_ButtonClick_2(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            userid = "0";
            frmKisiListesi kl = new frmKisiListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                tbCustomerOto.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " " + kl.dtgrdList.CurrentRow.Cells["SURNAME"].Value.ToString();    //tbName.Text;
                userid = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void buttonEdit1_TextChanged(object sender, EventArgs e)
        {

            if (tbCustomerOto.Text.Trim() != "")
            {
                tbCustomer.Enabled = false;
            }
            else tbCustomer.Enabled = true;
        }

        private void cbCustumerOto2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            userid = "0";
            frmKisiListesi kl = new frmKisiListesi();
            if (kl.ShowDialog() == DialogResult.OK)
            {
                cbCustumerOto2.Text = kl.dtgrdList.CurrentRow.Cells["NAME"].Value.ToString() + " " + kl.dtgrdList.CurrentRow.Cells["SURNAME"].Value.ToString();    //tbName.Text;
                userid = kl.dtgrdList.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void cbCustumerOto2_TextChanged_1(object sender, EventArgs e)
        {
            if (cbCustumerOto2.Text.Trim() != "")
            {
                tbCustumerManuel2.Enabled = false;
            }
            else tbCustumerManuel2.Enabled = true;
        }

        private void cbCustumerOto2_BindingContextChanged(object sender, EventArgs e)
        {

        }


    }
}
