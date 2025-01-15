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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void button1_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string userPassword = txtUserPassword.Text;

			var login = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == userPassword);

			if (login == null)
			{
				MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı");
			}
			else
			{
				FrmDashboard frm = new FrmDashboard();
				frm.Show();
			}


		}

		private void button2_Click(object sender, EventArgs e)
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
