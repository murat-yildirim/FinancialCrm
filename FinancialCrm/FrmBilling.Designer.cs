namespace FinancialCrm
{
    partial class FrmBilling
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.mskBillPayDay = new System.Windows.Forms.MaskedTextBox();
			this.btnStatuUpdate = new System.Windows.Forms.Button();
			this.cmbBillStatus = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnBillList = new System.Windows.Forms.Button();
			this.btnCreateBill = new System.Windows.Forms.Button();
			this.btnUpdateBill = new System.Windows.Forms.Button();
			this.btnRemoveBill = new System.Windows.Forms.Button();
			this.txtBillPeriod = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBillAmount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBillTitle = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBillNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(1, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 504);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, -40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(953, 41);
			this.panel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Banka Formu";
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button8.Location = new System.Drawing.Point(58, 401);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(143, 39);
			this.button8.TabIndex = 7;
			this.button8.Text = "Çıkış Yap";
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.Location = new System.Drawing.Point(58, 345);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(143, 39);
			this.button7.TabIndex = 6;
			this.button7.Text = "Ayarlar";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(58, 291);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(143, 39);
			this.button6.TabIndex = 5;
			this.button6.Text = "Dashboard";
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.Location = new System.Drawing.Point(58, 236);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(143, 39);
			this.button5.TabIndex = 4;
			this.button5.Text = "Banka Hareketleri";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.Location = new System.Drawing.Point(58, 181);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 39);
			this.button4.TabIndex = 3;
			this.button4.Text = "Giderler";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(58, 127);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 39);
			this.button3.TabIndex = 2;
			this.button3.Text = "Faturalar";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnBanksForm
			// 
			this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanksForm.Location = new System.Drawing.Point(58, 72);
			this.btnBanksForm.Name = "btnBanksForm";
			this.btnBanksForm.Size = new System.Drawing.Size(143, 39);
			this.btnBanksForm.TabIndex = 1;
			this.btnBanksForm.Text = "Bankalar";
			this.btnBanksForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBanksForm.UseVisualStyleBackColor = true;
			this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(58, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Kategoriler";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1152, 41);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Faturalar";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.mskBillPayDay);
			this.panel4.Controls.Add(this.btnStatuUpdate);
			this.panel4.Controls.Add(this.cmbBillStatus);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.btnBillList);
			this.panel4.Controls.Add(this.btnCreateBill);
			this.panel4.Controls.Add(this.btnUpdateBill);
			this.panel4.Controls.Add(this.btnRemoveBill);
			this.panel4.Controls.Add(this.txtBillPeriod);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.txtBillAmount);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.txtBillTitle);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txtBillNumber);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Location = new System.Drawing.Point(207, 47);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(944, 199);
			this.panel4.TabIndex = 3;
			// 
			// mskBillPayDay
			// 
			this.mskBillPayDay.Enabled = false;
			this.mskBillPayDay.Font = new System.Drawing.Font("Calibri", 12F);
			this.mskBillPayDay.Location = new System.Drawing.Point(687, 60);
			this.mskBillPayDay.Mask = "00/00/0000";
			this.mskBillPayDay.Name = "mskBillPayDay";
			this.mskBillPayDay.Size = new System.Drawing.Size(245, 27);
			this.mskBillPayDay.TabIndex = 20;
			this.mskBillPayDay.ValidatingType = typeof(System.DateTime);
			// 
			// btnStatuUpdate
			// 
			this.btnStatuUpdate.Enabled = false;
			this.btnStatuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatuUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStatuUpdate.Location = new System.Drawing.Point(745, 101);
			this.btnStatuUpdate.Name = "btnStatuUpdate";
			this.btnStatuUpdate.Size = new System.Drawing.Size(132, 58);
			this.btnStatuUpdate.TabIndex = 15;
			this.btnStatuUpdate.Text = "Ödeme Durumu Ekle - Güncelle";
			this.btnStatuUpdate.UseVisualStyleBackColor = true;
			this.btnStatuUpdate.Click += new System.EventHandler(this.button2_Click);
			// 
			// cmbBillStatus
			// 
			this.cmbBillStatus.Enabled = false;
			this.cmbBillStatus.Font = new System.Drawing.Font("Calibri", 12F);
			this.cmbBillStatus.FormattingEnabled = true;
			this.cmbBillStatus.Items.AddRange(new object[] {
            "Ödendi",
            "Ödenmedi"});
			this.cmbBillStatus.Location = new System.Drawing.Point(687, 20);
			this.cmbBillStatus.Name = "cmbBillStatus";
			this.cmbBillStatus.Size = new System.Drawing.Size(245, 27);
			this.cmbBillStatus.TabIndex = 19;
			this.cmbBillStatus.Text = "Ödeme Durumu Seçiniz";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(566, 23);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(115, 19);
			this.label10.TabIndex = 18;
			this.label10.Text = "Ödeme Durumu:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(581, 63);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 19);
			this.label9.TabIndex = 16;
			this.label9.Text = "Ödeme Tarihi:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 13);
			this.label8.TabIndex = 14;
			this.label8.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Fatura İşlemleri",
            "Ödeme İşlemleri"});
			this.comboBox1.Location = new System.Drawing.Point(109, 17);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(245, 27);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.Text = "Yapacağınız İşlemi Seçiniz";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(8, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "İşlem Tercihi:";
			// 
			// btnBillList
			// 
			this.btnBillList.Enabled = false;
			this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillList.Location = new System.Drawing.Point(407, 101);
			this.btnBillList.Name = "btnBillList";
			this.btnBillList.Size = new System.Drawing.Size(131, 39);
			this.btnBillList.TabIndex = 8;
			this.btnBillList.Text = "Fatura Listele";
			this.btnBillList.UseVisualStyleBackColor = true;
			this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
			// 
			// btnCreateBill
			// 
			this.btnCreateBill.Enabled = false;
			this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateBill.Location = new System.Drawing.Point(407, 10);
			this.btnCreateBill.Name = "btnCreateBill";
			this.btnCreateBill.Size = new System.Drawing.Size(131, 39);
			this.btnCreateBill.TabIndex = 9;
			this.btnCreateBill.Text = "Fatura Ekle";
			this.btnCreateBill.UseVisualStyleBackColor = true;
			this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
			// 
			// btnUpdateBill
			// 
			this.btnUpdateBill.Enabled = false;
			this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateBill.Location = new System.Drawing.Point(407, 56);
			this.btnUpdateBill.Name = "btnUpdateBill";
			this.btnUpdateBill.Size = new System.Drawing.Size(131, 39);
			this.btnUpdateBill.TabIndex = 11;
			this.btnUpdateBill.Text = "Fatura Güncelle";
			this.btnUpdateBill.UseVisualStyleBackColor = true;
			this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
			// 
			// btnRemoveBill
			// 
			this.btnRemoveBill.Enabled = false;
			this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRemoveBill.Location = new System.Drawing.Point(407, 146);
			this.btnRemoveBill.Name = "btnRemoveBill";
			this.btnRemoveBill.Size = new System.Drawing.Size(131, 39);
			this.btnRemoveBill.TabIndex = 10;
			this.btnRemoveBill.Text = "Fatura Sil";
			this.btnRemoveBill.UseVisualStyleBackColor = true;
			this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
			// 
			// txtBillPeriod
			// 
			this.txtBillPeriod.Enabled = false;
			this.txtBillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillPeriod.Location = new System.Drawing.Point(109, 152);
			this.txtBillPeriod.Name = "txtBillPeriod";
			this.txtBillPeriod.Size = new System.Drawing.Size(245, 27);
			this.txtBillPeriod.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(44, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 19);
			this.label6.TabIndex = 6;
			this.label6.Text = "Periyot:";
			// 
			// txtBillAmount
			// 
			this.txtBillAmount.Enabled = false;
			this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillAmount.Location = new System.Drawing.Point(109, 119);
			this.txtBillAmount.Name = "txtBillAmount";
			this.txtBillAmount.Size = new System.Drawing.Size(245, 27);
			this.txtBillAmount.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(47, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Miktar:";
			// 
			// txtBillTitle
			// 
			this.txtBillTitle.Enabled = false;
			this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillTitle.Location = new System.Drawing.Point(109, 86);
			this.txtBillTitle.Name = "txtBillTitle";
			this.txtBillTitle.Size = new System.Drawing.Size(245, 27);
			this.txtBillTitle.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(51, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Başlık:";
			// 
			// txtBillNumber
			// 
			this.txtBillNumber.Enabled = false;
			this.txtBillNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBillNumber.Location = new System.Drawing.Point(109, 53);
			this.txtBillNumber.Name = "txtBillNumber";
			this.txtBillNumber.Size = new System.Drawing.Size(245, 27);
			this.txtBillNumber.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(26, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Fatura No:";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dataGridView1);
			this.panel5.Location = new System.Drawing.Point(208, 252);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(944, 291);
			this.panel5.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(944, 291);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// FrmBilling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 544);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmBilling";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ödeme & Fatura Formu";
			this.Load += new System.EventHandler(this.FrmBilling_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnStatuUpdate;
		private System.Windows.Forms.ComboBox cmbBillStatus;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox mskBillPayDay;
	}
}