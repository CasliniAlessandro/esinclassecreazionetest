using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esinclassecreazionetest
{
	public class classeverofalso: Componente
	{
		private string testo;

		// metodi accessor
		public string Testo
		{
			get { return testo; }
			set { testo = value; }
		}

		// costruttore
		public classeverofalso(string testo)
		{
			Testo = testo;
		}

		// metodi
		public override void Aggiunta(Componente componente)
		{
			throw new NotImplementedException();
		}
		public override void Rimuovi(int indice)
		{
			throw new NotImplementedException();
		}
		public override Componente GetChild(int indice)
		{
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return $"{Testo}";
		}


	}
}
