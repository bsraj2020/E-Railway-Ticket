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
    public partial class window_Add_Id : Form
    {
        DBAccess dBAccess = new DBAccess();


        public window_Add_Id()
        {
            InitializeComponent();
        }
        
        private void  Refresh_dataGrid_Id()
        {
            DataTable dt_ID = new DataTable();
            string query = "select ID_username,ID_password from ID_table";
            dBAccess.ReadDataThroughAdapter(query, dt_ID);

            comboBox_selectTodelete.DataSource = dt_ID;
            comboBox_selectTodelete.DisplayMember = "ID_username";

            dataGridView_ADD_Id.DataSource = dt_ID;
            //spread DatagGrid Columns on available area 
            int leftWidth = dataGridView_ADD_Id.Width - dataGridView_ADD_Id.RowHeadersWidth;
            dataGridView_ADD_Id.Columns[0].Width = leftWidth / 2 - 2;
            dataGridView_ADD_Id.Columns[1].Width = leftWidth / 2 - 2;
        }
        private void btn_Save_Id_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "") MessageBox.Show("Please Enter Valid Username");
            else if (textBox_password.Text == "") MessageBox.Show("Please Enter Valid Password");

            else
            {
                SQLiteCommand insertcommand = new SQLiteCommand("insert into ID_table(ID_username,ID_password) values(@username , @password) ");

                insertcommand.Parameters.AddWithValue("@username", textBox_username.Text);
                insertcommand.Parameters.AddWithValue("@password", textBox_password.Text);

                int rows = dBAccess.ExecuteQuery(insertcommand);

                if (rows > 0)  //Affected rows
                {
                    MessageBox.Show("Id Saved Succesfully");
                    textBox_username.Text = ""; textBox_password.Text = "";
                    

                    Refresh_dataGrid_Id();
                    

                }
                else MessageBox.Show("Unable to Save ID ,Please Try again") ;
                   
            }


            


            

        }

        private void window_Add_Id_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            DataTable dt_ID = new DataTable();
            string query = "select ID_username,ID_password from ID_table";
            dBAccess.ReadDataThroughAdapter(query, dt_ID);

            comboBox_selectTodelete.DataSource = dt_ID;
            comboBox_selectTodelete.DisplayMember = "ID_username";

            dataGridView_ADD_Id.DataSource = dt_ID;
            int leftWidth = dataGridView_ADD_Id.Width - dataGridView_ADD_Id.RowHeadersWidth;
            dataGridView_ADD_Id.Columns[0].Width = leftWidth/2 -2 ;
            dataGridView_ADD_Id.Columns[1].Width = leftWidth/2 -2 ;

            for(int i=0;i<dataGridView_ADD_Id.Columns.Count; i++)
            { 
                dataGridView_ADD_Id.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView_ADD_Id.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);





        }

        private void btn_Delete_id_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Want to Delete Selected Id", "Delete Id", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                   

                    SQLiteCommand commad = new SQLiteCommand("delete from ID_table where ID_username='" + comboBox_selectTodelete.Text + "'");
                    int rows = dBAccess.ExecuteQuery(commad);

                    if (rows > 0)
                    {
                        MessageBox.Show("Irctc Id Deleted Succesfully");
                       

                        Refresh_dataGrid_Id();



                    }
                    else MessageBox.Show("Unable to delete Id . Please Try again");

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button_deleteAll_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show("Want to Delete All Id", "Delete ALl Ids", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    SQLiteCommand commad = new SQLiteCommand("truncate table ID_table ");
                    int rows = 123; //random beacuse truncate ExecuteNonQuery return -1;
                    rows = dBAccess.ExecuteQuery(commad);

                    if (rows == -1)
                    {
                        MessageBox.Show("Irctc Ids Deleted Succesfully");
                        this.Close();

                        Refresh_dataGrid_Id();
                    }
                    else MessageBox.Show("Unable to delete Id . Please Try again");

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView_ADD_Id_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
