using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
	public partial class FrmBankProcesses : Form
	{
		public FrmBankProcesses()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBankProcesses_Load(object sender, EventArgs e)
		{
			var banks = db.Banks.ToList();
			cmbBankSelect.DisplayMember = "BankTitle";
			cmbBankSelect.ValueMember = "BankId";
			cmbBankSelect.DataSource = banks;

		}

		void BankList()
		{
			cmbBankSelect.DisplayMember = "BankTitle";
			cmbBankSelect.ValueMember = "BankTitle";
			var bankselectCmb = cmbBankSelect.SelectedValue.ToString();
			var values = db.BankProcesses
				.Join(db.Banks,
				bankprocesses => bankprocesses.BankId,
				banks => banks.BankId,
				(bankprocesses, banks) => new
				{

					BankProccessId = bankprocesses.BankProccessId,
					Description = bankprocesses.Description,
					ProcessData = bankprocesses.ProcessData,
					ProcessType = bankprocesses.ProcessType,
					Amount = bankprocesses.Amount,
					BankTitle = banks.BankTitle,
				}).Where(x => x.BankTitle == bankselectCmb)
				.ToList();
			var totalBalance = db.Banks.Where(x => x.BankTitle == bankselectCmb).Select(y => y.BankBalance).FirstOrDefault();
			lblBankTotal.Text = totalBalance.ToString() + " ₺";
			dataGridView1.DataSource = values;
		}

		private void cmbBankSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			BankList();
		}

		private void btnSearchBank_Click(object sender, EventArgs e)
		{
			cmbBankSelect.DisplayMember = "BankTitle";
			cmbBankSelect.ValueMember = "BankTitle";
			var bankselectCmb = cmbBankSelect.SelectedValue.ToString();
			var mskfirstDate = DateTime.Parse(mskFirstDate.Text);
			var msksecondDate = DateTime.Parse(mskSecondDate.Text);
			var values = db.BankProcesses
				.Join(db.Banks,
				bankprocesses => bankprocesses.BankId,
				banks => banks.BankId,
				(bankprocesses, banks) => new
				{
					BankProccessId = bankprocesses.BankProccessId,
					Description = bankprocesses.Description,
					ProcessData = bankprocesses.ProcessData,
					ProcessType = bankprocesses.ProcessType,
					Amount = bankprocesses.Amount,
					BankTitle = banks.BankTitle,
				})
				.Where(x => x.BankTitle == bankselectCmb)
				.Where(y => y.ProcessData >= mskfirstDate && y.ProcessData <= msksecondDate)
				.ToList();
			var totalBalance = db.Banks.Where(x => x.BankTitle == bankselectCmb).Select(y => y.BankBalance).FirstOrDefault();

			dataGridView1.DataSource = values;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			BankList();
			mskFirstDate.Clear();
			mskSecondDate.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmCategory frm = new FrmCategory();
			frm.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
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

		private void btnBillForm_Click(object sender, EventArgs e)
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

		private void button6_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard();
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
