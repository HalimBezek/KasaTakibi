namespace WindowsFormsApplication12
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcPrices = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbPieces = new System.Windows.Forms.TextBox();
            this.cbCinsi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCustomerOto = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCustumerManuel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSalePayType = new System.Windows.Forms.ComboBox();
            this.lblSave2 = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbSalePiece = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStockCode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCustumerOto2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCustumerManuel2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSave3 = new System.Windows.Forms.Label();
            this.cbTakePay = new System.Windows.Forms.CheckBox();
            this.cbGivePay = new System.Windows.Forms.CheckBox();
            this.cb2Type = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.tbPricePay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb2Cinsi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.tcPrices);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSave);
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.tbPieces);
            this.groupBox1.Controls.Add(this.cbCinsi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCustomer);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STOK KAYIT";
            // 
            // tcPrices
            // 
            this.tcPrices.Location = new System.Drawing.Point(664, 56);
            this.tcPrices.Name = "tcPrices";
            this.tcPrices.Size = new System.Drawing.Size(59, 20);
            this.tcPrices.TabIndex = 7;
            this.tcPrices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcPrices_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CİNSİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ÜRÜN FİYATI";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(886, 37);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(64, 13);
            this.lblSave.TabIndex = 5;
            this.lblSave.Text = "Kayıt Yapıldı";
            this.lblSave.Visible = false;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStock.Location = new System.Drawing.Point(883, 53);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 36);
            this.btnAddStock.TabIndex = 4;
            this.btnAddStock.Text = "KAYDET";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPieces
            // 
            this.tbPieces.Location = new System.Drawing.Point(797, 56);
            this.tbPieces.Name = "tbPieces";
            this.tbPieces.Size = new System.Drawing.Size(59, 20);
            this.tbPieces.TabIndex = 3;
            this.tbPieces.TextChanged += new System.EventHandler(this.tbPieces_TextChanged);
            this.tbPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPieces_KeyPress_1);
            // 
            // cbCinsi
            // 
            this.cbCinsi.FormattingEnabled = true;
            this.cbCinsi.Items.AddRange(new object[] {
            "TL",
            "$",
            "#"});
            this.cbCinsi.Location = new System.Drawing.Point(742, 55);
            this.cbCinsi.Name = "cbCinsi";
            this.cbCinsi.Size = new System.Drawing.Size(43, 21);
            this.cbCinsi.TabIndex = 2;
            this.cbCinsi.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(799, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ADET";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(257, 56);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(185, 20);
            this.tbCode.TabIndex = 3;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÜRÜN KODU";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(470, 56);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(185, 20);
            this.tbCustomer.TabIndex = 3;
            this.tbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomer_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "ÜRÜN ALINAN FİRMA/KİŞİ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(39, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 20);
            this.tbName.TabIndex = 3;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ÜRÜN ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbCustomerOto);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbCustumerManuel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbSalePayType);
            this.groupBox2.Controls.Add(this.lblSave2);
            this.groupBox2.Controls.Add(this.btnAddSale);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.tbSalePiece);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbStockCode);
            this.groupBox2.Location = new System.Drawing.Point(19, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNLÜK SATIŞ";
            // 
            // cbCustomerOto
            // 
            this.cbCustomerOto.FormattingEnabled = true;
            this.cbCustomerOto.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cbCustomerOto.Location = new System.Drawing.Point(732, 56);
            this.cbCustomerOto.Name = "cbCustomerOto";
            this.cbCustomerOto.Size = new System.Drawing.Size(107, 21);
            this.cbCustomerOto.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(729, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "ALICI SEÇ";
            // 
            // tbCustumerManuel
            // 
            this.tbCustumerManuel.Location = new System.Drawing.Point(585, 57);
            this.tbCustumerManuel.Name = "tbCustumerManuel";
            this.tbCustumerManuel.Size = new System.Drawing.Size(126, 20);
            this.tbCustumerManuel.TabIndex = 10;
            this.tbCustumerManuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustumerManuel_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(583, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "ALICI EKLE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "CİNSİ";
            // 
            // cbSalePayType
            // 
            this.cbSalePayType.FormattingEnabled = true;
            this.cbSalePayType.Items.AddRange(new object[] {
            "TL",
            "$",
            "#"});
            this.cbSalePayType.Location = new System.Drawing.Point(273, 56);
            this.cbSalePayType.Name = "cbSalePayType";
            this.cbSalePayType.Size = new System.Drawing.Size(43, 21);
            this.cbSalePayType.TabIndex = 7;
            // 
            // lblSave2
            // 
            this.lblSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave2.AutoSize = true;
            this.lblSave2.Location = new System.Drawing.Point(880, 29);
            this.lblSave2.Name = "lblSave2";
            this.lblSave2.Size = new System.Drawing.Size(64, 13);
            this.lblSave2.TabIndex = 6;
            this.lblSave2.Text = "Kayıt Yapıldı";
            this.lblSave2.Visible = false;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSale.Location = new System.Drawing.Point(882, 45);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 33);
            this.btnAddSale.TabIndex = 4;
            this.btnAddSale.Text = "KAYDET";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(193, 57);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(74, 20);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbSalePiece
            // 
            this.tbSalePiece.Location = new System.Drawing.Point(361, 58);
            this.tbSalePiece.Name = "tbSalePiece";
            this.tbSalePiece.Size = new System.Drawing.Size(71, 20);
            this.tbSalePiece.TabIndex = 3;
            this.tbSalePiece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalePiece_KeyPress);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cbType.Location = new System.Drawing.Point(470, 56);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(79, 21);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FİYATI ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ÖDEME TİPİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SATIŞ ADEDİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SATILAN ÜRÜN KODU";
            // 
            // cbStockCode
            // 
            this.cbStockCode.FormatString = "N2";
            this.cbStockCode.FormattingEnabled = true;
            this.cbStockCode.Location = new System.Drawing.Point(39, 56);
            this.cbStockCode.Name = "cbStockCode";
            this.cbStockCode.Size = new System.Drawing.Size(121, 21);
            this.cbStockCode.TabIndex = 0;
            this.cbStockCode.SelectedIndexChanged += new System.EventHandler(this.cbStockCode_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbCustumerOto2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tbCustumerManuel2);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblSave3);
            this.groupBox3.Controls.Add(this.cbTakePay);
            this.groupBox3.Controls.Add(this.cbGivePay);
            this.groupBox3.Controls.Add(this.cb2Type);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnAddPayment);
            this.groupBox3.Controls.Add(this.tbPricePay);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cb2Cinsi);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(19, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÖDEMELER";
            // 
            // cbCustumerOto2
            // 
            this.cbCustumerOto2.FormattingEnabled = true;
            this.cbCustumerOto2.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cbCustumerOto2.Location = new System.Drawing.Point(640, 50);
            this.cbCustumerOto2.Name = "cbCustumerOto2";
            this.cbCustumerOto2.Size = new System.Drawing.Size(117, 21);
            this.cbCustumerOto2.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(637, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "ALICI SEÇ";
            // 
            // tbCustumerManuel2
            // 
            this.tbCustumerManuel2.Location = new System.Drawing.Point(474, 52);
            this.tbCustumerManuel2.Name = "tbCustumerManuel2";
            this.tbCustumerManuel2.Size = new System.Drawing.Size(126, 20);
            this.tbCustumerManuel2.TabIndex = 12;
            this.tbCustumerManuel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustumerManuel2_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(472, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "ALICI EKLE";
            // 
            // lblSave3
            // 
            this.lblSave3.AutoSize = true;
            this.lblSave3.Location = new System.Drawing.Point(886, 28);
            this.lblSave3.Name = "lblSave3";
            this.lblSave3.Size = new System.Drawing.Size(64, 13);
            this.lblSave3.TabIndex = 9;
            this.lblSave3.Text = "Kayıt Yapıldı";
            this.lblSave3.Visible = false;
            // 
            // cbTakePay
            // 
            this.cbTakePay.AutoSize = true;
            this.cbTakePay.Location = new System.Drawing.Point(43, 23);
            this.cbTakePay.Name = "cbTakePay";
            this.cbTakePay.Size = new System.Drawing.Size(107, 17);
            this.cbTakePay.TabIndex = 8;
            this.cbTakePay.Text = "ALINAN ÖDEME";
            this.cbTakePay.UseVisualStyleBackColor = true;
            // 
            // cbGivePay
            // 
            this.cbGivePay.AutoSize = true;
            this.cbGivePay.Location = new System.Drawing.Point(43, 54);
            this.cbGivePay.Name = "cbGivePay";
            this.cbGivePay.Size = new System.Drawing.Size(113, 17);
            this.cbGivePay.TabIndex = 7;
            this.cbGivePay.Text = "YAPILAN ÖDEME";
            this.cbGivePay.UseVisualStyleBackColor = true;
            // 
            // cb2Type
            // 
            this.cb2Type.FormattingEnabled = true;
            this.cb2Type.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cb2Type.Location = new System.Drawing.Point(363, 52);
            this.cb2Type.Name = "cb2Type";
            this.cb2Type.Size = new System.Drawing.Size(79, 21);
            this.cb2Type.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ÖDEME TİPİ";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayment.Location = new System.Drawing.Point(887, 42);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 38);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "KAYDET";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // tbPricePay
            // 
            this.tbPricePay.Location = new System.Drawing.Point(192, 52);
            this.tbPricePay.Name = "tbPricePay";
            this.tbPricePay.Size = new System.Drawing.Size(74, 20);
            this.tbPricePay.TabIndex = 3;
            this.tbPricePay.TextChanged += new System.EventHandler(this.tbPricePay_TextChanged);
            this.tbPricePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricePay_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "CİNSİ";
            // 
            // cb2Cinsi
            // 
            this.cb2Cinsi.FormattingEnabled = true;
            this.cb2Cinsi.Items.AddRange(new object[] {
            "TL",
            "$",
            "#"});
            this.cb2Cinsi.Location = new System.Drawing.Point(272, 51);
            this.cb2Cinsi.Name = "cb2Cinsi";
            this.cb2Cinsi.Size = new System.Drawing.Size(43, 21);
            this.cb2Cinsi.TabIndex = 2;
            this.cb2Cinsi.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "FIYATI";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(902, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(19, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 48);
            this.button5.TabIndex = 6;
            this.button5.Text = "Ödeme Listesi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(122, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 48);
            this.button6.TabIndex = 7;
            this.button6.Text = "Satış Listesi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(225, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 48);
            this.button7.TabIndex = 8;
            this.button7.Text = "Stok Listesi";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(790, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(331, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kişi Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(995, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStockCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSalePiece;
        private System.Windows.Forms.ComboBox cbCinsi;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox tbPieces;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox tbPricePay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb2Cinsi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cb2Type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox cbTakePay;
        private System.Windows.Forms.CheckBox cbGivePay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblSave2;
        private System.Windows.Forms.Label lblSave3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tcPrices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCustomerOto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCustumerManuel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSalePayType;
        private System.Windows.Forms.ComboBox cbCustumerOto2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCustumerManuel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
    }
}

