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
     
      

        public bool verif_Namne(string naam)
        {
            if (naam.Trim() != "")
            {
                Player.naam = naam;
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    var frm = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1);

                    frm.deleteStart();
                                       
                    frm.addMemory();
                    frm.addScore();
                    frm.new_score.lblNaam.Text = Player.naam;
                    frm.new_score.lblScore.Text = Player.score.ToString();
                    frm.new_score.lblError.Text = Player.error.ToString();
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
