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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public state slectedstate
        {
            get
            {
                return (state)cbostate.SelectedItem;
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<state> list = new List<state>();
            list.Add(new state() { ID = 1, name = "Amman" });
            list.Add(new state() { ID = 2, name = "Irbid" });
            list.Add(new state() { ID = 3, name = "Aqaba" });
            list.Add(new state() { ID = 4, name = "karak" });
            cbostate.DataSource = list;
            cbostate.ValueMember = "ID";
            cbostate.DisplayMember = "name";
        }
    }
}
