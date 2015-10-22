using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.DAL;
using WindowsFormsApplication3.PL;

namespace WindowsFormsApplication3.BL
{

    class New_Game
    {
        public Player pl;
     

        // hier kan je de naam bevestigen en de papieren in de willkeurige volgode komen

        public bool verif_Namne(string naam)
        {
            if (naam.Trim() != "")
            {
                pl = new Player(naam);

                
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).deleteStart();
                    // كتابة الكود الي هيعمل اللعبة 
                    // تغيير اماكن الصور 
                    // ترتيب الصور 
                    //الخ 
                  
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).addMemory();
                }
                return true;
            }
            else
            {
                return false;
            }


        }

       
    }
}
