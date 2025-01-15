using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCrm.Models;
namespace FinancialCrm
{
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		
		void categoryList()
		{
			var values = db.Categories.ToList();
			dataGridView1.DataSource = values;
		}
		private void FrmCategory_Load(object sender, EventArgs e)
		{
			var values = db.Spendings
					.Join(db.Categories,
					spending => spending.CategoryId,
					category => category.CategoryId,
					(spending, category) => new
					{
						CategoryId = category.CategoryId,
						CategoryName = category.CategoryName,
					})
					.GroupBy(x => x.CategoryName)
					.Select(group => new
					{
						CategoryName = group.Key,
						Count = group.Count()
					})
					.OrderByDescending(x => x.Count)
					.Take(3)
					.ToList();

			chart1.Series.Clear();
			var series = chart1.Series.Add("En Çok Kullanılan Kategoriler");
			series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			foreach (var item in values)
			{
				series.Points.AddXY(item.CategoryName, item.Count);
			}

			categoryList();
		}

		private void btnCreateCategory_Click(object sender, EventArgs e)
		{
			Categories category = new Categories();
			category.CategoryName = txtCategoryName.Text;
			
			db.Categories.Add(category);
			db.SaveChanges();
			categoryList();
			MessageBox.Show("Kategori Başarıyla Eklenmiştir.");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtCategoryName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			
			label8.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			var value = db.Categories.Find(int.Parse(label8.Text));
			value.CategoryName = txtCategoryName.Text;
			
			db.SaveChanges();
			MessageBox.Show("Kategori Başarıyla Güncellenmiştir.");
			categoryList();

		}
		private void btnRemoveBill_Click(object sender, EventArgs e)
		{
			var value = db.Categories.Find(int.Parse(label8.Text));
			db.Categories.Remove(value);
			db.SaveChanges();
			MessageBox.Show("Kategori Başarıyla Silinmiştir.");
			categoryList();
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
