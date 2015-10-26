using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.BL;

namespace WindowsFormsApplication3.PL
{
    public partial class Result_view : UserControl
    {
        Game gm = new Game();
        public Result_view()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            gm.replay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
