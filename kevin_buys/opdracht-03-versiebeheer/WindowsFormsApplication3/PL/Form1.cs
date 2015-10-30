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
        public viewscore new_score;
        public Result_view result;
        public void addMemory()
        {
            if (mmCard == null)
            {
                mmCard = new Memory_cards_view();
                mmCard.Location = new Point(5, 5);
            }
            this.Controls.Add(mmCard);
        } 
        public void deleteMemory()
        {
            if (mmCard != null)
            {
                this.Controls.Remove(mmCard);
                mmCard = null;
            }
        }
        public void addScore()
        {
            if (new_score == null)
            {
                new_score = new viewscore();
                new_score.Location = new Point(480, 0);
            }
            this.Controls.Add(new_score);


        }
        public void deleteScore()
        {
            if (new_score != null)
            {
                this.Controls.Remove(new_score);
            }
        }
      
        public void addStart()
        {
            if (start == null)
            {
                start = new Start_view();
                start.Location = new Point(200, 150);
            }
            this.Controls.Add(start);

        }
        public void deleteStart()
        {
            if (start != null)
            {
                this.Controls.Remove(start);
            }
        }
       
        public void addResult()
        {
            if (result == null)
            {
                result = new Result_view();
                result.Location = new Point(120, 200);
            }
            this.Controls.Add(result);

        }
        public void deleteResult()
        {
            if (result != null)
            {
                this.Controls.Remove(result);
            }
        }
        #endregion
        #region Sound
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public void playSound(string url)
        {
            stopSound();
            wplayer.URL = Application.StartupPath + "\\Sound\\" + url;
            wplayer.controls.play();
        }
        public void stopSound()
        {
            wplayer.controls.stop();
        }
        #endregion
    } 
}
