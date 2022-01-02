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
    public partial class window_Open_Ticket : Form
    {
        DBAccess dBAccess = new DBAccess();
        public window_Open_Ticket()
        {
            InitializeComponent();
        }

        private void adjustColumn_order()
        {
            dataGridView_All_Tickets.Columns["Ticket_Name"].DisplayIndex = 0;
            dataGridView_All_Tickets.Columns["TrainNo"].DisplayIndex = 1;
            dataGridView_All_Tickets.Columns["From_st"].DisplayIndex = 2;
            dataGridView_All_Tickets.Columns["To_st"].DisplayIndex = 3;
            dataGridView_All_Tickets.Columns["Date"].DisplayIndex = 4;
            dataGridView_All_Tickets.Columns["Quota"].DisplayIndex = 5;
            dataGridView_All_Tickets.Columns["Class"].DisplayIndex = 6;

            dataGridView_All_Tickets.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_All_Tickets.BackgroundColor = Color.FromKnownColor(KnownColor.Control);
            // dataGridView_All_Tickets.
            dataGridView_All_Tickets.ColumnHeadersVisible = false;
            int leftWidth = dataGridView_All_Tickets.Width - dataGridView_All_Tickets.RowHeadersWidth;
            dataGridView_All_Tickets.DefaultCellStyle.BackColor=Color.FromKnownColor(KnownColor.Control);

            int totalColumns = dataGridView_All_Tickets.Columns.Count;
            for (int i=0;i< totalColumns; i++)
            {
                dataGridView_All_Tickets.Columns[i].Width = leftWidth / totalColumns -1;
                dataGridView_All_Tickets.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void window_Open_Ticket_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //dataGridView_All_Tickets.BackgroundColor = Color.Black;

            Refresh_dataGrid_Open_tkts();


        }
        public void Refresh_dataGrid_Open_tkts()
        {
            DataTable dt_ticket_details = new DataTable();
            string query = "select From_st,To_st,Date,Quota,Class,TrainNo,Ticket_Name from Passenger_table ";
            dBAccess.ReadDataThroughAdapter(query, dt_ticket_details);

            dataGridView_All_Tickets.DataSource = dt_ticket_details;

            comboBox_SelectedTicket.DataSource = dt_ticket_details;
            comboBox_SelectedTicket.DisplayMember = "Ticket_Name";
            int idx = 0;
            foreach(DataGridViewRow row in dataGridView_All_Tickets.Rows)
            {
                row.DefaultCellStyle.BackColor = ++idx%2==0 ? Color.LightBlue:Color.LightGreen;
            }

            adjustColumn_order(); // for show in proper order
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Edit_Click(object sender, EventArgs e)
        {
            try
            {

               

                
                    DataTable dt_Selected_ticket_details = new DataTable();
                    string query = "select * from Passenger_table where Ticket_Name='" + comboBox_SelectedTicket.Text + "' ";
                    dBAccess.ReadDataThroughAdapter(query, dt_Selected_ticket_details);

                    window_new_Ticket window_New_Ticket = new window_new_Ticket();
                    window_New_Ticket.Show();

                window_New_Ticket.dateTimePicker_new_ticket.Format = DateTimePickerFormat.Custom;
                window_New_Ticket.dateTimePicker_new_ticket.CustomFormat = "dd/MM/yyyy";
                window_New_Ticket.dateTimePicker_new_ticket.Text = DateTime.Today.ToString();

                //fill old info
                window_New_Ticket.textBox_From.Text = dt_Selected_ticket_details.Rows[0]["From_st"].ToString();
                    window_New_Ticket.textBox_To.Text = dt_Selected_ticket_details.Rows[0]["To_st"].ToString();
                    window_New_Ticket.dateTimePicker_new_ticket.Text = dt_Selected_ticket_details.Rows[0]["Date"].ToString();   
                    window_New_Ticket.comboBox_Quota.Text = dt_Selected_ticket_details.Rows[0]["Quota"].ToString();
                    window_New_Ticket.comboBox_Class.Text = dt_Selected_ticket_details.Rows[0]["Class"].ToString();
                    window_New_Ticket.textBox_Boarding.Text = dt_Selected_ticket_details.Rows[0]["Board"].ToString();
                    window_New_Ticket.textBox_TrainNo.Text = dt_Selected_ticket_details.Rows[0]["TrainNo"].ToString();
                    window_New_Ticket.textBox_PTFare.Text = dt_Selected_ticket_details.Rows[0]["PT_Fare"].ToString();

                    window_New_Ticket.comboBox_PaymentMethod.Text = dt_Selected_ticket_details.Rows[0]["PaymentMethod"].ToString();
                    window_New_Ticket.comboBox_SlotNo.Text = dt_Selected_ticket_details.Rows[0]["Slot_no"].ToString();
                    window_New_Ticket.comboBox_Irctc_id.Text = dt_Selected_ticket_details.Rows[0]["Irctc_id"].ToString();
                    window_New_Ticket.textBox_MobileNo.Text = dt_Selected_ticket_details.Rows[0]["Mobile_no"].ToString();
                    window_New_Ticket.textBox_Ticket_name.Text = dt_Selected_ticket_details.Rows[0]["Ticket_Name"].ToString();

                    window_New_Ticket.textBox_P1_Name.Text = dt_Selected_ticket_details.Rows[0]["P1_Name"].ToString();
                    window_New_Ticket.textBox_P1_Age.Text = dt_Selected_ticket_details.Rows[0]["P1_Age"].ToString();
                    window_New_Ticket.comboBox_P1_Gender.Text = dt_Selected_ticket_details.Rows[0]["P1_Gender"].ToString();
                    window_New_Ticket.comboBox_P1_Birth.Text = dt_Selected_ticket_details.Rows[0]["P1_Birth"].ToString();
                    window_New_Ticket.checkBox_P1_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P1_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P1_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P1_Child"].ToString() == "0") ? false : true;

                    window_New_Ticket.textBox_P2_Name.Text = dt_Selected_ticket_details.Rows[0]["P2_Name"].ToString();
                    window_New_Ticket.textBox_P2_Age.Text = dt_Selected_ticket_details.Rows[0]["P2_Age"].ToString();
                    window_New_Ticket.comboBox_P2_Gender.Text = dt_Selected_ticket_details.Rows[0]["P2_Gender"].ToString();
                    window_New_Ticket.comboBox_P2_Birth.Text = dt_Selected_ticket_details.Rows[0]["P2_Birth"].ToString();
                    window_New_Ticket.checkBox_P2_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P2_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P2_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P2_Child"].ToString() == "0") ? false : true;

                    window_New_Ticket.textBox_P3_Name.Text = dt_Selected_ticket_details.Rows[0]["P3_Name"].ToString();
                    window_New_Ticket.textBox_P3_Age.Text = dt_Selected_ticket_details.Rows[0]["P3_Age"].ToString();
                    window_New_Ticket.comboBox_P3_Gender.Text = dt_Selected_ticket_details.Rows[0]["P3_Gender"].ToString();
                    window_New_Ticket.comboBox_P3_Birth.Text = dt_Selected_ticket_details.Rows[0]["P3_Birth"].ToString();
                    window_New_Ticket.checkBox_P3_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P3_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P3_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P3_Child"].ToString() == "0") ? false : true;

                    window_New_Ticket.textBox_P4_Name.Text = dt_Selected_ticket_details.Rows[0]["P4_Name"].ToString();
                    window_New_Ticket.textBox_P4_Age.Text = dt_Selected_ticket_details.Rows[0]["P4_Age"].ToString();
                    window_New_Ticket.comboBox_P4_Gender.Text = dt_Selected_ticket_details.Rows[0]["P4_Gender"].ToString();
                    window_New_Ticket.comboBox_P4_Birth.Text = dt_Selected_ticket_details.Rows[0]["P4_Birth"].ToString();
                    window_New_Ticket.checkBox_P4_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P4_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P4_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P4_Child"].ToString() == "0") ? false : true;

                    window_New_Ticket.textBox_P5_Name.Text = dt_Selected_ticket_details.Rows[0]["P5_Name"].ToString();
                    window_New_Ticket.textBox_P5_Age.Text = dt_Selected_ticket_details.Rows[0]["P5_Age"].ToString();
                    window_New_Ticket.comboBox_P5_Gender.Text = dt_Selected_ticket_details.Rows[0]["P5_Gender"].ToString();
                    window_New_Ticket.comboBox_P5_Birth.Text = dt_Selected_ticket_details.Rows[0]["P5_Birth"].ToString();
                    window_New_Ticket.checkBox_P5_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P5_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P5_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P5_Child"].ToString() == "0") ? false : true;

                    window_New_Ticket.textBox_P6_Name.Text = dt_Selected_ticket_details.Rows[0]["P6_Name"].ToString();
                    window_New_Ticket.textBox_P6_Age.Text = dt_Selected_ticket_details.Rows[0]["P6_Age"].ToString();
                    window_New_Ticket.comboBox_P6_Gender.Text = dt_Selected_ticket_details.Rows[0]["P6_Gender"].ToString();
                    window_New_Ticket.comboBox_P6_Birth.Text = dt_Selected_ticket_details.Rows[0]["P6_Birth"].ToString();
                    window_New_Ticket.checkBox_P6_Senior.Checked = (dt_Selected_ticket_details.Rows[0]["P6_S_Citizen"].ToString() == "0") ? false : true;
                    window_New_Ticket.checkBox_P6_Child.Checked = (dt_Selected_ticket_details.Rows[0]["P6_Child"].ToString() == "0") ? false : true;





            }//end of try
            catch(Exception ex)
            {
                throw ex;
            }


        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            window_main window_Main = new window_main();
            window_Main.lbl_No_Form_Loaded.Visible = false;
            window_Main.panel_NoForm_Loaded_Top.Visible = false;
            window_Main.panel_Capcha.Visible = false;
           

            DataTable dt_ticket_details = new DataTable();
            string query = "select * from Passenger_table where Ticket_Name= '"+ comboBox_SelectedTicket.Text+"'";
            dBAccess.ReadDataThroughAdapter(query, dt_ticket_details);

            //fill info in new form window
            window_Main.lbl_from.Text = dt_ticket_details.Rows[0]["From_st"].ToString();
            window_Main.lbl_To.Text = dt_ticket_details.Rows[0]["To_st"].ToString();
            window_Main.lbl_Board.Text = dt_ticket_details.Rows[0]["Board"].ToString();
            window_Main.lbl_Train.Text = dt_ticket_details.Rows[0]["TrainNo"].ToString();
            window_Main.lbl_Quota.Text = dt_ticket_details.Rows[0]["Quota"].ToString();
            window_Main.lbl_Class.Text = dt_ticket_details.Rows[0]["Class"].ToString();
            window_Main.lbl_DOJ.Text = dt_ticket_details.Rows[0]["Date"].ToString();

            

            window_Main.Text = dt_ticket_details.Rows[0]["Ticket_Name"].ToString(); 

            window_Main.Show();

           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dr = MessageBox.Show("Want to Delete Selected Id", "Delete Id", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    string query = "delete from Passenger_table where Ticket_Name = '" + comboBox_SelectedTicket.Text + "' ";
                    SQLiteCommand command = new SQLiteCommand(query);

                    int Rows;// random beacuse truncate would return -1
                    Rows = dBAccess.ExecuteQuery(command);

                    if (Rows > 0)
                    {
                        MessageBox.Show(" Ticket deleted Successfully");
                        Refresh_dataGrid_Open_tkts();

                    }
                    else MessageBox.Show("Unable to Delete tickets, Please Again");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult dr = MessageBox.Show("Want to Delete All Ticket", "Delete All Tickets", MessageBoxButtons.YesNo, MessageBoxIcon.Information); string query = "truncate table Passenger_table ";

                if (dr == DialogResult.Yes)
                {
                    string query2 = "truncate table Passenger_table";
                    SQLiteCommand command = new SQLiteCommand(query2);

                    int Rows = 123;// random beacuse truncate would return -1
                    Rows = dBAccess.ExecuteQuery(command);

                    if (Rows == -1)
                    {
                        MessageBox.Show("All Tickets deleted Successfully");
                        Refresh_dataGrid_Open_tkts();

                    }
                    else MessageBox.Show("Unable to Delete tickets, Please Again");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView_All_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
