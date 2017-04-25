﻿using System;
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
        MySqlConnection baglanti;
        
        String lgvCustumer;
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

        private void btnAddStock_Click(object sender, EventArgs e)//private void button1_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "") || (tbCode.Text == "") || (tbPieces.Text == "") || (tbCustomer.Text == "" )|| (tcPrices.Text == "") ||(cbCinsi.Text == ""))
            {
                MessageBox.Show("Boş alan brakmayınız.", "Bilgilendirme Mesajı");

            }
            else
            {

                SqlClass sqlConn = new SqlClass();

                sqlConn.AddStock(tbName.Text, tbCode.Text, Convert.ToInt32(tbPieces.Text), tbCustomer.Text, Convert.ToDouble (tcPrices.Text), cbCinsi.Text);
                tbName.Text = " ";
                tbCode.Text = " ";
                tbPieces.Text = " ";
                tbCustomer.Text = " ";
                tcPrices.Text = " ";
                cbCinsi.Text = " ";
                lblSave.Visible = true;

                FullCombobax();
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String id;
            int lvD=0;int lvT=0;int lvE=0;
            id = cbIDtutar.Text;
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

                sqlConn.AddSale(cbStockCode.Text, Convert.ToInt32(tbSalePiece.Text),
                    Convert.ToInt32(tbPrice.Text), cbType.Text, cbSalePayType.Text, lgvCustumer);

                if (String.Equals(cbSalePayType.Text, "$"))
                {lvD =Convert.ToInt32(tbPrice.Text);}
                    if (String.Equals(cbSalePayType.Text,"TL"))
                    {lvT =Convert.ToInt32(tbPrice.Text);}
                        if (String.Equals(cbSalePayType.Text,"€"))
                        {lvE =Convert.ToInt32(tbPrice.Text);}
                       
                
                String bag;
                String textt;
                MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345678";
                build.Database = "case_follow";
                build.Port = 3306;


                bag = build.ToString();
                baglanti = new MySqlConnection(bag);

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 


                String sql3 = "SELECT cl.TL FROM customer_list cl WHERE CL.ID=" + id ;
                String sql4 = "SELECT cl.DOLAR FROM customer_list cl WHERE CL.ID=" + id;
                String sql5 = "SELECT cl.EURO FROM customer_list cl WHERE CL.ID= " + id;
                MySqlCommand komut3 = new MySqlCommand(sql3, baglanti);
                String SonucTL = komut3.ExecuteScalar().ToString();
                MySqlCommand komut4 = new MySqlCommand(sql4, baglanti);
                String SonucDOLAR = komut4.ExecuteScalar().ToString();
                MySqlCommand komut5 = new MySqlCommand(sql5, baglanti);
                String SonucEURO = komut5.ExecuteScalar().ToString();
                komut3.ExecuteNonQuery();//
                lvT = lvT + Convert.ToInt32(SonucTL);
                lvE = lvE + Convert.ToInt32(SonucEURO);
                lvD = lvD + Convert.ToInt32(SonucDOLAR);
                
                
                textt = "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(id);

                string sql2 = textt;

                MySqlCommand komut2 = new MySqlCommand(sql2, baglanti);

                komut2.ExecuteNonQuery();//
                
                baglanti.Close();
           
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
            String id;
            int lvD = 0; int lvT = 0; int lvE = 0;
            id = cbIDtutar1.Text;
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

                SqlClass sqlConn = new SqlClass();
                sqlConn.AddPayment(PaymentType, Convert.ToInt32(tbPricePay.Text), cb2Cinsi.Text, cb2Type.Text, lgvCustumer);//


                ////
                if (cb2Cinsi.Text.Trim() == "$")//if (String.Equals(cb2Cinsi.Text, "$"))
                { lvD = Convert.ToInt32(tbPricePay.Text); }
                if (cb2Cinsi.Text.Trim() == "TL")
                { lvT = Convert.ToInt32(tbPricePay.Text); }
                if (cb2Cinsi.Text.Trim() == "€")
                { lvE = Convert.ToInt32(tbPricePay.Text); }


                String bag;
                String textt;
                MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

                build.Server = "localhost";
                build.UserID = "root";
                build.Password = "12345678";
                build.Database = "case_follow";
                build.Port = 3306;


                bag = build.ToString();
                baglanti = new MySqlConnection(bag);

                baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 


                String sql3 = "SELECT cl.TL FROM customer_list cl WHERE CL.ID=" + id;
                String sql4 = "SELECT cl.DOLAR FROM customer_list cl WHERE CL.ID=" + id;
                String sql5 = "SELECT cl.EURO FROM customer_list cl WHERE CL.ID= " + id;
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

                textt = "UPDATE customer_list SET TL=" + lvT + ", DOLAR=" + lvD + ", EURO=" + lvE + ", ODEMETIPI='" + cbType.Text + "'  WHERE ID =" + Convert.ToInt32(id);

                string sql2 = textt;

                MySqlCommand komut2 = new MySqlCommand(sql2, baglanti);

                komut2.ExecuteNonQuery();//

                baglanti.Close();

                ////

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
        public void FullCombobax()
        {//customer_list
            //
            String bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            DataSet dSet = new DataSet();


            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "case_follow";
            build.Port = 3306;
            //

            DataGridView stock_list = new DataGridView();
            stock_list.Name = "stock_list";
            DataGridView customer_list = new DataGridView();
            customer_list.Name = "customer_list";
            SqlClass sqlCon = new SqlClass();

            SqlClass connect = new SqlClass();
            connect.ConnectSql();
            String sql = "SELECT CONCAT(NAME, ' ', SURNAME) AS NAME, ID FROM customer_list ";
            //if (DataGridList.Name == "dtgridSalesList")
              //  sql = sql + " ORDER BY  SALE_CODE";
            DataTable dtable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            


            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dtable);
            adapter.Fill(dSet);
            customer_list.DataSource = dtable;
            baglanti.Close();

            //foreach (DataRow dr in dSet.Tables[0].Rows)
            //{
            //    tbSalePiece.Text = dr[0].ToString() + " " + dr[1].ToString();
            //}
            
            sqlCon.ListData(stock_list, DateTime.Now, DateTime.Now);
            cbStockCode.DataSource = stock_list.DataSource;
            cbStockCode.DisplayMember = "CODE";
            cbCustumerOto2.DataSource = customer_list.DataSource;
            cbCustumerOto2.DisplayMember = "NAME";
            cbIDtutar1.DataSource = customer_list.DataSource;
            cbIDtutar1.DisplayMember = "ID";
            sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);

            //sqlCon.ListData(customer_list, DateTime.Now, DateTime.Now);
            //tbCustumerManuel.Text = dt["ID"].
            cbCustomerOto.DataSource = customer_list.DataSource;
            cbCustomerOto.DisplayMember = "NAME"; //
         
            cbIDtutar.DataSource = customer_list.DataSource;
            cbIDtutar.DisplayMember = "ID";
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
            SqlClass sqlCon = new SqlClass();
            frmSalesList frmSList = new frmSalesList();
            sqlCon.ListData(frmSList.lgvdtgridSalesList, DateTime.Now, DateTime.Now);

            string dosyakayityolu;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               dosyakayityolu =  saveFileDialog1.FileName.ToString() + ".pdf";
            int strsayisi = frmSList.lgvdtgridSalesList.Columns.Count;
            iTextSharp.text.Document raporum = new iTextSharp.text.Document();

            raporum.AddCreationDate();
            raporum.AddAuthor("ae-robotic");//yazar
            raporum.AddHeader("Başlık", "Pdf uygulaması oluştur");
            raporum.AddTitle("Test pdf");
                
           

            PdfWriter.GetInstance(raporum, new FileStream(dosyakayityolu, FileMode.OpenOrCreate));

            PdfPTable table = new PdfPTable(7);
            PdfPTable table2 = new PdfPTable(4);
            #region  font ayarları
            //BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            table.HorizontalAlignment = 0;
            table.PaddingTop = 10f;
            table2.HorizontalAlignment = 2;
            table2.PaddingTop = 5f;
           // table2.DeleteBodyRows();

            BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\Corbel.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            // en ust reklam yazı ADEM OLGUNER
            iTextSharp.text.Font font = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD); 
            // tablonun içeriğinin oldugu yermakalenin özellikleri  ve detaylar
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(arial, 8, iTextSharp.text.Font.NORMAL); 
            // tablo baslıkları hangi alanlar   baslik makaleid gibi a
            iTextSharp.text.Font font3 = new iTextSharp.text.Font(arial, 10, iTextSharp.text.Font.NORMAL,BaseColor.WHITE);

            #endregion
            #region tablo ana başlık firma adı
            string frmadi = "GÜNLÜK SATIŞ";
            PdfPCell cell = new PdfPCell(new Phrase(frmadi, font));
            cell.Colspan = 7;
            cell.PaddingBottom = 7f;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
          //  cell.BackgroundColor = BaseColor.RED;
            table.AddCell(cell);
            #endregion
            #region tablo başlıkları için
          
            //PdfPCell cell1 = new PdfPCell(new Phrase("ID", font3));
            PdfPCell cell2 = new PdfPCell(new Phrase("Satış Kodu", font3));
            PdfPCell cell3 = new PdfPCell(new Phrase("Fiyat", font3));
            PdfPCell cell4 = new PdfPCell(new Phrase("Ödeme Şekli", font3));
            PdfPCell cell5 = new PdfPCell(new Phrase("Ödeme Cinsi", font3));
            PdfPCell cell6 = new PdfPCell(new Phrase("Kaç Tane", font3));
            PdfPCell cell7 = new PdfPCell(new Phrase("Müşteri", font3));
            PdfPCell cell8 = new PdfPCell(new Phrase("Tarih", font3));
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
            cell7.Colspan = 1;
            cell7.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell7.BackgroundColor = BaseColor.BLUE;
            cell8.Colspan = 1;
            cell8.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell8.BackgroundColor = BaseColor.BLUE;
            cell4.BorderWidthLeft = 0f;          
               
           // table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);
            table.AddCell(cell4);
            table.AddCell(cell5);
            table.AddCell(cell6);
            table.AddCell(cell7);
            table.AddCell(cell8);
     
            #endregion

                ////
            
            #region tablo ana başlık kasa adı
            string PdfAdi = "KASA DEVİR";
            PdfPCell cellT2 = new PdfPCell(new Phrase(PdfAdi, font));
            cellT2.Colspan = 4;
            cellT2.PaddingBottom = 5f;
            cellT2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            //cellT2.BackgroundColor = BaseColor.RED;
            cell2.BorderColor = BaseColor.BLUE;
            cellT2.AddElement(table);
             
            table2.AddCell(cellT2);
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
           // table.AddCell(cell5);


            #endregion

                ////

            if (raporum.IsOpen() == false)
            { raporum.Open(); }

            Paragraph eklenecekmetin = new Paragraph("paragraf");
           
            raporum.Add(eklenecekmetin);

            int SatirNumarası = 0;
            int SutunNumarası = 0;
            string yazi;

            foreach (DataGridViewRow Satir in frmSList.lgvdtgridSalesList.Rows)
            {
                
                SutunNumarası = 0;
                foreach (DataGridViewColumn Sutun in frmSList.lgvdtgridSalesList.Columns)
                {
                    SutunNumarası = SutunNumarası + 1;
                    if (SutunNumarası < 8)
                    {
                        //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
                        if (frmSList.lgvdtgridSalesList.Rows[SatirNumarası].Cells[SutunNumarası].Value == null)
                            yazi = " ";
                        else     //frmSList.lgvdtgridSalesList.Rows[2].Cells[3].Value.ToString();
                            yazi = Satir.DataGridView.Rows[SatirNumarası].Cells[SutunNumarası].Value.ToString();//(Satir.DataGridView.Columns[Sutun.DataGridView.Columns[Sutun.Index].Name].Name);
                        table.AddCell(new Phrase(yazi.TrimEnd('0').ToString().TrimEnd('.').ToString(), font2));
                        //table.AddCell(table2);
                    }

                   
                }
                if (SatirNumarası == 5)
                    SatirNumarası = 1;
                SatirNumarası = SatirNumarası + 1;
                  
            }
            SatirNumarası = 0;
            for (int i = 1; i < 4;i++ )
            {

                SutunNumarası = 0;
                for (int k = 1; k < 5;k++ )
                {
                    SutunNumarası = SutunNumarası + 1;
                    if (SutunNumarası < 8)
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
            //table2.DeleteRow(1);
            
            raporum.Add(table2);
            raporum.Add(table);
            
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
            if (cbCustomerOto.Text.Trim() != "")
            {
                tbCustumerManuel.Enabled = false;
            }
            else tbCustumerManuel.Enabled = true;
        }

        private void cbCustumerOto2_TextChanged(object sender, EventArgs e)
        {
            if (cbCustumerOto2.Text.Trim() != "")
            {
                tbCustumerManuel2.Enabled = false;
            }
            else tbCustumerManuel2.Enabled = true;
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

    }
}
