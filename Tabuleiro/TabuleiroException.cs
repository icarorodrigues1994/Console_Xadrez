using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabuleiro
{
     class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base (msg){

        }
    }
}