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
    public partial class How_to_use : Form
    {
        public How_to_use()
        {
            InitializeComponent();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void How_to_use_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
