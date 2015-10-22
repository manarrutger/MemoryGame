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
    public partial class Memory_cards_view : UserControl
    {
        Game gm = new Game();
        public Memory_cards_view()
        {
            InitializeComponent();

        }

        private void pb1_Click(object sender, EventArgs e)
        {
           
            var pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                int index = Int32.Parse(pictureBox.Tag.ToString());
                object o = Properties.Resources.ResourceManager.GetObject(gm.deck_of_cards[index]);

                pictureBox.Image = (Image)o;
                Task.Delay(1000).Wait();
                gm.name_card.Add(gm.deck_of_cards[index]);
                 pbs.Add(pictureBox);
                
                 if (gm.check_card())
                 {
                     flipCard();
                 }
               
            }
        }



        #region flip
        List<PictureBox> pbs = new List<PictureBox>();
        public void flipCard()
        {
            if (pbs.Count == 2)
            {
                foreach (var pb in pbs)
                {
                    object o = Properties.Resources.ResourceManager.GetObject("front");
                    pb.Image = (Image)o;
                }
                pbs.RemoveRange(0, 2);
            }
        }

        #endregion
    }

}