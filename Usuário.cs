using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console1 {
	internal class Usuario {
		//cadeia = strig
		public string nome;
		public string login;
		public string senha;
		public int qtdLogin;
		public float peso;
		public bool ehSolteiro;
		public char abrvNomeMeio;


		public bool Logar(string _login, string _senha) {

			if (_login == login){
				if (_senha == senha){
					return true;
				}
			}

			return false;
		}
	}
}
