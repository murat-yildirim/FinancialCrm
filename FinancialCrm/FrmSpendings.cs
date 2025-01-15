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
	public partial class FrmSpendings : Form
	{
		public FrmSpendings()
		{
			InitializeComponent();
		}
		void SpendingsList()
		{

			var values = db.Spendings
				.Join(db.Categories,
				spending => spending.CategoryId,
				category => category.CategoryId,
				(spending, category) => new
				{

					SpendingId = spending.SpendingId,
					SpendingTitle = spending.SpendingTitle,
				 SpendingAmount = spending.SpendingAmount,
					SpendingDate =  spending.SpendingDate,
					CategoryName = category.CategoryName,
				})
				.ToList();
			dataGridView1.DataSource = values;


		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmSpendings_Load(object sender, EventArgs e)
		{
			var category = db.Categories.ToList();
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryId";
			cmbCategory.DataSource = category;
			SpendingsList();
		}

		

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			cmbCategory.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			txtSpendingTitle.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			txtSpendingAmount.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			mskSpendingDate.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			label8.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cmbCategory.DisplayMember = "CategoryName"; 
			cmbCategory.ValueMember = "CategoryName";   
			var categoryCmb = cmbCategory.SelectedValue.ToString();
			var values = db.Spendings
				.Join(db.Categories,
				spending => spending.CategoryId,
				category => category.CategoryId,
				(spending, category) => new
				{

					SpendingId = spending.SpendingId,
					SpendingTitle = spending.SpendingTitle,
					SpendingAmount = spending.SpendingAmount,
					SpendingDate = spending.SpendingDate,
					CategoryName = category.CategoryName,
				}).Where(x=>x.CategoryName == categoryCmb)
				.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCreateSpending_Click(object sender, EventArgs e)
		{
			Spendings spendings = new Spendings();
			spendings.SpendingTitle = txtSpendingTitle.Text;
			spendings.SpendingAmount = int.Parse(txtSpendingAmount.Text);
			spendings.SpendingDate = DateTime.Parse(mskSpendingDate.Text);
			spendings.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			db.Spendings.Add(spendings);
			db.SaveChanges();
			SpendingsList();
		}

		private void btnUpdateSpending_Click(object sender, EventArgs e)
		{
			var value = db.Spendings.Find(int.Parse(label8.Text));
			value.SpendingTitle = txtSpendingTitle.Text;
			value.SpendingAmount = int.Parse(txtSpendingAmount.Text);
			value.SpendingDate = DateTime.Parse(mskSpendingDate.Text);
			value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			db.SaveChanges();
			SpendingsList();
		}

		private void btnRemoveSpending_Click(object sender, EventArgs e)
		{
			var value = db.Spendings.Find(int.Parse(label8.Text));
			db.Spendings.Remove(value);
			db.SaveChanges();
			SpendingsList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmCategory frm = new FrmCategory();
			frm.Show();
			this.Hide();
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
