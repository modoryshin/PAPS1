using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPP1
{
    class DishFactory2:IDishFactory
    {
        private static DishFactory2 instance;
        public IRussianDish CookRussianDish()
        {
            return new RussianDish2();
        }
        public IItalianDish CookItalianDish()
        {
            return new ItalianDish2();
        }
        public IChineseDish CookChineseDish()
        {
            return new ChineseDish2();
        }
        public static DishFactory2 getInstance()
        {
            if (instance == null)
                instance = new DishFactory2();
            return instance;
        }
    }
}
