using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace E_Ticket_Pro_472
{
    public partial class window_Add_bank : Form
    {
        DBAccess dBAccess = new DBAccess();
        public window_Add_bank()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_netbank_Click(object sender, EventArgs e)
        {
            if (textBox_bank_username.Text == "") MessageBox.Show("Please enter Username") ;
            else if(textBox_bank_password.Text=="") MessageBox.Show("Please enter Password") ;
            else
            {
                try
                {
                    SQLiteCommand insertcommand = new SQLiteCommand("insert into Bank_table(Gatewaytype,UPI_id,Username,Password) values(@gateway,@upi_id,@username,@password) ");

                    insertcommand.Parameters.AddWithValue("@gateway", comboBox_SelectPaymentGateway.Text);
                    insertcommand.Parameters.AddWithValue("@upi_id", textBox_UPI_id.Text);
                    insertcommand.Parameters.AddWithValue("@username", textBox_bank_username.Text);
                    insertcommand.Parameters.AddWithValue("@password", textBox_bank_password.Text);

                    int rows = dBAccess.ExecuteQuery(insertcommand);

                    if (rows > 0)
                    {
                        MessageBox.Show("Bank details saved successfully");
                        textBox_bank_password.Text = ""; textBox_bank_username.Text = "";
                        textBox_UPI_id.Text = "";
                        Refresh_dataGrid_Bank();
                    }
                    else MessageBox.Show("Unable to save bank details. Please try again");
                }
                catch(Exception ex)
                {
                    throw ex;
                }
               

            }
        }

        private void btn_save_UPI_Click(object sender, EventArgs e)
        {
            if (textBox_UPI_id.Text == "") MessageBox.Show("Please enter UPI Id");
            
            else
            {
                try
                {
                    SQLiteCommand insertcommand = new SQLiteCommand("insert into Bank_table(Gatewaytype,UPI_id,Username,Password) values(@gateway,@upi_id,@username,@password) ");

                    insertcommand.Parameters.AddWithValue("@gateway", comboBox_SelectPaymentGateway.Text);
                    insertcommand.Parameters.AddWithValue("@upi_id", textBox_UPI_id.Text);
                    insertcommand.Parameters.AddWithValue("@username", textBox_bank_username.Text);
                    insertcommand.Parameters.AddWithValue("@password", textBox_bank_password.Text);

                    int rows = dBAccess.ExecuteQuery(insertcommand);

                    if (rows > 0)
                    {
                        MessageBox.Show("Bank details saved successfully");
                        textBox_bank_password.Text = ""; textBox_bank_username.Text = "";
                        textBox_UPI_id.Text = "";
                        Refresh_dataGrid_Bank();
                    }
                    else MessageBox.Show("Unable to save bank details. Please try again");
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }

        private void comboBox_SelectPaymentGateway_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectPaymentGateway.Text == "BHIM UPI") { groupBox_UPI.Visible = true; groupBox_Netbanking.Visible = false; }

            else { groupBox_Netbanking.Visible = true; groupBox_UPI.Visible = false; }
        }

        private void window_Add_bank_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            DataTable dt_bank = new DataTable();
            string query = "select Gatewaytype,UPI_id,Username,Password from Bank_table";
            dBAccess.ReadDataThroughAdapter(query, dt_bank);

            dataGridView_BankDetails.DataSource = dt_bank;
            dataGridView_BankDetails.ColumnHeadersVisible = false;
            dataGridView_BankDetails.Columns["UPI_id"].Width = 150;

            comboBox_Bank_toDelete.DataSource = dt_bank;
            comboBox_Bank_toDelete.DisplayMember = "UPI_id";

        }

      private void  Refresh_dataGrid_Bank()
        {
            DataTable dt_bank = new DataTable();
            string query = "select Gatewaytype,UPI_id,Username,Password from Bank_table";
            dBAccess.ReadDataThroughAdapter(query, dt_bank);

            dataGridView_BankDetails.DataSource = dt_bank;
            dataGridView_BankDetails.ColumnHeadersVisible = false;

            comboBox_Bank_toDelete.DataSource = dt_bank;
            comboBox_Bank_toDelete.DisplayMember = "UPI_id";
        }

        private void btn_delete_bank_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dl = MessageBox.Show("Want to delete selected Bank", "Delete Bank details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dl == DialogResult.Yes)
                {
                    SQLiteCommand command = new SQLiteCommand("delete from Bank_table where UPI_id ='" + comboBox_Bank_toDelete.Text + "' ");
                    int rows = dBAccess.ExecuteQuery(command);

                    if (rows > 0)
                    {
                        MessageBox.Show("Bank details Deleted Succesfully");
                        Refresh_dataGrid_Bank();
                    }
                    else MessageBox.Show("Unable to Delete ,Please Try again");

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

       

        private void btn_Delete_All_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dl = MessageBox.Show("Want to delete All Bank Details", "Delete Bank details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dl == DialogResult.Yes)
                {
                    SQLiteCommand command = new SQLiteCommand("truncate table Bank_table");
                    int rows = 123; //random beacuse for truncate it return -1 
                      rows = dBAccess.ExecuteQuery(command);

                    if (rows==-1)
                    {
                        MessageBox.Show("All Bank details Deleted Succesfully");
                        Refresh_dataGrid_Bank();
                    }
                    else MessageBox.Show("Unable to Delete ,Please Try again");

                }
            }
            catch(Exception ex)
            {
                throw ex;

            }
            
        }
    }
}
