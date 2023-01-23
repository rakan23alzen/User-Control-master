using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("state id = {0}, name = {1}", userControl11.slectedstate.ID, userControl11.slectedstate.name), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
