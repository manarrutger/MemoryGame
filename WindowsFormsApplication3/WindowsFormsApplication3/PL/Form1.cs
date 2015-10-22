using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addStart();
        }
    
        #region controls
         Start_view start;
         public Memory_cards_view mmCard;
        public  void addMemory()
        {
            if (mmCard == null)
            {
                mmCard = new Memory_cards_view();
                mmCard.Location = new Point(5, 5);
                this.Controls.Add(mmCard);
            }
        }
        public void deleteMemory()
        {
            if (mmCard != null)
            {
                this.Controls.Remove(mmCard);
            }
        }

        public void addStart()
        {
            if (start == null)
            {
                start = new Start_view();
                start.Location = new Point(200, 150);
                this.Controls.Add(start);
            }
        }
        public void deleteStart()
        {
            if (start != null)
            {
                this.Controls.Remove(start);
            }
        }
        #endregion

    }
}
