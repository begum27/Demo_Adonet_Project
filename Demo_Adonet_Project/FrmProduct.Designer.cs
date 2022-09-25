namespace Demo_Adonet_Project
{
    partial class FrmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UrunID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_SearchForProductName = new System.Windows.Forms.Button();
            this.btn_SearchForStockLess = new System.Windows.Forms.Button();
            this.btn_SearchForStockMore = new System.Windows.Forms.Button();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_StokSayisi = new System.Windows.Forms.TextBox();
            this.txt_Alıs = new System.Windows.Forms.TextBox();
            this.txt_Satıs = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun ID";
            // 
            // txt_UrunID
            // 
            this.txt_UrunID.Location = new System.Drawing.Point(145, 64);
            this.txt_UrunID.Name = "txt_UrunID";
            this.txt_UrunID.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durum";
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(282, 61);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(121, 23);
            this.btn_List.TabIndex = 8;
            this.btn_List.Text = "UrunListesi";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(282, 109);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Urunu Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(282, 149);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(121, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Urunu Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(282, 192);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Urunu Duzenle";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_SearchForProductName
            // 
            this.btn_SearchForProductName.Location = new System.Drawing.Point(282, 239);
            this.btn_SearchForProductName.Name = "btn_SearchForProductName";
            this.btn_SearchForProductName.Size = new System.Drawing.Size(121, 23);
            this.btn_SearchForProductName.TabIndex = 12;
            this.btn_SearchForProductName.Text = "Ara: Urun Adı";
            this.btn_SearchForProductName.UseVisualStyleBackColor = true;
            // 
            // btn_SearchForStockLess
            // 
            this.btn_SearchForStockLess.Location = new System.Drawing.Point(282, 285);
            this.btn_SearchForStockLess.Name = "btn_SearchForStockLess";
            this.btn_SearchForStockLess.Size = new System.Drawing.Size(121, 23);
            this.btn_SearchForStockLess.TabIndex = 13;
            this.btn_SearchForStockLess.Text = "Ara: Stok <";
            this.btn_SearchForStockLess.UseVisualStyleBackColor = true;
            // 
            // btn_SearchForStockMore
            // 
            this.btn_SearchForStockMore.Location = new System.Drawing.Point(282, 330);
            this.btn_SearchForStockMore.Name = "btn_SearchForStockMore";
            this.btn_SearchForStockMore.Size = new System.Drawing.Size(121, 23);
            this.btn_SearchForStockMore.TabIndex = 14;
            this.btn_SearchForStockMore.Text = "Ara: Stok >";
            this.btn_SearchForStockMore.UseVisualStyleBackColor = true;
            // 
            // datagridview1
            // 
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Location = new System.Drawing.Point(437, 21);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.Size = new System.Drawing.Size(905, 357);
            this.datagridview1.TabIndex = 15;
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(145, 119);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_UrunAdi.TabIndex = 16;
            // 
            // txt_StokSayisi
            // 
            this.txt_StokSayisi.Location = new System.Drawing.Point(145, 154);
            this.txt_StokSayisi.Name = "txt_StokSayisi";
            this.txt_StokSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_StokSayisi.TabIndex = 17;
            // 
            // txt_Alıs
            // 
            this.txt_Alıs.Location = new System.Drawing.Point(145, 195);
            this.txt_Alıs.Name = "txt_Alıs";
            this.txt_Alıs.Size = new System.Drawing.Size(100, 20);
            this.txt_Alıs.TabIndex = 18;
            // 
            // txt_Satıs
            // 
            this.txt_Satıs.Location = new System.Drawing.Point(145, 228);
            this.txt_Satıs.Name = "txt_Satıs";
            this.txt_Satıs.Size = new System.Drawing.Size(100, 20);
            this.txt_Satıs.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(145, 295);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(46, 17);
            this.rdbActive.TabIndex = 23;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Aktif";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Location = new System.Drawing.Point(197, 295);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(48, 17);
            this.rdbPassive.TabIndex = 24;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "Pasif";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 640);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Satıs);
            this.Controls.Add(this.txt_Alıs);
            this.Controls.Add(this.txt_StokSayisi);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.btn_SearchForStockMore);
            this.Controls.Add(this.btn_SearchForStockLess);
            this.Controls.Add(this.btn_SearchForProductName);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UrunID);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "Urun Formu";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UrunID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_SearchForProductName;
        private System.Windows.Forms.Button btn_SearchForStockLess;
        private System.Windows.Forms.Button btn_SearchForStockMore;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_StokSayisi;
        private System.Windows.Forms.TextBox txt_Alıs;
        private System.Windows.Forms.TextBox txt_Satıs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPassive;
    }
}