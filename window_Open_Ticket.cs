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

            dataGridView_All_Tickets.ColumnHeadersVisible = false;
            int leftWidth = dataGridView_All_Tickets.Width - dataGridView_All_Tickets.RowHeadersWidth;

            int totalColumns = dataGridView_All_Tickets.Columns.Count;
            for (int i=0;i< totalColumns; i++)
            {
                dataGridView_All_Tickets.Columns[i].Width = leftWidth / totalColumns -1;
            }
        }
        private void window_Open_Ticket_Load(object sender, EventArgs e)
        {
            DataTable dt_ticket_details = new DataTable();
            string query = "select From_st,To_st,Date,Quota,Class,TrainNo,Ticket_Name from Passenger_table ";
            dBAccess.ReadDataThroughAdapter(query, dt_ticket_details);

            dataGridView_All_Tickets.DataSource = dt_ticket_details;

            comboBox_SelectedTicket.DataSource = dt_ticket_details;
            comboBox_SelectedTicket.DisplayMember = "Ticket_Name";
            adjustColumn_order(); // for show in proper order



        }
        private void Refresh_dataGrid_Open_tkts()
        {
            DataTable dt_ticket_details = new DataTable();
            string query = "select From_st,To_st,Date,Quota,Class,TrainNo,Ticket_Name from Passenger_table ";
            dBAccess.ReadDataThroughAdapter(query, dt_ticket_details);

            dataGridView_All_Tickets.DataSource = dt_ticket_details;

            comboBox_SelectedTicket.DataSource = dt_ticket_details;
            comboBox_SelectedTicket.DisplayMember = "Ticket_Name";
            adjustColumn_order(); // for show in proper order
        }

        private void button3_Click(object sender, EventArgs e)
        {
          DialogResult dr =  MessageBox.Show("Want to Delete Selected Ticket","Delete Selected Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("delete from Passenger_table where Ticket_Name = '" + comboBox_SelectedTicket.Text + "' ");
              int row =  dBAccess.ExecuteQuery(command);

                if (row > 0)
                {
                    MessageBox.Show("Ticket Deleted Successfully");

                    Refresh_dataGrid_Open_tkts();
                }
                else MessageBox.Show("Unable to delete , Please Try again");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Want to Delete All Tickets", "Delete All Tickets", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("truncate table Passenger_table  ");
                int row = dBAccess.ExecuteQuery(command);

                if (row > 0)
                {
                    MessageBox.Show("All Tickets Deleted Successfully");
                    Refresh_dataGrid_Open_tkts();
                }
                else MessageBox.Show("Unable to delete , Please Try again");
            }
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

/*
                string Insert_query = "insert into   Passenger_table(From_st,To_st,Date,Quota,Class,Board,TrainNo, PT_Fare,PaymentMethod, Slot_no, Mobile_no,Irctc_id,Ticket_Name,P1_Name,P1_Age,P1_Gender,P1_Birth,P1_S_Citizen,P1_Child,P2_Name,P2_Age,P2_Gender,P2_Birth,P2_S_Citizen,P2_Child,P3_Name,P3_Age,P3_Gender,P3_Birth,P3_S_Citizen,P3_Child,P4_Name,P4_Age,P4_Gender,P4_Birth,P4_S_Citizen,P4_Child,P5_Name,P5_Age,P5_Gender,P5_Birth,P5_S_Citizen,P5_Child,P6_Name,P6_Age,P6_Gender,P6_Birth,P6_S_Citizen,P6_Child )   " +
                            "values( @From_,@To_,@Date_,@Quota_,@Class_,@Board_,@TrainNo_, @PT_Fare_,@PaymentMethod_, @Slot_no_," +
                            " @Mobile_no_,@Irctc_id_,@Ticket_Name_,@P1_Name_,@P1_Age_,@P1_Gender_,@P1_Birth_,@P1_S_Citizen_,@P1_Child_,@P2_Name_,@P2_Age_,@P2_Gender_,@P2_Birth_," +
                            "@P2_S_Citizen_,@P2_Child_,@P3_Name_,@P3_Age_,@P3_Gender_,@P3_Birth_,@P3_S_Citizen_,@P3_Child_,@P4_Name_,@P4_Age_,@P4_Gender_,@P4_Birth_,@P4_S_Citizen_,@P4_Child_," +
                            "@P5_Name_,@P5_Age_,@P5_Gender_,@P5_Birth_,@P5_S_Citizen_,@P5_Child_,@P6_Name_,@P6_Age_,@P6_Gender_,@P6_Birth_,@P6_S_Citizen_,@P6_Child_  )    ";

                
                SqlCommand insertcommand = new SqlCommand(Insert_query);

                insertcommand.Parameters.AddWithValue("@From_", window_New_Ticket.textBox_From.Text);
                insertcommand.Parameters.AddWithValue("@To_", window_New_Ticket.textBox_To.Text);
                insertcommand.Parameters.AddWithValue("@Date_", window_New_Ticket.dateTimePicker_new_ticket.Text);
                insertcommand.Parameters.AddWithValue("@Quota_", window_New_Ticket.comboBox_Quota.Text);
                insertcommand.Parameters.AddWithValue("@Class_", window_New_Ticket.comboBox_Class.Text);
                insertcommand.Parameters.AddWithValue("@Board_", window_New_Ticket.textBox_Boarding.Text);
                insertcommand.Parameters.AddWithValue("@TrainNo_", window_New_Ticket.textBox_TrainNo.Text);
                insertcommand.Parameters.AddWithValue("@PT_Fare_", window_New_Ticket.textBox_PTFare.Text);
                insertcommand.Parameters.AddWithValue("@PaymentMethod_", window_New_Ticket.comboBox_PaymentMethod.Text);
                insertcommand.Parameters.AddWithValue("@Slot_no_", window_New_Ticket.comboBox_SlotNo.Text);
                insertcommand.Parameters.AddWithValue("@Mobile_no_", window_New_Ticket.textBox_MobileNo.Text);
                insertcommand.Parameters.AddWithValue("@Irctc_id_", window_New_Ticket.comboBox_Irctc_id.Text);
                insertcommand.Parameters.AddWithValue("@Ticket_Name_", window_New_Ticket.textBox_Ticket_name.Text);

                insertcommand.Parameters.AddWithValue("@P1_Name_", window_New_Ticket.textBox_P1_Name.Text);
                insertcommand.Parameters.AddWithValue("@P1_Age_", window_New_Ticket.textBox_P1_Age.Text);
                insertcommand.Parameters.AddWithValue("@P1_Gender_", window_New_Ticket.comboBox_P1_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P1_Birth_", window_New_Ticket.comboBox_P1_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P1_S_Citizen_", window_New_Ticket.checkBox_P1_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P1_Child_", window_New_Ticket.checkBox_P1_Child.Checked);

                insertcommand.Parameters.AddWithValue("@P2_Name_", window_New_Ticket.textBox_P2_Name.Text);
                insertcommand.Parameters.AddWithValue("@P2_Age_", window_New_Ticket.textBox_P2_Age.Text);
                insertcommand.Parameters.AddWithValue("@P2_Gender_", window_New_Ticket.comboBox_P2_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P2_Birth_", window_New_Ticket.comboBox_P2_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P2_S_Citizen_", window_New_Ticket.checkBox_P2_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P2_Child_", window_New_Ticket.checkBox_P2_Child.Checked);

                insertcommand.Parameters.AddWithValue("@P3_Name_", window_New_Ticket.textBox_P3_Name.Text);
                insertcommand.Parameters.AddWithValue("@P3_Age_", window_New_Ticket.textBox_P3_Age.Text);
                insertcommand.Parameters.AddWithValue("@P3_Gender_", window_New_Ticket.comboBox_P3_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P3_Birth_", window_New_Ticket.comboBox_P3_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P3_S_Citizen_", window_New_Ticket.checkBox_P3_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P3_Child_", window_New_Ticket.checkBox_P3_Child.Checked);

                insertcommand.Parameters.AddWithValue("@P4_Name_", window_New_Ticket.textBox_P4_Name.Text);
                insertcommand.Parameters.AddWithValue("@P4_Age_", window_New_Ticket.textBox_P4_Age.Text);
                insertcommand.Parameters.AddWithValue("@P4_Gender_", window_New_Ticket.comboBox_P4_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P4_Birth_", window_New_Ticket.comboBox_P4_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P4_S_Citizen_", window_New_Ticket.checkBox_P4_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P4_Child_", window_New_Ticket.checkBox_P4_Child.Checked);

                insertcommand.Parameters.AddWithValue("@P5_Name_", window_New_Ticket.textBox_P5_Name.Text);
                insertcommand.Parameters.AddWithValue("@P5_Age_", window_New_Ticket.textBox_P5_Age.Text);
                insertcommand.Parameters.AddWithValue("@P5_Gender_", window_New_Ticket.comboBox_P5_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P5_Birth_", window_New_Ticket.comboBox_P5_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P5_S_Citizen_", window_New_Ticket.checkBox_P5_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P5_Child_", window_New_Ticket.checkBox_P5_Child.Checked);

                insertcommand.Parameters.AddWithValue("@P6_Name_", window_New_Ticket.textBox_P6_Name.Text);
                insertcommand.Parameters.AddWithValue("@P6_Age_", window_New_Ticket.textBox_P6_Age.Text);
                insertcommand.Parameters.AddWithValue("@P6_Gender_", window_New_Ticket.comboBox_P6_Gender.Text); // P1 passengers Deatils
                insertcommand.Parameters.AddWithValue("@P6_Birth_", window_New_Ticket.comboBox_P6_Birth.Text);
                insertcommand.Parameters.AddWithValue("@P6_S_Citizen_", window_New_Ticket.checkBox_P6_Senior.Checked);
                insertcommand.Parameters.AddWithValue("@P6_Child_", window_New_Ticket.checkBox_P6_Child.Checked);

                int rows = dBAccess.ExecuteQuery(insertcommand);
                if (rows > 0)
                {
                    MessageBox.Show("Tickets Saved as New Ticket Successfully");
                    Refresh_dataGrid_Open_tkts();
                }
                else MessageBox.Show("Unable to Update Ticket , Please try again");*/




            }//end of try
            catch(Exception ex)
            {
                throw ex;
            }


        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            window_main window_Main = new window_main();
            window_Main.panel_NoForm_Loaded_Top.Visible = false;
           

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

            
            // window_Main.comboBox_ID_MainWindow.Text       = window_Main.dt_ID_deatails.Rows[]["ID_username"].ToString();
            // window_Main.comboBox_BankName_MainWindow.Text =  window_Main.dt_bank_details.Rows[0]["UPI_id"].ToString();

            window_Main.Text = dt_ticket_details.Rows[0]["Ticket_Name"].ToString(); 

            window_Main.Show();

           

        }
    }
}
