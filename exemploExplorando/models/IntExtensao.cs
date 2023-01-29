using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.models
{
    public static class IntExtensao
    {
        //this int significa que está estendento o comportamento do inteiro
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}