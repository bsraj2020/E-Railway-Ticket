
namespace E_Ticket_Pro_472
{
    partial class window_Add_bank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SelectPaymentGateway = new System.Windows.Forms.ComboBox();
            this.groupBox_Netbanking = new System.Windows.Forms.GroupBox();
            this.btn_save_netbank = new System.Windows.Forms.Button();
            this.textBox_bank_password = new System.Windows.Forms.TextBox();
            this.textBox_bank_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_UPI = new System.Windows.Forms.GroupBox();
            this.btn_save_UPI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UPI_id = new System.Windows.Forms.TextBox();
            this.dataGridView_BankDetails = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete_bank = new System.Windows.Forms.Button();
            this.comboBox_Bank_toDelete = new System.Windows.Forms.ComboBox();
            this.btn_Delete_All = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_Netbanking.SuspendLayout();
            this.groupBox_UPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BankDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Payment Gateway :";
            // 
            // comboBox_SelectPaymentGateway
            // 
            this.comboBox_SelectPaymentGateway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectPaymentGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectPaymentGateway.FormattingEnabled = true;
            this.comboBox_SelectPaymentGateway.Items.AddRange(new object[] {
            "BHIM UPI",
            "SBI Net Banking",
            "HDFC Net Banking",
            "ICICI Net Banking",
            "YES Bank Net Banking"});
            this.comboBox_SelectPaymentGateway.Location = new System.Drawing.Point(54, 47);
            this.comboBox_SelectPaymentGateway.Name = "comboBox_SelectPaymentGateway";
            this.comboBox_SelectPaymentGateway.Size = new System.Drawing.Size(175, 21);
            this.comboBox_SelectPaymentGateway.TabIndex = 1;
            this.comboBox_SelectPaymentGateway.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectPaymentGateway_SelectedIndexChanged);
            // 
            // groupBox_Netbanking
            // 
            this.groupBox_Netbanking.Controls.Add(this.btn_save_netbank);
            this.groupBox_Netbanking.Controls.Add(this.textBox_bank_password);
            this.groupBox_Netbanking.Controls.Add(this.textBox_bank_username);
            this.groupBox_Netbanking.Controls.Add(this.label3);
            this.groupBox_Netbanking.Controls.Add(this.label2);
            this.groupBox_Netbanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Netbanking.Location = new System.Drawing.Point(39, 97);
            this.groupBox_Netbanking.Name = "groupBox_Netbanking";
            this.groupBox_Netbanking.Size = new System.Drawing.Size(234, 121);
            this.groupBox_Netbanking.TabIndex = 2;
            this.groupBox_Netbanking.TabStop = false;
            this.groupBox_Netbanking.Text = "Net Banking";
            this.groupBox_Netbanking.Visible = false;
            // 
            // btn_save_netbank
            // 
            this.btn_save_netbank.Location = new System.Drawing.Point(84, 79);
            this.btn_save_netbank.Name = "btn_save_netbank";
            this.btn_save_netbank.Size = new System.Drawing.Size(75, 33);
            this.btn_save_netbank.TabIndex = 2;
            this.btn_save_netbank.Text = "Save";
            this.btn_save_netbank.UseVisualStyleBackColor = true;
            this.btn_save_netbank.Click += new System.EventHandler(this.btn_save_netbank_Click);
            // 
            // textBox_bank_password
            // 
            this.textBox_bank_password.Location = new System.Drawing.Point(84, 53);
            this.textBox_bank_password.Name = "textBox_bank_password";
            this.textBox_bank_password.Size = new System.Drawing.Size(144, 20);
            this.textBox_bank_password.TabIndex = 1;
            // 
            // textBox_bank_username
            // 
            this.textBox_bank_username.Location = new System.Drawing.Point(84, 30);
            this.textBox_bank_username.Name = "textBox_bank_username";
            this.textBox_bank_username.Size = new System.Drawing.Size(144, 20);
            this.textBox_bank_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // groupBox_UPI
            // 
            this.groupBox_UPI.Controls.Add(this.btn_save_UPI);
            this.groupBox_UPI.Controls.Add(this.label4);
            this.groupBox_UPI.Controls.Add(this.textBox_UPI_id);
            this.groupBox_UPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_UPI.Location = new System.Drawing.Point(39, 97);
            this.groupBox_UPI.Name = "groupBox_UPI";
            this.groupBox_UPI.Size = new System.Drawing.Size(244, 94);
            this.groupBox_UPI.TabIndex = 3;
            this.groupBox_UPI.TabStop = false;
            this.groupBox_UPI.Text = "BHIM UPI";
            this.groupBox_UPI.Visible = false;
            // 
            // btn_save_UPI
            // 
            this.btn_save_UPI.Location = new System.Drawing.Point(75, 48);
            this.btn_save_UPI.Name = "btn_save_UPI";
            this.btn_save_UPI.Size = new System.Drawing.Size(75, 33);
            this.btn_save_UPI.TabIndex = 2;
            this.btn_save_UPI.Text = "Save";
            this.btn_save_UPI.UseVisualStyleBackColor = true;
            this.btn_save_UPI.Click += new System.EventHandler(this.btn_save_UPI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "UPI Id :";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_UPI_id
            // 
            this.textBox_UPI_id.Location = new System.Drawing.Point(54, 22);
            this.textBox_UPI_id.Name = "textBox_UPI_id";
            this.textBox_UPI_id.Size = new System.Drawing.Size(161, 20);
            this.textBox_UPI_id.TabIndex = 1;
            // 
            // dataGridView_BankDetails
            // 
            this.dataGridView_BankDetails.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_BankDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BankDetails.Location = new System.Drawing.Point(289, 47);
            this.dataGridView_BankDetails.Name = "dataGridView_BankDetails";
            this.dataGridView_BankDetails.ReadOnly = true;
            this.dataGridView_BankDetails.Size = new System.Drawing.Size(473, 179);
            this.dataGridView_BankDetails.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(390, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "All Saved Payment Gateways";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(390, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select Bank Detail  to Delete :";
            // 
            // btn_delete_bank
            // 
            this.btn_delete_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_bank.Location = new System.Drawing.Point(393, 300);
            this.btn_delete_bank.Name = "btn_delete_bank";
            this.btn_delete_bank.Size = new System.Drawing.Size(75, 33);
            this.btn_delete_bank.TabIndex = 2;
            this.btn_delete_bank.Text = "Delete";
            this.btn_delete_bank.UseVisualStyleBackColor = true;
            this.btn_delete_bank.Click += new System.EventHandler(this.btn_delete_bank_Click);
            // 
            // comboBox_Bank_toDelete
            // 
            this.comboBox_Bank_toDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bank_toDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Bank_toDelete.FormattingEnabled = true;
            this.comboBox_Bank_toDelete.Location = new System.Drawing.Point(393, 267);
            this.comboBox_Bank_toDelete.Name = "comboBox_Bank_toDelete";
            this.comboBox_Bank_toDelete.Size = new System.Drawing.Size(175, 21);
            this.comboBox_Bank_toDelete.TabIndex = 1;
            // 
            // btn_Delete_All
            // 
            this.btn_Delete_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_All.Location = new System.Drawing.Point(493, 361);
            this.btn_Delete_All.Name = "btn_Delete_All";
            this.btn_Delete_All.Size = new System.Drawing.Size(75, 33);
            this.btn_Delete_All.TabIndex = 2;
            this.btn_Delete_All.Text = "Delete All";
            this.btn_Delete_All.UseVisualStyleBackColor = true;
            this.btn_Delete_All.Click += new System.EventHandler(this.btn_Delete_All_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gateway Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "BHIM UPI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Password";
            // 
            // window_Add_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 406);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete_All);
            this.Controls.Add(this.groupBox_UPI);
            this.Controls.Add(this.btn_delete_bank);
            this.Controls.Add(this.dataGridView_BankDetails);
            this.Controls.Add(this.groupBox_Netbanking);
            this.Controls.Add(this.comboBox_Bank_toDelete);
            this.Controls.Add(this.comboBox_SelectPaymentGateway);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "window_Add_bank";
            this.Text = "Add / Delete Bank";
            this.Load += new System.EventHandler(this.window_Add_bank_Load);
            this.groupBox_Netbanking.ResumeLayout(false);
            this.groupBox_Netbanking.PerformLayout();
            this.groupBox_UPI.ResumeLayout(false);
            this.groupBox_UPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BankDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SelectPaymentGateway;
        private System.Windows.Forms.GroupBox groupBox_Netbanking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save_netbank;
        private System.Windows.Forms.TextBox textBox_bank_password;
        private System.Windows.Forms.TextBox textBox_bank_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_UPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UPI_id;
        private System.Windows.Forms.Button btn_save_UPI;
        private System.Windows.Forms.DataGridView dataGridView_BankDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete_bank;
        private System.Windows.Forms.ComboBox comboBox_Bank_toDelete;
        private System.Windows.Forms.Button btn_Delete_All;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}