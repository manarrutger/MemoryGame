using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazahee_test
{
  public  class controle_score
      
    {
      
     public   modelscore _model_score;
    public    scorenboord _boord_score;
        public controle_score()
        {
            _model_score = new modelscore();
            _boord_score = new scorenboord();

        }

        public scorenboord Get_view_score()
        {
            return _boord_score;
        }

  

    }
}
