using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace MiniPayroll
{
    public partial class frmMain : Form
    {

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dta = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlDataReader rd;
        

        public frmMain()
        {
            InitializeComponent();
            uploadData();
            random();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void uploadData()
        {
            conn.ConnectionString = "server=localhost;user id=root;password=;database=simplepayrolldb";
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "Select Employee_ID,Name,Email,Mobile,Address," +
                "SSN,Bank_Details,Total_Salary,date from employee_db ORDER BY date";

            rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            conn.Close();
            DGV1.DataSource = dt;

        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "" || txtID.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtSSN.Text == "" || txt_totalsalary.Text == "")
            {
                
                MessageBox.Show("Kindly fill up the spaces");
               

            }

           else if (System.Text.RegularExpressions.Regex.IsMatch(txtMobile.Text, "[^0-9]"))
            {
                MessageBox.Show("Check Mobile Number");

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtSSN.Text, "[^0-9]"))
            {
                MessageBox.Show("Check SSN Number");

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_workingdays.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid");

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_salaryperday.Text, "[^0-9]"))
            {
                MessageBox.Show("Invalid");

            }

            else
            {
                string connection = "server=localhost;user id=root;password=;database=simplepayrolldb";
                string query = "INSERT INTO employee_db(`Employee_ID`, `Name`, `Email`, `Mobile`, `Address`, `SSN`, `Bank_Details`,`Total_Salary`)VALUES" +
                    "('" + this.txtID.Text + "','" + this.txtName.Text + "','" + this.txtEmail.Text + "','" + this.txtMobile.Text + "','" + this.txtAddress.Text + "','" + this.txtSSN.Text + "','" + this.txtB1.Text + "','" + this.txt_totalsalary.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfully Saved");
                
                conn.Close();
                clear();
                refresh();
                random();
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtSSN.Text == "" || txt_totalsalary.Text == "")
            {

                MessageBox.Show("Kindly fill up the spaces");

            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=simplepayrolldb";
                string query = "UPDATE employee_db SET Name='" + this.txtName.Text + "',Email='" + this.txtEmail.Text + "',Mobile='" + this.txtMobile.Text + "',Address='" + this.txtAddress.Text + "',SSN='" + this.txtSSN.Text + "',Bank_Details='" + this.txtB1.Text + "',Total_Salary='" + this.txt_totalsalary.Text + "' WHERE Employee_ID='" + this.txtID.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated successfully");
                conn.Close();
                refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtSSN.Text == "")
            {

                MessageBox.Show("Form is empty");

            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=simplepayrolldb";
                string query = "DELETE FROM employee_db WHERE Employee_ID='" + this.txtID.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Deleted the Record successfully");
                conn.Close();
                refresh();
            }
        }
      
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this program!", "PAYROLL SYSTEM");
            Login Log = new Login();
            Log.Show();
            this.Hide();
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtID.Text = DGV1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = DGV1.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = DGV1.SelectedRows[0].Cells[2].Value.ToString();
                txtMobile.Text = DGV1.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = DGV1.SelectedRows[0].Cells[4].Value.ToString();
                txtSSN.Text = DGV1.SelectedRows[0].Cells[5].Value.ToString();
                txtB1.Text = DGV1.SelectedRows[0].Cells[6].Value.ToString();
                txt_totalsalary.Text = DGV1.SelectedRows[0].Cells[7].Value.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            
        }
        
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            try
            {

                string a = txt_workingdays.Text;
                int workdays = int.Parse(a);

                string b = txt_salaryperday.Text;
                int salaryperday = int.Parse(b);

                double totalsalary = workdays * salaryperday;
                txt_totalsalary.Text = totalsalary.ToString();
            }
            catch (Exception)
            
            {

                MessageBox.Show("Please enter a valid salary", "ERROR");
            }
        }

        private void random()
        {
            Random rnd = new Random();

            for (int j = 0; j < 3; j++)
            {
                txtID.Text = rnd.Next()+"";
            }
        }
        private void refresh()
        {
            string connection = "server=localhost;user id=root;password=;database=simplepayrolldb";
            string query = "Select Employee_ID,Name,Email,Mobile,Address," +
              "SSN,Bank_Details,Total_Salary from employee_db ORDER BY date";
            
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV1.DataSource = dt;

            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtSSN.Text = "";
            txtB1.Text = "";
            txt_workingdays.Text = "";
            txt_salaryperday.Text = "";
            txt_totalsalary.Text = "";

        }

       
        private void clear()
        {
            
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtSSN.Text = "";
            txtB1.Text = "";
            txt_workingdays.Text = "";
            txt_salaryperday.Text = "";
            txt_totalsalary.Text = "";
            random();
            
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
