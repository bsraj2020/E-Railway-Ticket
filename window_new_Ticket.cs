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
    public partial class window_new_Ticket : Form
    {

        DBAccess dBAccess = new DBAccess();
        
        public window_new_Ticket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool CheckForDetails()
        {
            if (textBox_From.Text == "") { MessageBox.Show("Please Enter From Station"); return false; }
            else if (textBox_From.Text == "") { MessageBox.Show("Please Enter From Station"); return false; }
            else if (textBox_To.Text == "") { MessageBox.Show("Please Enter To Station"); return false; }
            else if (comboBox_Quota.Text == "") { MessageBox.Show("Please Enter Quota"); return false; }
            else if (comboBox_Class.Text == "") { MessageBox.Show("Please Enter Class"); return false; }
            else if (textBox_Boarding.Text == "") { MessageBox.Show("Please Enter Boarding Station"); return false; }
            else if (textBox_TrainNo.Text == "") { MessageBox.Show("Please Enter Train No"); return false; }
            else if (textBox_P1_Name.Text == "") { MessageBox.Show("Please Enter First Passenger Name"); return false; }
            else if (textBox_P1_Age.Text == "") { MessageBox.Show("Please Enter First Passenger Age"); return false; }
            else if (comboBox_P1_Gender.Text == "") { MessageBox.Show("Please Select First Passenger Gender"); return false; }
            else if (comboBox_PaymentMethod.Text == "") { MessageBox.Show("Please Select Payment method"); return false; }
            else if (comboBox_SlotNo.Text == "") { MessageBox.Show("Please Select Slot No."); return false; }
            else if (comboBox_Irctc_id.Text== "") { MessageBox.Show("Please Select Irctc Id"); return false; }
            else if (textBox_MobileNo.Text=="") { MessageBox.Show("Please Select Mobile No."); return false; }
            else if (textBox_Ticket_name.Text=="") { MessageBox.Show("Please Enter Ticket Name"); return false; }

          

            else return true;

           


        }
        private void btn_save_now_Click(object sender, EventArgs e)
        {
            try
            {

                string query1 = "select * from Passenger_table where Ticket_Name='" + textBox_Ticket_name.Text + "' ";
                if (dBAccess.IS_Exist(query1))
                {
                    DialogResult dr = MessageBox.Show("Please Give a Unique Ticket Name","Form Already Exist", MessageBoxButtons.OK);
                    return;
                }

                if (CheckForDetails())
                {
                    

                    string query = "insert into Passenger_table(From_st,To_st,Date,Quota,Class,Board,TrainNo, PT_Fare,PaymentMethod, Slot_no, Mobile_no,Irctc_id,Ticket_Name,P1_Name,P1_Age,P1_Gender,P1_Birth," +
                        "P1_S_Citizen,P1_Child,P2_Name,P2_Age,P2_Gender,P2_Birth,P2_S_Citizen,P2_Child,P3_Name,P3_Age,P3_Gender,P3_Birth,P3_S_Citizen,P3_Child,P4_Name,P4_Age,P4_Gender,P4_Birth,P4_S_Citizen,P4" +
                        "_Child,P5_Name,P5_Age,P5_Gender,P5_Birth,P5_S_Citizen,P5_Child,P6_Name,P6_Age,P6_Gender,P6_Birth,P6_S_Citizen,P6_Child )   " +
                        "values( @From_,@To_,@Date_,@Quota_,@Class_,@Board_,@TrainNo_, @PT_Fare_,@PaymentMethod_, @Slot_no_," +
                        " @Mobile_no_,@Irctc_id_,@Ticket_Name_,@P1_Name_,@P1_Age_,@P1_Gender_,@P1_Birth_,@P1_S_Citizen_,@P1_Child_,@P2_Name_,@P2_Age_,@P2_Gender_,@P2_Birth_," +
                        "@P2_S_Citizen_,@P2_Child_,@P3_Name_,@P3_Age_,@P3_Gender_,@P3_Birth_,@P3_S_Citizen_,@P3_Child_,@P4_Name_,@P4_Age_,@P4_Gender_,@P4_Birth_,@P4_S_Citizen_,@P4_Child_," +
                        "@P5_Name_,@P5_Age_,@P5_Gender_,@P5_Birth_,@P5_S_Citizen_,@P5_Child_,@P6_Name_,@P6_Age_,@P6_Gender_,@P6_Birth_,@P6_S_Citizen_,@P6_Child_  )    ";

                    SQLiteCommand insertcommand = new SQLiteCommand(query);

                    // General infromation of Ticket Form
                    insertcommand.Parameters.AddWithValue("@From_", textBox_From.Text);
                    insertcommand.Parameters.AddWithValue("@To_", textBox_To.Text);
                    insertcommand.Parameters.AddWithValue("@Date_", dateTimePicker_new_ticket.Text);
                    insertcommand.Parameters.AddWithValue("@Quota_", comboBox_Quota.Text);
                    insertcommand.Parameters.AddWithValue("@Class_", comboBox_Class.Text);
                    insertcommand.Parameters.AddWithValue("@Board_", textBox_Boarding.Text);
                    insertcommand.Parameters.AddWithValue("@TrainNo_", textBox_TrainNo.Text);
                    insertcommand.Parameters.AddWithValue("@PT_Fare_", textBox_PTFare.Text);
                    insertcommand.Parameters.AddWithValue("@PaymentMethod_", comboBox_PaymentMethod.Text);
                    insertcommand.Parameters.AddWithValue("@Slot_no_", comboBox_SlotNo.Text);
                    insertcommand.Parameters.AddWithValue("@Mobile_no_", textBox_MobileNo.Text);
                    insertcommand.Parameters.AddWithValue("@Irctc_id_", comboBox_Irctc_id.Text);
                    insertcommand.Parameters.AddWithValue("@Ticket_Name_", textBox_Ticket_name.Text);

                    insertcommand.Parameters.AddWithValue("@P1_Name_", textBox_P1_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P1_Age_", textBox_P1_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P1_Gender_", comboBox_P1_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P1_Birth_", comboBox_P1_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P1_S_Citizen_", checkBox_P1_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P1_Child_", checkBox_P1_Child.Checked);
                   
                    insertcommand.Parameters.AddWithValue("@P2_Name_", textBox_P2_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P2_Age_", textBox_P2_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P2_Gender_", comboBox_P2_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P2_Birth_", comboBox_P2_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P2_S_Citizen_", checkBox_P2_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P2_Child_", checkBox_P2_Child.Checked);

                    insertcommand.Parameters.AddWithValue("@P3_Name_", textBox_P3_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P3_Age_", textBox_P3_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P3_Gender_", comboBox_P3_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P3_Birth_", comboBox_P3_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P3_S_Citizen_", checkBox_P3_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P3_Child_", checkBox_P3_Child.Checked);

                    insertcommand.Parameters.AddWithValue("@P4_Name_", textBox_P4_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P4_Age_", textBox_P4_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P4_Gender_", comboBox_P4_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P4_Birth_", comboBox_P4_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P4_S_Citizen_", checkBox_P4_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P4_Child_", checkBox_P4_Child.Checked);

                    insertcommand.Parameters.AddWithValue("@P5_Name_", textBox_P5_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P5_Age_", textBox_P5_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P5_Gender_", comboBox_P5_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P5_Birth_", comboBox_P5_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P5_S_Citizen_", checkBox_P5_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P5_Child_", checkBox_P5_Child.Checked);

                    insertcommand.Parameters.AddWithValue("@P6_Name_", textBox_P6_Name.Text);
                    insertcommand.Parameters.AddWithValue("@P6_Age_", textBox_P6_Age.Text);
                    insertcommand.Parameters.AddWithValue("@P6_Gender_", comboBox_P6_Gender.Text); // P1 passengers Deatils
                    insertcommand.Parameters.AddWithValue("@P6_Birth_", comboBox_P6_Birth.Text);
                    insertcommand.Parameters.AddWithValue("@P6_S_Citizen_", checkBox_P6_Senior.Checked);
                    insertcommand.Parameters.AddWithValue("@P6_Child_", checkBox_P6_Child.Checked);


                    int rows = dBAccess.ExecuteQuery(insertcommand);

                    if (rows > 0)
                    {
                        MessageBox.Show("Ticket Saved Successfully");
                        
                         this.Close();
                    }
                    else MessageBox.Show("Unable to save Ticket. Try again");
                }



            } //end of try
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

       

        private void textBox_Boarding_TextChanged(object sender, EventArgs e)
        {

        }

        private void window_new_Ticket_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            


            dateTimePicker_new_ticket.Format = DateTimePickerFormat.Custom;
            dateTimePicker_new_ticket.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_new_ticket.Value = DateTime.Today.AddDays(1);
            // Retrive Data for Bank Details
            DataTable dt_payment = new DataTable();
            string query = "select UPI_id from Bank_table";
            dBAccess.ReadDataThroughAdapter(query, dt_payment);

            comboBox_PaymentMethod.DataSource = dt_payment;
            comboBox_PaymentMethod.DisplayMember = "UPI_id";

            // Retrive Data for Irctc Id
            DataTable dt_Id = new DataTable();
            string query2 = "select ID_username from ID_table";
            dBAccess.ReadDataThroughAdapter(query2, dt_Id);

            comboBox_Irctc_id.DataSource = dt_Id;
            comboBox_Irctc_id.DisplayMember = "ID_username";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search_train search_Train = new Search_train(this);
            search_Train.Show();
        }

        private void textBox_To_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_Quota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_Quota.Text=="GN")
            {
                textBox_P5_Name.Visible = textBox_P5_Age.Visible = comboBox_P5_Birth.Visible = comboBox_P5_Gender.Visible = true;
                checkBox_P5_Child.Visible = checkBox_P5_Senior.Visible = true;
                textBox_P6_Name.Visible = textBox_P6_Age.Visible = comboBox_P6_Birth.Visible = comboBox_P6_Gender.Visible = true;
                checkBox_P6_Child.Visible = checkBox_P6_Senior.Visible = true;
                panel_PT_fare.Visible = false;
                
            }
          else  if(comboBox_Quota.Text=="CK" || comboBox_Quota.Text=="PT")
            {
                textBox_P5_Name.Visible = textBox_P5_Age.Visible = comboBox_P5_Birth.Visible = comboBox_P5_Gender.Visible = false;
                checkBox_P5_Child.Visible = checkBox_P5_Senior.Visible = false;
                textBox_P6_Name.Visible = textBox_P6_Age.Visible = comboBox_P6_Birth.Visible = comboBox_P6_Gender.Visible = false;
                checkBox_P6_Child.Visible = checkBox_P6_Senior.Visible = false;
              if(comboBox_Quota.Text=="PT")  panel_PT_fare.Visible = true ;
            }
        }
    }
}
