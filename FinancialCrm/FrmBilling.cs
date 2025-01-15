using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        void txtClear()
        {
            txtBillAmount.Clear();
            txtBillNumber.Clear();
            txtBillPeriod.Clear();
            txtBillTitle.Clear();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
			try
			{
				string number = txtBillNumber.Text;
				string title = txtBillTitle.Text;
				decimal amount = decimal.Parse(txtBillAmount.Text);
				string period = txtBillPeriod.Text;

				Bills bills = new Bills();
				bills.BillNumber = number;
				bills.BillTitle = title;
				bills.BillAmount = amount;
				bills.BillPriod = period;
				db.Bills.Add(bills);
				db.SaveChanges();
				MessageBox.Show("Fatura Sisteme Başarıyla Eklendi", "Ödeme & Faturalar");

				var values = db.Bills.ToList();
				dataGridView1.DataSource = values;
				txtClear();
			}
			catch (Exception)
			{

				MessageBox.Show("Boş Kayıt Girilemez");
			}
         
		}

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            try
            {
				int id = int.Parse(label8.Text);
				var removeValue = db.Bills.Find(id);
				db.Bills.Remove(removeValue);
				db.SaveChanges();
				MessageBox.Show("Fatura Başarıyla Sistemden Silindi", "Ödeme & Faturalar");

				var values = db.Bills.ToList();
				dataGridView1.DataSource = values;
				txtClear();
			}
            catch (Exception)
            {

                MessageBox.Show("Silinecek Kaydı Seçiniz");
            }
          

		}

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            try
            {
				int id = int.Parse(label8.Text);
				string number = txtBillNumber.Text;
				string title = txtBillTitle.Text;
				decimal amount = decimal.Parse(txtBillAmount.Text);
				string period = txtBillPeriod.Text;

				var values = db.Bills.Find(id);

				values.BillNumber = number;
				values.BillTitle = title;
				values.BillAmount = amount;
				values.BillPriod = period;
				db.SaveChanges();
				MessageBox.Show("Fatura Başarıyla Sistemden Güncellendi", "Ödeme & Faturalar");

				var values2 = db.Bills.ToList();
				dataGridView1.DataSource = values2;
				txtClear();
			}
            catch (Exception)
            {

				MessageBox.Show("Güncellenecek Kaydı Seçiniz");
            }
           
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling();
			frm.Show();
			this.Hide();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.ToString() == "Fatura İşlemleri")
			{
				txtBillAmount.Enabled = true;
				txtBillNumber.Enabled = true;
				txtBillPeriod.Enabled = true;
				txtBillTitle.Enabled = true;
				btnCreateBill.Enabled = true;
				btnUpdateBill.Enabled = true;
				btnBillList.Enabled = true;
				btnRemoveBill.Enabled = true;
				cmbBillStatus.Enabled = false;
				mskBillPayDay.Enabled = false;
				btnStatuUpdate.Enabled = false;

			}
            else if(comboBox1.SelectedItem.ToString() == "Ödeme İşlemleri")
            {
                cmbBillStatus.Enabled = true;
				mskBillPayDay.Enabled = true;
                btnStatuUpdate.Enabled = true;
				txtBillAmount.Enabled = false;
				txtBillNumber.Enabled = false;
				txtBillPeriod.Enabled = false;
				txtBillTitle.Enabled = false;
				btnCreateBill.Enabled = false;
				btnUpdateBill.Enabled = false;
				btnBillList.Enabled = false;
				btnRemoveBill.Enabled = false;

			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBillNumber.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBillTitle.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBillAmount.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtBillPeriod.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard();
			frm.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            try
            {
				int id = int.Parse(label8.Text);
				string billPayStatus = cmbBillStatus.Text;
				DateTime billPayDay = DateTime.Parse(mskBillPayDay.Text);


				var values = db.Bills.Find(id);

				values.BillPayStatus = billPayStatus;
				values.BillPayDate = billPayDay;
				db.SaveChanges();
				MessageBox.Show("Ödeme Durumu Güncellendi", "Ödeme & Faturalar");

				var values2 = db.Bills.ToList();
				dataGridView1.DataSource = values2;
			}
            catch (Exception)
            {

                MessageBox.Show("Tarih Formatını Kontrol Edin (Boş Geçmek İçin 11/11/1111) Olarak Giriniz");
            }
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmCategory frm = new FrmCategory();
			frm.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FrmSpendings frm = new FrmSpendings();
			frm.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FrmBankProcesses frm = new FrmBankProcesses();
			frm.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			FrmSettings frm = new FrmSettings();
			frm.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Programdan çıkmak istediğinizden emin misiniz?",
								"Çıkış Onayı",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
