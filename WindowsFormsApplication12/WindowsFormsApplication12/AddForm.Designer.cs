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
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tcPrices = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
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
            this.cbIDtutar = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.cbIDtutar1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Olive;
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.tcPrices);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSave);
            this.groupBox1.Controls.Add(this.tbPieces);
            this.groupBox1.Controls.Add(this.cbCinsi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCustomer);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STOK KAYIT";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStock.Location = new System.Drawing.Point(883, 40);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(79, 36);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "KAYDET";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tcPrices
            // 
            this.tcPrices.Location = new System.Drawing.Point(733, 56);
            this.tcPrices.Name = "tcPrices";
            this.tcPrices.Size = new System.Drawing.Size(89, 20);
            this.tcPrices.TabIndex = 5;
            this.tcPrices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcPrices_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CİNSİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "FİYATI";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(882, 19);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(77, 13);
            this.lblSave.TabIndex = 5;
            this.lblSave.Text = "Kayıt Yapıldı";
            this.lblSave.Visible = false;
            // 
            // tbPieces
            // 
            this.tbPieces.Location = new System.Drawing.Point(571, 56);
            this.tbPieces.Name = "tbPieces";
            this.tbPieces.Size = new System.Drawing.Size(136, 20);
            this.tbPieces.TabIndex = 4;
            this.tbPieces.TextChanged += new System.EventHandler(this.tbPieces_TextChanged);
            this.tbPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPieces_KeyPress_1);
            // 
            // cbCinsi
            // 
            this.cbCinsi.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCinsi.DisplayMember = "1";
            this.cbCinsi.FormattingEnabled = true;
            this.cbCinsi.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.cbCinsi.Location = new System.Drawing.Point(823, 55);
            this.cbCinsi.Name = "cbCinsi";
            this.cbCinsi.Size = new System.Drawing.Size(45, 21);
            this.cbCinsi.TabIndex = 6;
            this.cbCinsi.Text = "TL";
            this.cbCinsi.ValueMember = "1";
            this.cbCinsi.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "KAÇ ADET";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(213, 56);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(157, 20);
            this.tbCode.TabIndex = 2;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÜRÜN KODU";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(388, 56);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(161, 20);
            this.tbCustomer.TabIndex = 3;
            this.tbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomer_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "ÜRÜN ALINAN FİRMA/KİŞİ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(38, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 20);
            this.tbName.TabIndex = 1;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ÜRÜN ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Olive;
            this.groupBox2.Controls.Add(this.cbIDtutar);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbStockCode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(11, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNLÜK SATIŞ";
            // 
            // cbIDtutar
            // 
            this.cbIDtutar.FormattingEnabled = true;
            this.cbIDtutar.Location = new System.Drawing.Point(725, 27);
            this.cbIDtutar.Name = "cbIDtutar";
            this.cbIDtutar.Size = new System.Drawing.Size(35, 21);
            this.cbIDtutar.TabIndex = 16;
            this.cbIDtutar.Visible = false;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Veresiye"});
            this.cbType.Location = new System.Drawing.Point(192, 56);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(161, 21);
            this.cbType.TabIndex = 15;
            this.cbType.Text = "Nakit";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ÖDEME TİPİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "KAÇ ADET";
            // 
            // cbCustomerOto
            // 
            this.cbCustomerOto.FormattingEnabled = true;
            this.cbCustomerOto.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cbCustomerOto.Location = new System.Drawing.Point(653, 55);
            this.cbCustomerOto.Name = "cbCustomerOto";
            this.cbCustomerOto.Size = new System.Drawing.Size(107, 21);
            this.cbCustomerOto.TabIndex = 12;
            this.cbCustomerOto.TextChanged += new System.EventHandler(this.cbCustomerOto_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(653, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "ALICI SEÇ";
            // 
            // tbCustumerManuel
            // 
            this.tbCustumerManuel.Location = new System.Drawing.Point(517, 56);
            this.tbCustumerManuel.Name = "tbCustumerManuel";
            this.tbCustumerManuel.Size = new System.Drawing.Size(130, 20);
            this.tbCustumerManuel.TabIndex = 10;
            this.tbCustumerManuel.TextChanged += new System.EventHandler(this.tbCustumerManuel_TextChanged);
            this.tbCustumerManuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustumerManuel_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(574, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "ALICI EKLE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(841, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "CİNSİ";
            // 
            // cbSalePayType
            // 
            this.cbSalePayType.FormattingEnabled = true;
            this.cbSalePayType.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.cbSalePayType.Location = new System.Drawing.Point(842, 56);
            this.cbSalePayType.Name = "cbSalePayType";
            this.cbSalePayType.Size = new System.Drawing.Size(45, 21);
            this.cbSalePayType.TabIndex = 7;
            this.cbSalePayType.Text = "TL";
            // 
            // lblSave2
            // 
            this.lblSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave2.AutoSize = true;
            this.lblSave2.Location = new System.Drawing.Point(885, 30);
            this.lblSave2.Name = "lblSave2";
            this.lblSave2.Size = new System.Drawing.Size(77, 13);
            this.lblSave2.TabIndex = 6;
            this.lblSave2.Text = "Kayıt Yapıldı";
            this.lblSave2.Visible = false;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSale.Location = new System.Drawing.Point(893, 46);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 33);
            this.btnAddSale.TabIndex = 4;
            this.btnAddSale.Text = "KAYDET";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(766, 57);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(74, 20);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbSalePiece
            // 
            this.tbSalePiece.Location = new System.Drawing.Point(389, 57);
            this.tbSalePiece.Name = "tbSalePiece";
            this.tbSalePiece.Size = new System.Drawing.Size(122, 20);
            this.tbSalePiece.TabIndex = 3;
            this.tbSalePiece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalePiece_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FİYATI ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SATILAN ÜRÜN KODU";
            // 
            // cbStockCode
            // 
            this.cbStockCode.FormatString = "N2";
            this.cbStockCode.FormattingEnabled = true;
            this.cbStockCode.Location = new System.Drawing.Point(39, 56);
            this.cbStockCode.Name = "cbStockCode";
            this.cbStockCode.Size = new System.Drawing.Size(147, 21);
            this.cbStockCode.TabIndex = 0;
            this.cbStockCode.SelectedIndexChanged += new System.EventHandler(this.cbStockCode_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbIDtutar1);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(971, 86);
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
            this.cbCustumerOto2.Location = new System.Drawing.Point(332, 49);
            this.cbCustumerOto2.Name = "cbCustumerOto2";
            this.cbCustumerOto2.Size = new System.Drawing.Size(145, 21);
            this.cbCustumerOto2.TabIndex = 14;
            this.cbCustumerOto2.TextChanged += new System.EventHandler(this.cbCustumerOto2_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(338, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "ALICI SEÇ";
            // 
            // tbCustumerManuel2
            // 
            this.tbCustumerManuel2.Location = new System.Drawing.Point(175, 49);
            this.tbCustumerManuel2.Name = "tbCustumerManuel2";
            this.tbCustumerManuel2.Size = new System.Drawing.Size(151, 20);
            this.tbCustumerManuel2.TabIndex = 12;
            this.tbCustumerManuel2.TextChanged += new System.EventHandler(this.tbCustumerManuel2_TextChanged);
            this.tbCustumerManuel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustumerManuel2_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "ALICI EKLE";
            // 
            // lblSave3
            // 
            this.lblSave3.AutoSize = true;
            this.lblSave3.Location = new System.Drawing.Point(873, 28);
            this.lblSave3.Name = "lblSave3";
            this.lblSave3.Size = new System.Drawing.Size(77, 13);
            this.lblSave3.TabIndex = 9;
            this.lblSave3.Text = "Kayıt Yapıldı";
            this.lblSave3.Visible = false;
            // 
            // cbTakePay
            // 
            this.cbTakePay.AutoSize = true;
            this.cbTakePay.Location = new System.Drawing.Point(43, 23);
            this.cbTakePay.Name = "cbTakePay";
            this.cbTakePay.Size = new System.Drawing.Size(119, 17);
            this.cbTakePay.TabIndex = 8;
            this.cbTakePay.Text = "ALINAN ÖDEME";
            this.cbTakePay.UseVisualStyleBackColor = true;
            this.cbTakePay.CheckedChanged += new System.EventHandler(this.cbTakePay_CheckedChanged);
            // 
            // cbGivePay
            // 
            this.cbGivePay.AutoSize = true;
            this.cbGivePay.Location = new System.Drawing.Point(43, 54);
            this.cbGivePay.Name = "cbGivePay";
            this.cbGivePay.Size = new System.Drawing.Size(126, 17);
            this.cbGivePay.TabIndex = 7;
            this.cbGivePay.Text = "YAPILAN ÖDEME";
            this.cbGivePay.UseVisualStyleBackColor = true;
            this.cbGivePay.CheckedChanged += new System.EventHandler(this.cbGivePay_CheckedChanged);
            // 
            // cb2Type
            // 
            this.cb2Type.FormattingEnabled = true;
            this.cb2Type.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Veresiye"});
            this.cb2Type.Location = new System.Drawing.Point(515, 49);
            this.cb2Type.Name = "cb2Type";
            this.cb2Type.Size = new System.Drawing.Size(122, 21);
            this.cb2Type.TabIndex = 6;
            this.cb2Type.Text = "Nakit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ÖDEME TİPİ";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPayment.Location = new System.Drawing.Point(890, 42);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 38);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "KAYDET";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // tbPricePay
            // 
            this.tbPricePay.Location = new System.Drawing.Point(672, 51);
            this.tbPricePay.Name = "tbPricePay";
            this.tbPricePay.Size = new System.Drawing.Size(77, 20);
            this.tbPricePay.TabIndex = 3;
            this.tbPricePay.TextChanged += new System.EventHandler(this.tbPricePay_TextChanged);
            this.tbPricePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricePay_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(748, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "CİNSİ";
            // 
            // cb2Cinsi
            // 
            this.cb2Cinsi.FormattingEnabled = true;
            this.cb2Cinsi.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.cb2Cinsi.Location = new System.Drawing.Point(751, 51);
            this.cb2Cinsi.Name = "cb2Cinsi";
            this.cb2Cinsi.Size = new System.Drawing.Size(43, 21);
            this.cb2Cinsi.TabIndex = 2;
            this.cb2Cinsi.Text = "TL";
            this.cb2Cinsi.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "FIYATI";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(894, 462);
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
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(20, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "Ödemeler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(437, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Müşteri Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(331, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 48);
            this.button3.TabIndex = 11;
            this.button3.Text = "Müşteri Kasası";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SeaShell;
            this.label14.Location = new System.Drawing.Point(326, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(341, 37);
            this.label14.TabIndex = 12;
            this.label14.Text = "İyi Günlerde Kullanın ";
            // 
            // cbIDtutar1
            // 
            this.cbIDtutar1.FormattingEnabled = true;
            this.cbIDtutar1.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Vadeli",
            "Veresiye"});
            this.cbIDtutar1.Location = new System.Drawing.Point(425, 19);
            this.cbIDtutar1.Name = "cbIDtutar1";
            this.cbIDtutar1.Size = new System.Drawing.Size(50, 21);
            this.cbIDtutar1.TabIndex = 15;
            this.cbIDtutar1.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(995, 522);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button3);
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
            this.Text = "Kayıt Ekleyin";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStockCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSalePiece;
        private System.Windows.Forms.ComboBox cbCinsi;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.ComboBox cbIDtutar;
        private System.Windows.Forms.ComboBox cbIDtutar1;
    }
}

