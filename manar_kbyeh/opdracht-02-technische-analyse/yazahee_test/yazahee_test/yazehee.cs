using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazahee_test
{
    public partial class yazehee : Form
    {
         List<control_yazhee_test> Yazhee_list = new List<control_yazhee_test>();

         List<controle_score> sore_list = new List<controle_score>();

         controle_score itemen = new controle_score();

      protected  int teller=0;
      protected int highScore = 0;

        public yazehee()
        {
            InitializeComponent();
        }
       

        private void yazehee_Load(object sender, EventArgs e)
        {
         
            int aantalteering = 5;
            for (int i = 0; i < aantalteering; i++)
            {
                control_yazhee_test item = new control_yazhee_test();
                Yazhee_list.Add(item);



            }
            for (int i = 0; i < aantalteering; i++)
            {
                control_yazhee_test huidigeteering = Yazhee_list[i];
                view_test myhuideteering = huidigeteering.getview();
                int positie = myhuideteering.Width * i;
                myhuideteering.Location = new Point(positie, 0);
                Controls.Add(myhuideteering);

            }
            itemen.Get_view_score().Location = new Point(220, 150);

            Controls.Add(itemen.Get_view_score());
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (teller < 3)
            {
                teller++;
            foreach (control_yazhee_test item in Yazhee_list)
            {
               
               
                    item.Random_method();
                item.getview().veld(item._model.Getal_model.ToString());

                
                    
                }

            

            sore_list.Add(itemen);



            itemen.Get_view_score().method1(teller);
            itemen.Get_view_score().method2(Yazhee_list[0]._model.Scoren);
            if (Yazhee_list[0]._model.Scoren > highScore)
            {
                highScore = Yazhee_list[0]._model.Scoren;
                itemen.Get_view_score().method3(Yazhee_list[0]._model.Scoren);
            }
            Yazhee_list[0]._model.Scoren = 0;
             
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Visible = !button1.Visible;
                
                foreach (control_yazhee_test item in Yazhee_list)
                {
                    item.getview().butom(item._model.Botom);

                    
                }
           
            }
        }
    }

