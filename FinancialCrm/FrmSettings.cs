using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
	public partial class FrmSettings : Form
	{
		public FrmSettings()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void button4_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string userUpdatePassword = txtUpdatePassword.Text;

			var control = db.Users.FirstOrDefault(x => x.UserName == userName);

			if (control == null)
			{
				MessageBox.Show("Kullanıcı Adı Giriniz");
			}
			else
			{
				control.Password = userUpdatePassword;
				db.SaveChanges();
				MessageBox.Show("Şifre Başarıyla Güncellenmiştir.");
				
			}
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
