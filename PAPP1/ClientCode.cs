using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPP1
{
    public class ClientCode
    {
        private IRussianDish russianDish;
        private IItalianDish italianDish;
        private IChineseDish chineseDish;
        public ClientCode(IDishFactory dish)
        {
            russianDish = dish.CookRussianDish();
            italianDish = dish.CookItalianDish();
            chineseDish = dish.CookChineseDish();
        }
        public void MakeRDish()
        {
            russianDish.MakeRDish();
        }
        public void MakeIDish()
        {
            italianDish.MakeIDish();
        }
        public void MakeCDish()
        {
            chineseDish.MakeCDish();
        }
    }
}
