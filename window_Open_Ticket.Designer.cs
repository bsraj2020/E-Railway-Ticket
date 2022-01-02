
namespace E_Ticket_Pro_472
{
    partial class window_Open_Ticket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_All_Tickets = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_SelectedTicket = new System.Windows.Forms.ComboBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.btn_pair = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 35);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(728, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Journey Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Train";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Name";
            // 
            // dataGridView_All_Tickets
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_All_Tickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_All_Tickets.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_All_Tickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_All_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_All_Tickets.Location = new System.Drawing.Point(0, 75);
            this.dataGridView_All_Tickets.Name = "dataGridView_All_Tickets";
            this.dataGridView_All_Tickets.ReadOnly = true;
            this.dataGridView_All_Tickets.Size = new System.Drawing.Size(801, 265);
            this.dataGridView_All_Tickets.TabIndex = 1;
            this.dataGridView_All_Tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_All_Tickets_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(16, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Selected Ticket";
            // 
            // comboBox_SelectedTicket
            // 
            this.comboBox_SelectedTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelectedTicket.FormattingEnabled = true;
            this.comboBox_SelectedTicket.Location = new System.Drawing.Point(19, 375);
            this.comboBox_SelectedTicket.Name = "comboBox_SelectedTicket";
            this.comboBox_SelectedTicket.Size = new System.Drawing.Size(128, 21);
            this.comboBox_SelectedTicket.TabIndex = 3;
            // 
            // button_Open
            // 
            this.button_Open.BackColor = System.Drawing.Color.Gray;
            this.button_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Open.Location = new System.Drawing.Point(192, 356);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 42);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = false;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // btn_pair
            // 
            this.btn_pair.Enabled = false;
            this.btn_pair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pair.Location = new System.Drawing.Point(449, 367);
            this.btn_pair.Name = "btn_pair";
            this.btn_pair.Size = new System.Drawing.Size(75, 29);
            this.btn_pair.TabIndex = 4;
            this.btn_pair.Text = "Pair";
            this.btn_pair.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DimGray;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(348, 367);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Peru;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(541, 367);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 29);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.bttn_Edit_Click);
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteAll.Location = new System.Drawing.Point(681, 369);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(107, 29);
            this.btn_DeleteAll.TabIndex = 4;
            this.btn_DeleteAll.Text = "Delete All";
            this.btn_DeleteAll.UseVisualStyleBackColor = false;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // window_Open_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_pair);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.comboBox_SelectedTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_All_Tickets);
            this.Controls.Add(this.panel1);
            this.Name = "window_Open_Ticket";
            this.Text = "Open Ticket";
            this.Load += new System.EventHandler(this.window_Open_Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_All_Tickets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_SelectedTicket;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button btn_pair;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_DeleteAll;
    }
}