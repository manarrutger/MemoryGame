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
    public partial class scorenboord : UserControl
    {
        controle_score control_soren;
        public scorenboord()
        {
            InitializeComponent();
        }
      public  scorenboord(controle_score controlen)
        {
            control_soren = controlen;

        }

       public void method1(int getal){
          Console.WriteLine(getal);
           textBox1.Text = getal.ToString();


       }
       public void method2(int getal)
       {
           textBox2.Text = getal.ToString();
         

       }
       public void method3(int getal)
       {
           textBox3.Text = getal.ToString();

       }


       private void scorenboord_Load(object sender, EventArgs e)
       {
           
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
         
       }
    }
}
