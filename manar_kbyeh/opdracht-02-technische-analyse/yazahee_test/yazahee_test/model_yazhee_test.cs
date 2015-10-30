using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazahee_test
{
  public  class model_yazhee_test
    {

        int getal_model;
        static int scoren = 0;

        bool botom = false;
        public int Getal_model
        {
            get
            {
              return  getal_model;
            }
            set
            {
                getal_model = value;
            }
        }
        public bool Botom
        {
            get
            {
                return botom;
            }
            set
            {
                botom = value;
            }
        }
        public int Scoren
        {
            get
            {
                return scoren;
            }
            set
            {
                scoren = value;
            }
        }
    }
}
