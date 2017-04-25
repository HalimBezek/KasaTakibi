namespace WindowsFormsApplication12
{
    partial class frmCusumerCase
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
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxNEURO = new System.Windows.Forms.TextBox();
            this.textBoxNDOLAR = new System.Windows.Forms.TextBox();
            this.textBoxNTL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_list = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Nakit = new System.Windows.Forms.Label();
            this.textBoxKKEURO = new System.Windows.Forms.TextBox();
            this.textBoxKKDOLAR = new System.Windows.Forms.TextBox();
            this.textBoxKKTL = new System.Windows.Forms.TextBox();
            this.textBoxVEURO = new System.Windows.Forms.TextBox();
            this.textBoxVDOLAR = new System.Windows.Forms.TextBox();
            this.textBoxVTL = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(479, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 43);
            this.button5.TabIndex = 2;
            this.button5.Text = "Kapat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.textBoxVEURO);
            this.panel7.Controls.Add(this.textBoxVDOLAR);
            this.panel7.Controls.Add(this.textBoxVTL);
            this.panel7.Controls.Add(this.textBoxKKEURO);
            this.panel7.Controls.Add(this.textBoxKKDOLAR);
            this.panel7.Controls.Add(this.textBoxKKTL);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.Nakit);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.textBoxNEURO);
            this.panel7.Controls.Add(this.textBoxNDOLAR);
            this.panel7.Controls.Add(this.textBoxNTL);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 283);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(560, 135);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // textBoxNEURO
            // 
            this.textBoxNEURO.Location = new System.Drawing.Point(296, 46);
            this.textBoxNEURO.Name = "textBoxNEURO";
            this.textBoxNEURO.Size = new System.Drawing.Size(55, 20);
            this.textBoxNEURO.TabIndex = 14;
            // 
            // textBoxNDOLAR
            // 
            this.textBoxNDOLAR.Location = new System.Drawing.Point(189, 46);
            this.textBoxNDOLAR.Name = "textBoxNDOLAR";
            this.textBoxNDOLAR.Size = new System.Drawing.Size(59, 20);
            this.textBoxNDOLAR.TabIndex = 13;
            // 
            // textBoxNTL
            // 
            this.textBoxNTL.Location = new System.Drawing.Point(86, 46);
            this.textBoxNTL.Name = "textBoxNTL";
            this.textBoxNTL.Size = new System.Drawing.Size(58, 20);
            this.textBoxNTL.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "€ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "$ : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customer_list);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 283);
            this.panel1.TabIndex = 4;
            // 
            // customer_list
            // 
            this.customer_list.AllowUserToOrderColumns = true;
            this.customer_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_list.BackgroundColor = System.Drawing.Color.White;
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customer_list.Location = new System.Drawing.Point(0, 46);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(560, 237);
            this.customer_list.TabIndex = 12;
            this.customer_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_CellContentClick);
            this.customer_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_CellEndEdit);
            this.customer_list.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_RowEnter);
            this.customer_list.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.customer_list_RowStateChanged);
            this.customer_list.CausesValidationChanged += new System.EventHandler(this.customer_list_CausesValidationChanged);
            this.customer_list.CursorChanged += new System.EventHandler(this.customer_list_CursorChanged);
            this.customer_list.TabIndexChanged += new System.EventHandler(this.customer_list_TabIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 46);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Kasası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "TL :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 21;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "TOPLAM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Genel Kasa ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Kredi Kartı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Veresiye :";
            // 
            // Nakit
            // 
            this.Nakit.AutoSize = true;
            this.Nakit.Location = new System.Drawing.Point(3, 53);
            this.Nakit.Name = "Nakit";
            this.Nakit.Size = new System.Drawing.Size(38, 13);
            this.Nakit.TabIndex = 22;
            this.Nakit.Text = "Nakit :";
            // 
            // textBoxKKEURO
            // 
            this.textBoxKKEURO.Location = new System.Drawing.Point(296, 72);
            this.textBoxKKEURO.Name = "textBoxKKEURO";
            this.textBoxKKEURO.Size = new System.Drawing.Size(55, 20);
            this.textBoxKKEURO.TabIndex = 26;
            // 
            // textBoxKKDOLAR
            // 
            this.textBoxKKDOLAR.Location = new System.Drawing.Point(189, 72);
            this.textBoxKKDOLAR.Name = "textBoxKKDOLAR";
            this.textBoxKKDOLAR.Size = new System.Drawing.Size(59, 20);
            this.textBoxKKDOLAR.TabIndex = 25;
            // 
            // textBoxKKTL
            // 
            this.textBoxKKTL.Location = new System.Drawing.Point(86, 72);
            this.textBoxKKTL.Name = "textBoxKKTL";
            this.textBoxKKTL.Size = new System.Drawing.Size(58, 20);
            this.textBoxKKTL.TabIndex = 24;
            // 
            // textBoxVEURO
            // 
            this.textBoxVEURO.Location = new System.Drawing.Point(296, 99);
            this.textBoxVEURO.Name = "textBoxVEURO";
            this.textBoxVEURO.Size = new System.Drawing.Size(55, 20);
            this.textBoxVEURO.TabIndex = 29;
            // 
            // textBoxVDOLAR
            // 
            this.textBoxVDOLAR.Location = new System.Drawing.Point(189, 99);
            this.textBoxVDOLAR.Name = "textBoxVDOLAR";
            this.textBoxVDOLAR.Size = new System.Drawing.Size(59, 20);
            this.textBoxVDOLAR.TabIndex = 28;
            // 
            // textBoxVTL
            // 
            this.textBoxVTL.Location = new System.Drawing.Point(86, 99);
            this.textBoxVTL.Name = "textBoxVTL";
            this.textBoxVTL.Size = new System.Drawing.Size(58, 20);
            this.textBoxVTL.TabIndex = 27;
            // 
            // frmCusumerCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(560, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "frmCusumerCase";
            this.Text = "Müşteri Kasası";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCusumerCase_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView customer_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNEURO;
        private System.Windows.Forms.TextBox textBoxNDOLAR;
        private System.Windows.Forms.TextBox textBoxNTL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVEURO;
        private System.Windows.Forms.TextBox textBoxVDOLAR;
        private System.Windows.Forms.TextBox textBoxVTL;
        private System.Windows.Forms.TextBox textBoxKKEURO;
        private System.Windows.Forms.TextBox textBoxKKDOLAR;
        private System.Windows.Forms.TextBox textBoxKKTL;
        private System.Windows.Forms.Label Nakit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;



    }
}