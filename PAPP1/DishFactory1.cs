using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPP1
{
    public class DishFactory1: IDishFactory
    {
        private static DishFactory1 instance;
        public IRussianDish CookRussianDish()
        {
            return new RussianDish1();
        }
        public IItalianDish CookItalianDish()
        {
            return new ItalianDish1();
        }
        public IChineseDish CookChineseDish()
        {
            return new ChineseDish1();
        }
        public static DishFactory1 getInstance()
        {
            if (instance == null)
                instance = new DishFactory1();
            return instance;
        }
    }
}
