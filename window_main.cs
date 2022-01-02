using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticket_Pro_472
{
    public partial class window_main : Form
    {
        DBAccess dBAccess = new DBAccess();
     public   DataTable dt_bank_details = new DataTable();
     public DataTable dt_ID_deatails = new DataTable();
      public  window_new_Ticket win_new_ticket; 
        public window_main()
        {
            InitializeComponent();
        }

        private void Main_Manu_Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_NgetLogin_Click(object sender, EventArgs e)
        {

        }

        private void addDeleteAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_Add_Id win_addbank = new window_Add_Id();

            win_addbank.Show();

        }

        private void addDeleteBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_Add_bank win_add_ID = new window_Add_bank();

            win_add_ID.Show();
        }

        private void newTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
             win_new_ticket = new window_new_Ticket();
            win_new_ticket.Show();
        }

        private void lbl_No_Form_Loaded_Click(object sender, EventArgs e)
        {
            window_Open_Ticket win_open_ticket = new window_Open_Ticket();
            win_open_ticket.Show();
        }

        public void window_main_Load(object sender, EventArgs e)
        {
            //Retrive data for bank details
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;



            string query1 = "select * from Bank_table";
          
            dBAccess.ReadDataThroughAdapter(query1, dt_bank_details);
            comboBox_BankName_MainWindow.DataSource = dt_bank_details;
            comboBox_BankName_MainWindow.DisplayMember = "UPI_id";

            //Retrive data for ID details
            string query2 = "select * from ID_table";
           
            dBAccess.ReadDataThroughAdapter(query2, dt_ID_deatails);
            comboBox_ID_MainWindow.DataSource = dt_ID_deatails;
            comboBox_ID_MainWindow.DisplayMember = "ID_username" ;
            comboBox_Slot_MainWindow.Text = "1";            


        }

        public void openTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_Open_Ticket win_open_Ticket = new window_Open_Ticket();
            win_open_Ticket.Show();

        }

        public void Refresh_datadrid_open_tkt()
        {
           
        }
        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            How_to_use h2u = new How_to_use();
            h2u.Show();
        }

        private void editTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pNRStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        Test_Selenium kk = null;
        private async void btn_Normal_Login_Click(object sender, EventArgs e)
        {
             kk = new Test_Selenium(this);
            await kk.setup_start();
            await kk.Login_irctc();
           
           


        }

        private void Captcha_box_Click(object sender, EventArgs e)
        {

        }

        private async void btn_capcha_submit_Click(object sender, EventArgs e)
        {
            string CAP=textBox_capchaText.Text;

             await kk.Find_Trains(CAP); 
             await kk.get_Book_now();  lbl_YourLicenceValidity.Text = "Sumbitming Passenger - 1";
             await kk.Fill_Passenger_Details(); lbl_YourLicenceValidity.Text = "Sumbitming Passenger - 0";
            await kk.Going_To_bank();
        }
    }
}
