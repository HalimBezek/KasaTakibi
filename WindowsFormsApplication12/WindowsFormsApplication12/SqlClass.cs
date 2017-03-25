using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public class SqlClass
    {
        MySqlConnection baglanti;
        String DataListesi;
        public void ConnectSql()
        {

            String bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();

            build.UserID = "root";
            build.Password = "12345678";
            build.Database = "case_follow";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

        }

        public void ListData(DataGridView DataGridList)
        {
            if (DataGridList.Name == "dtgridSalesList")
                DataListesi = "daily_sale";
            else if (DataGridList.Name == "dtgrdStockList")
                DataListesi = "stock_list";
            else if (DataGridList.Name == "dtgridPaymentList")
                DataListesi = "payments";
            else DataListesi = "stock_list";

            ConnectSql();
            String sql = "SELECT * FROM " + DataListesi;
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            baglanti.Open();
            adapter.Fill(dt);
            DataGridList.DataSource = dt;
            baglanti.Close();


        }

        public void AddStock(String Name, String Code, int Pieces,String Customer,String BRAND)
        {
            ConnectSql();
            baglanti.Open();//	ID	NAME STOK ADI	CODE STOK KODU	PIECE KAÇ ADET	CUSTOMER KIM ALDI	BRAND URUN MARKASI

            string sql = "INSERT INTO stock_list (NAME, CODE, PIECE, CUSTOMER, BRAND) VALUES ('" + Name + "','" + Code +
                                               "','" + Pieces + "','" + Customer + "','" + BRAND + "')";


            MySqlCommand komut = new MySqlCommand(sql, baglanti);


            komut.ExecuteNonQuery(); 
            baglanti.Close();


        }
        //cbStockCode.Text, Convert.ToInt32(tbSalePiece.Text), Convert.ToInt32(tbPrice.Text), Convert.ToInt32(cbType.Text), cbCinsi.Text
        public void AddSale(String StockCode, int SalePiece, int Price, String Type, String Cinsi)
        {
            ConnectSql();
            baglanti.Open();//	ID	SALE_CODE SATILAN URUN KODU	PRICE FIYATI	PAY_CARNEL ODEME TIPI	ODEMECINSI PIECES 

            string sql = "INSERT INTO daily_sale (SALE_CODE, PRICE, PAY_CARNEL, ODEMECINSI, PIECES) VALUES ('" + StockCode + "','" + Price +
                                               "','" + Type + "','" + Cinsi + "','" + SalePiece + "')";


            MySqlCommand komut = new MySqlCommand(sql, baglanti);


            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        public void AddPayment( String PaymentType, int PricePay, String Cinsi, String Type)
        {
            ConnectSql();
            baglanti.Open();//ID	PAY_TYPE 1:ALINAN 2:YAPILAN ODEMELER	PAY_PRICE	PAY_CARNEL ODEME TIPI	ODEMECINSI ODEME CINSI 

            string sql = "INSERT INTO payments (PAY_TYPE, PAY_PRICE, PAY_CARNEL, ODEMECINSI) VALUES ('" + PaymentType + "','" + PricePay +
                                               "','" + Type + "','" + Cinsi + "')";


            MySqlCommand komut = new MySqlCommand(sql, baglanti);


            komut.ExecuteNonQuery();
            baglanti.Close();


        }

    }
}
