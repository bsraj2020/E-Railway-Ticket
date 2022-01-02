
namespace E_Ticket_Pro_472
{
    partial class window_Add_Id
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.btn_Save_Id = new System.Windows.Forms.Button();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_ADD_Id = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_selectTodelete = new System.Windows.Forms.ComboBox();
            this.btn_Delete_id = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_deleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADD_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(90, 40);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 21);
            this.textBox_username.TabIndex = 1;
            // 
            // btn_Save_Id
            // 
            this.btn_Save_Id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Save_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Id.Location = new System.Drawing.Point(457, 33);
            this.btn_Save_Id.Name = "btn_Save_Id";
            this.btn_Save_Id.Size = new System.Drawing.Size(75, 34);
            this.btn_Save_Id.TabIndex = 3;
            this.btn_Save_Id.Text = "Save ";
            this.btn_Save_Id.UseVisualStyleBackColor = false;
            this.btn_Save_Id.Click += new System.EventHandler(this.btn_Save_Id_Click);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_up.Location = new System.Drawing.Point(604, 33);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(75, 33);
            this.btn_sign_up.TabIndex = 4;
            this.btn_sign_up.Text = "Sign Up";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password : ";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(291, 42);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(124, 21);
            this.textBox_password.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "All IRCTC Id\'s :";
            // 
            // dataGridView_ADD_Id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ADD_Id.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ADD_Id.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_ADD_Id.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ADD_Id.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ADD_Id.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ADD_Id.ColumnHeadersVisible = false;
            this.dataGridView_ADD_Id.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView_ADD_Id.Location = new System.Drawing.Point(12, 149);
            this.dataGridView_ADD_Id.Name = "dataGridView_ADD_Id";
            this.dataGridView_ADD_Id.ReadOnly = true;
            this.dataGridView_ADD_Id.RowHeadersWidth = 60;
            this.dataGridView_ADD_Id.Size = new System.Drawing.Size(348, 225);
            this.dataGridView_ADD_Id.TabIndex = 31;
            this.dataGridView_ADD_Id.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ADD_Id_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            // 
            // comboBox_selectTodelete
            // 
            this.comboBox_selectTodelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectTodelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectTodelete.FormattingEnabled = true;
            this.comboBox_selectTodelete.Location = new System.Drawing.Point(530, 215);
            this.comboBox_selectTodelete.Name = "comboBox_selectTodelete";
            this.comboBox_selectTodelete.Size = new System.Drawing.Size(121, 21);
            this.comboBox_selectTodelete.TabIndex = 4;
            // 
            // btn_Delete_id
            // 
            this.btn_Delete_id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Delete_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_id.Location = new System.Drawing.Point(530, 251);
            this.btn_Delete_id.Name = "btn_Delete_id";
            this.btn_Delete_id.Size = new System.Drawing.Size(95, 34);
            this.btn_Delete_id.TabIndex = 121;
            this.btn_Delete_id.Text = "Delete";
            this.btn_Delete_id.UseVisualStyleBackColor = false;
            this.btn_Delete_id.Click += new System.EventHandler(this.btn_Delete_id_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(527, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select ID to Delete :";
            // 
            // button_deleteAll
            // 
            this.button_deleteAll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteAll.Location = new System.Drawing.Point(530, 319);
            this.button_deleteAll.Name = "button_deleteAll";
            this.button_deleteAll.Size = new System.Drawing.Size(95, 34);
            this.button_deleteAll.TabIndex = 121;
            this.button_deleteAll.Text = "Delete All";
            this.button_deleteAll.UseVisualStyleBackColor = false;
            this.button_deleteAll.Click += new System.EventHandler(this.button_deleteAll_Click);
            // 
            // window_Add_Id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 375);
            this.Controls.Add(this.comboBox_selectTodelete);
            this.Controls.Add(this.dataGridView_ADD_Id);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.button_deleteAll);
            this.Controls.Add(this.btn_Delete_id);
            this.Controls.Add(this.btn_Save_Id);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "window_Add_Id";
            this.Text = "Add / Delete Id";
            this.Load += new System.EventHandler(this.window_Add_Id_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ADD_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button btn_Save_Id;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_ADD_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_selectTodelete;
        private System.Windows.Forms.Button btn_Delete_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_deleteAll;
    }
}