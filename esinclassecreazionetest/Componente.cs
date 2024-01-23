using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esinclassecreazionetest
{
    public abstract class classecomponente
    {
        public abstract void Add(classecomponente componente);
        public abstract void Remove(int indice);
        public abstract classecomponente GetChild(int indice);
        public abstract string ToString();
        public abstract bool Equals(object obj);
        public abstract int Punteggio();
    }
}
