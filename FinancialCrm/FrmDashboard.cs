﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmDashboard : Form
	{
		public FrmDashboard()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		int count = 0;
		private void FrmDashboard_Load(object sender, EventArgs e)
		{
			var totalBalance = db.Banks.Sum(x => x.BankBalance);
			lblTotalBalance.Text = totalBalance.ToString() + " ₺";

			var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProccessId).Take(1).Select(y => y.Amount).FirstOrDefault();
			lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

			//Chart 1
			var bankData = db.Banks.Select(x => new
			{
				x.BankTitle,
				x.BankBalance
			}).ToList();
			chart1.Series.Clear();
			var series = chart1.Series.Add("Series1");
			foreach (var item in bankData)
			{
				series.Points.AddXY(item.BankTitle, item.BankBalance);
			}

			//Chart 2
			var billData = db.Bills.Select(x => new
			{
				x.BillTitle,
				x.BillAmount
			}).ToList();
			chart2.Series.Clear();
			var series2 = chart2.Series.Add("Faturalar");
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
			foreach (var item in billData)
			{
				series2.Points.AddXY(item.BillTitle, item.BillAmount);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;
			if (count % 4 == 1)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBilTitle.Text = "Elektrik Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
			}
			if (count % 4 == 2)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBilTitle.Text = "Doğalgaz Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
			}
			if (count % 4 == 3)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBilTitle.Text = "Su Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
			}
			if (count % 4 == 0)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBilTitle.Text = "İnternet Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + " ₺";
			}
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

		private void button6_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard();
			frm.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmCategory frm = new FrmCategory();
			frm.Show();
			this.Hide();
		}

		private void btnBillForm_Click(object sender, EventArgs e)
		{
			FrmSpendings frm = new FrmSpendings();
			frm.Show();
			this.Hide();
		}

		private void chart2_Click(object sender, EventArgs e)
		{

		}

		private void lblTotalBalance_Click(object sender, EventArgs e)
		{

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
	}
}
