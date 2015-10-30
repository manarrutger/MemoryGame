using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.PL
{
    public partial class Start_view : UserControl
    {
        BL.New_Game cntNewGame = new BL.New_Game();

        public Start_view()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cntNewGame.verif_Namne(txtBName.Text))
            {
                
                lblErr.Text = "uw naam invullen";
             
            }
           
        }

        private void txtBName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
