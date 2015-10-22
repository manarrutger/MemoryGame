using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.DAL
{
    class Player
    {
      public Player(string name )
        {
            this.name = name;
            this.score = 0;
            this.hightScore = 0;
        }

        public string name { get; set; }
        public long score { get; set; }
        public long hightScore { get; set; }
    }
}
