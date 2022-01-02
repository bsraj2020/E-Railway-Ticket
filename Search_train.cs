using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace E_Ticket_Pro_472
{
    public partial class Search_train : Form
    {

        public Search_train()
        {
            InitializeComponent();
        }

        new window_new_Ticket ParentForm = null;

        public Search_train(Form callingForm)
        {
            ParentForm = callingForm as window_new_Ticket;

            InitializeComponent();
        }

      /*  private void panel_show_1(JObject item)
        {
            lbl_1_1.Text = item.GetValue("Train_no").ToString();
            lbl_1_2.Text = item.GetValue("Train_name").ToString();
            lbl_1_3.Text = item.GetValue("From").ToString();
            lbl_1_4.Text = item.GetValue("Depa").ToString();
            lbl_1_5.Text = item.GetValue("To").ToString();
            lbl_1_6.Text = item.GetValue("Arr_time").ToString();
            lbl_1_7.Text = item.GetValue("travel_time").ToString();

            lbl_1_8.Text = item.GetValue("day1").ToString(); if (lbl_1_8.Text == "Y") lbl_1_8.ForeColor = Color.Green;
            lbl_1_9.Text = item.GetValue("day2").ToString(); if (lbl_1_9.Text == "Y") lbl_1_9.ForeColor = Color.Green;
            lbl_1_10.Text = item.GetValue("day3").ToString(); if (lbl_1_10.Text == "Y") lbl_1_10.ForeColor = Color.Green;
            lbl_1_11.Text = item.GetValue("day4").ToString(); if (lbl_1_11.Text == "Y") lbl_1_11.ForeColor = Color.Green;
            lbl_1_12.Text = item.GetValue("day5").ToString(); if (lbl_1_12.Text == "Y") lbl_1_12.ForeColor = Color.Green;
            lbl_1_13.Text = item.GetValue("day6").ToString(); if (lbl_1_13.Text == "Y") lbl_1_13.ForeColor = Color.Green;
            lbl_1_14.Text = item.GetValue("day7").ToString(); if (lbl_1_14.Text == "Y") lbl_1_14.ForeColor = Color.Green;

            lbl_1_15.Text = item.GetValue("_1A").ToString() == "true" ? "1A" : "X"; if (lbl_1_15.Text != "X") lbl_1_15.ForeColor = Color.Blue;
            lbl_1_16.Text = item.GetValue("_2A").ToString() == "true" ? "2A" : "X"; if (lbl_1_16.Text != "X") lbl_1_16.ForeColor = Color.Blue;
            lbl_1_17.Text = item.GetValue("_3A").ToString() == "true" ? "3A" : "X"; if (lbl_1_17.Text != "X") lbl_1_17.ForeColor = Color.Blue;
            lbl_1_18.Text = item.GetValue("_CC").ToString() == "true" ? "CC" : "X"; if (lbl_1_18.Text != "X") lbl_1_18.ForeColor = Color.Blue;
            lbl_1_19.Text = item.GetValue("_FC").ToString() == "true" ? "FC" : "X"; if (lbl_1_19.Text != "X") lbl_1_19.ForeColor = Color.Blue;
            lbl_1_20.Text = item.GetValue("_SL").ToString() == "true" ? "SL" : "X"; if (lbl_1_20.Text != "X") lbl_1_20.ForeColor = Color.Blue;
            lbl_1_21.Text = item.GetValue("_2S").ToString() == "true" ? "2S" : "X"; if (lbl_1_21.Text != "X") lbl_1_21.ForeColor = Color.Blue;
            lbl_1_22.Text = item.GetValue("_3E").ToString() == "true" ? "3E" : "X"; if (lbl_1_22.Text != "X") lbl_1_22.ForeColor = Color.Blue;

        }

        private void panel_show_2(JObject item)
        {
            lbl_2_1.Text = item.GetValue("Train_no").ToString();
            lbl_2_2.Text = item.GetValue("Train_name").ToString();
            lbl_2_3.Text = item.GetValue("From").ToString();
            lbl_2_4.Text = item.GetValue("Depa").ToString();
            lbl_2_5.Text = item.GetValue("To").ToString();
            lbl_2_6.Text = item.GetValue("Arr_time").ToString();
            lbl_2_7.Text = item.GetValue("travel_time").ToString();
                
            lbl_2_8.Text = item.GetValue("day1").ToString();   if(lbl_2_8.Text == "Y") lbl_2_8.ForeColor = Color.Green;
            lbl_2_9.Text = item.GetValue("day2").ToString();   if(lbl_2_9.Text == "Y") lbl_2_9.ForeColor = Color.Green;
            lbl_2_10.Text = item.GetValue("day3").ToString(); if (lbl_2_10.Text == "Y") lbl_2_10.ForeColor = Color.Green;
            lbl_2_11.Text = item.GetValue("day4").ToString(); if (lbl_2_11.Text == "Y") lbl_2_11.ForeColor = Color.Green;
            lbl_2_12.Text = item.GetValue("day5").ToString(); if (lbl_2_12.Text == "Y") lbl_2_12.ForeColor = Color.Green;
            lbl_2_13.Text = item.GetValue("day6").ToString(); if (lbl_2_13.Text == "Y") lbl_2_13.ForeColor = Color.Green;
            lbl_2_14.Text = item.GetValue("day7").ToString(); if (lbl_2_14.Text == "Y") lbl_2_14.ForeColor = Color.Green;
                
            lbl_2_15.Text = item.GetValue("_1A").ToString() == "true" ? "1A" : "X"; if (lbl_2_15.Text != "X") lbl_2_15.ForeColor = Color.Blue;
            lbl_2_16.Text = item.GetValue("_2A").ToString() == "true" ? "2A" : "X"; if (lbl_2_16.Text != "X") lbl_2_16.ForeColor = Color.Blue;
            lbl_2_17.Text = item.GetValue("_3A").ToString() == "true" ? "3A" : "X"; if (lbl_2_17.Text != "X") lbl_2_17.ForeColor = Color.Blue;
            lbl_2_18.Text = item.GetValue("_CC").ToString() == "true" ? "CC" : "X"; if (lbl_2_18.Text != "X") lbl_2_18.ForeColor = Color.Blue;
            lbl_2_19.Text = item.GetValue("_FC").ToString() == "true" ? "FC" : "X"; if (lbl_2_19.Text != "X") lbl_2_19.ForeColor = Color.Blue;
            lbl_2_20.Text = item.GetValue("_SL").ToString() == "true" ? "SL" : "X"; if (lbl_2_20.Text != "X") lbl_2_20.ForeColor = Color.Blue;
            lbl_2_21.Text = item.GetValue("_2S").ToString() == "true" ? "2S" : "X"; if (lbl_2_21.Text != "X") lbl_2_21.ForeColor = Color.Blue;
            lbl_2_22.Text = item.GetValue("_3E").ToString() == "true" ? "3E" : "X"; if (lbl_2_22.Text != "X") lbl_2_22.ForeColor = Color.Blue;

        }

        private void panel_show_3(JObject item)
        {
            lbl_3_1.Text = item.GetValue("Train_no").ToString();
            lbl_3_2.Text = item.GetValue("Train_name").ToString();
            lbl_3_3.Text = item.GetValue("From").ToString();
            lbl_3_4.Text = item.GetValue("Depa").ToString();
            lbl_3_5.Text = item.GetValue("To").ToString();
            lbl_3_6.Text = item.GetValue("Arr_time").ToString();
            lbl_3_7.Text = item.GetValue("travel_time").ToString();

            lbl_3_8.Text = item.GetValue("day1").ToString();  if (lbl_3_8.Text == "Y")   lbl_3_8.ForeColor = Color.Green;
            lbl_3_9.Text = item.GetValue("day2").ToString();  if (lbl_3_9.Text == "Y")   lbl_3_9.ForeColor = Color.Green;
            lbl_3_10.Text = item.GetValue("day3").ToString(); if (lbl_3_10.Text == "Y") lbl_3_10.ForeColor = Color.Green;
            lbl_3_11.Text = item.GetValue("day4").ToString(); if (lbl_3_11.Text == "Y") lbl_3_11.ForeColor = Color.Green;
            lbl_3_12.Text = item.GetValue("day5").ToString(); if (lbl_3_12.Text == "Y") lbl_3_12.ForeColor = Color.Green;
            lbl_3_13.Text = item.GetValue("day6").ToString(); if (lbl_3_13.Text == "Y") lbl_3_13.ForeColor = Color.Green;
            lbl_3_14.Text = item.GetValue("day7").ToString(); if (lbl_3_14.Text == "Y") lbl_3_14.ForeColor = Color.Green;

            lbl_3_15.Text = item.GetValue("_1A").ToString() == "true" ? "1A" : "X"; if (lbl_3_15.Text != "X") lbl_3_15.ForeColor = Color.Blue;
            lbl_3_16.Text = item.GetValue("_2A").ToString() == "true" ? "2A" : "X"; if (lbl_3_16.Text != "X") lbl_3_16.ForeColor = Color.Blue;
            lbl_3_17.Text = item.GetValue("_3A").ToString() == "true" ? "3A" : "X"; if (lbl_3_17.Text != "X") lbl_3_17.ForeColor = Color.Blue;
            lbl_3_18.Text = item.GetValue("_CC").ToString() == "true" ? "CC" : "X"; if (lbl_3_18.Text != "X") lbl_3_18.ForeColor = Color.Blue;
            lbl_3_19.Text = item.GetValue("_FC").ToString() == "true" ? "FC" : "X"; if (lbl_3_19.Text != "X") lbl_3_19.ForeColor = Color.Blue;
            lbl_3_20.Text = item.GetValue("_SL").ToString() == "true" ? "SL" : "X"; if (lbl_3_20.Text != "X") lbl_3_20.ForeColor = Color.Blue;
            lbl_3_21.Text = item.GetValue("_2S").ToString() == "true" ? "2S" : "X"; if (lbl_3_21.Text != "X") lbl_3_21.ForeColor = Color.Blue;
            lbl_3_22.Text = item.GetValue("_3E").ToString() == "true" ? "3E" : "X"; if (lbl_3_22.Text != "X") lbl_3_22.ForeColor = Color.Blue;

        }*/

        


        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void Search_train_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            string URL = "http://127.0.0.1:3000/train_search";

            URL +=  "?from=" + ParentForm.textBox_From.Text + "&to=" + ParentForm.textBox_To.Text;
            //URL += "?from=FA";
            string res = await RestAPI_Helper.All_trains(URL);

            // Train_textBox.Text = res;
            JArray json_arr = JArray.Parse(res);
           // json_arr.ToString(Newtonsoft.Json.Formatting.Indented);
            //Train_textBox.Text = json[0]['To;
            // var jsonObj = new JavaScriptSerializer().Deserialize<RootObj>(json);
            int i = 1;
            
            foreach (JObject item in json_arr)
            {

                //{ "Train_no":"22950","_2S":true,"_SL":true,"_3A":true,"_2A":true,"day1":"X","day2":"X","day3":"X",
                //   "day4":"X","day5":"X","day6":"Y","day7":"X","travel_time":"13:25H","Arr_time":"15:00","To":"BDTS",
                ///    "Depa":"01:35","Train_name_from":"DEE BDTS SF EXPFA","From":"FA","Train_name":"DEE BDTS SF EXP"}


                //sirf deshi jugad lgaya hai ,, achhe se krna bad me

                var DATE= (int) new window_new_Ticket().dateTimePicker_new_ticket.Value.DayOfWeek;
               // MessageBox.Show(DATE.ToString());

                if (item.GetValue($"day{DATE + 1}").ToString() == "X") continue;

                
/*
                if (i == 1) panel_show_1(item);
                else if (i == 2) panel_show_2(item);
                else if (i == 3) panel_show_3(item); i++;*/
            }
        }

       /* private void lbl_1_15_Click(object sender, EventArgs e)
        {
            if (lbl_1_15.Text == "X") return;

            var QUOTA = "Not_Selcected" ;
            if (radioButton_CK.Checked == true) QUOTA = "CK";
            else if (radioButton_GN.Checked == true) QUOTA = "GN";
            else if (radioButton_PT.Checked == true) QUOTA = "PT";
            else if (radioButton_LD.Checked == true) QUOTA = "LD";

            DialogResult dr = MessageBox.Show($"Selecting 1A and {QUOTA} Quota in {lbl_1_1.Text}", $"Want to select {lbl_1_2.Text}", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if(DialogResult.Yes==dr)
            {
                ParentForm.comboBox_Quota.Text = QUOTA;
                ParentForm.comboBox_Class.Text = "1A";
                ParentForm.textBox_TrainNo.Text = lbl_1_1.Text;
                ParentForm.textBox_Boarding.Text = ParentForm.textBox_From.Text;
                this.Close();
            }
        }*/

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lbl_1_16_Click(object sender, EventArgs e)
        {
             
        }

        private void lbl_1_17_Click(object sender, EventArgs e)
        {

        }
    }
}
