using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    // Tomma metoder “kravspec” i den abstrakta IMethodes som måste byggas vid implementering

    internal interface iMethods
    {
        void Use();

        void Buy();

        void Description(int desRäknare);

    }
}
