namespace FinancialCrm
{
	partial class FrmSpendings
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.mskSpendingDate = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCreateSpending = new System.Windows.Forms.Button();
			this.btnUpdateSpending = new System.Windows.Forms.Button();
			this.btnRemoveSpending = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSpendingAmount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSpendingTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(737, 291);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dataGridView1);
			this.panel5.Location = new System.Drawing.Point(208, 254);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(737, 291);
			this.panel5.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.mskSpendingDate);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.cmbCategory);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.btnCreateSpending);
			this.panel4.Controls.Add(this.btnUpdateSpending);
			this.panel4.Controls.Add(this.btnRemoveSpending);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.txtSpendingAmount);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txtSpendingTitle);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Location = new System.Drawing.Point(207, 49);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(738, 199);
			this.panel4.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(548, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 59);
			this.button2.TabIndex = 16;
			this.button2.Text = "Kategoriye Göre Filtrele";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// mskSpendingDate
			// 
			this.mskSpendingDate.Font = new System.Drawing.Font("Calibri", 12F);
			this.mskSpendingDate.Location = new System.Drawing.Point(118, 127);
			this.mskSpendingDate.Mask = "00/00/0000";
			this.mskSpendingDate.Name = "mskSpendingDate";
			this.mskSpendingDate.Size = new System.Drawing.Size(245, 27);
			this.mskSpendingDate.TabIndex = 15;
			this.mskSpendingDate.ValidatingType = typeof(System.DateTime);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "label8";
			this.label8.Visible = false;
			// 
			// cmbCategory
			// 
			this.cmbCategory.Font = new System.Drawing.Font("Calibri", 12F);
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(118, 25);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(245, 27);
			this.cmbCategory.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(45, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Kategori:";
			// 
			// btnCreateSpending
			// 
			this.btnCreateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateSpending.Location = new System.Drawing.Point(393, 28);
			this.btnCreateSpending.Name = "btnCreateSpending";
			this.btnCreateSpending.Size = new System.Drawing.Size(131, 39);
			this.btnCreateSpending.TabIndex = 9;
			this.btnCreateSpending.Text = "Gider Ekle";
			this.btnCreateSpending.UseVisualStyleBackColor = true;
			this.btnCreateSpending.Click += new System.EventHandler(this.btnCreateSpending_Click);
			// 
			// btnUpdateSpending
			// 
			this.btnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdateSpending.Location = new System.Drawing.Point(393, 74);
			this.btnUpdateSpending.Name = "btnUpdateSpending";
			this.btnUpdateSpending.Size = new System.Drawing.Size(131, 39);
			this.btnUpdateSpending.TabIndex = 11;
			this.btnUpdateSpending.Text = "Gider Güncelle";
			this.btnUpdateSpending.UseVisualStyleBackColor = true;
			this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateSpending_Click);
			// 
			// btnRemoveSpending
			// 
			this.btnRemoveSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRemoveSpending.Location = new System.Drawing.Point(393, 119);
			this.btnRemoveSpending.Name = "btnRemoveSpending";
			this.btnRemoveSpending.Size = new System.Drawing.Size(131, 39);
			this.btnRemoveSpending.TabIndex = 10;
			this.btnRemoveSpending.Text = "Gider Sil";
			this.btnRemoveSpending.UseVisualStyleBackColor = true;
			this.btnRemoveSpending.Click += new System.EventHandler(this.btnRemoveSpending_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(67, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tarih:";
			// 
			// txtSpendingAmount
			// 
			this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingAmount.Location = new System.Drawing.Point(118, 94);
			this.txtSpendingAmount.Name = "txtSpendingAmount";
			this.txtSpendingAmount.Size = new System.Drawing.Size(245, 27);
			this.txtSpendingAmount.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(66, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tutar:";
			// 
			// txtSpendingTitle
			// 
			this.txtSpendingTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSpendingTitle.Location = new System.Drawing.Point(118, 61);
			this.txtSpendingTitle.Name = "txtSpendingTitle";
			this.txtSpendingTitle.Size = new System.Drawing.Size(245, 27);
			this.txtSpendingTitle.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(39, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Gider Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Giderler";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(0, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(953, 41);
			this.panel3.TabIndex = 6;
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
			this.panel1.Location = new System.Drawing.Point(1, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 504);
			this.panel1.TabIndex = 5;
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
			// FrmSpendings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 546);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmSpendings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gider - Harcama Formu";
			this.Load += new System.EventHandler(this.FrmSpendings_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCreateSpending;
		private System.Windows.Forms.Button btnUpdateSpending;
		private System.Windows.Forms.Button btnRemoveSpending;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSpendingAmount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSpendingTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.MaskedTextBox mskSpendingDate;
		private System.Windows.Forms.Button button2;
	}
}