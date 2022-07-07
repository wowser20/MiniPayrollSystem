using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPayroll.Include;
using System.Windows.Forms;

namespace MiniPayroll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;


        private void btnLogin_Click(object sender, EventArgs e)
        {

            sql = "SELECT * FROM users WHERE username ='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                MessageBox.Show("WELCOME TO PAYROLL SYSTEM","PAYROLL SYSTEM");
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact administrator", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
