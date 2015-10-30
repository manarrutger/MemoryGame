using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazahee_test
{
    public partial class view_test : UserControl
    {

         control_yazhee_test controol;
        public view_test(control_yazhee_test cONTROL)
        {
            controol = cONTROL;
            InitializeComponent();
        }

        private void view_test_Load(object sender, EventArgs e)
        {

        }

        public void veld(string text)
        {
            textBox1.Text = controol._model.Getal_model.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controol.Random_method();
            textBox1.Text = controol._model.Getal_model.ToString();
        }
        public void butom(bool mybuttom)
        {
            button1.Visible =true;
        }
      
    }
}
