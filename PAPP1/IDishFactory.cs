using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPP1
{
    public interface IDishFactory
    {
        IRussianDish CookRussianDish();
        IItalianDish CookItalianDish();
        IChineseDish CookChineseDish();
    }
}
