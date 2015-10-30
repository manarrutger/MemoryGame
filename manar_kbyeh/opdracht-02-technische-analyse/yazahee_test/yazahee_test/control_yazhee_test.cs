using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazahee_test
{
    
 public   class control_yazhee_test
    {
       public model_yazhee_test _model;
        view_test _view;
        static int teller = 0;
        static int scoren = 0;

        Random random_getal = new Random(++teller);

        public view_test getview()
        {
            return _view;
        }
        public control_yazhee_test()
        {
            _model = new model_yazhee_test();
            _view = new view_test(this);

        }
        public void Random_method()
        {

            int willkeurig_getal = random_getal.Next(1, 7);
            _model.Getal_model = willkeurig_getal;
            score();
        }

        public void score()
        {
         
            _model.Scoren += _model.Getal_model;
          
           
        }
    }
}
