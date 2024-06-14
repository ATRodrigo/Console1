namespace Console1 {
	internal class Program {
		static void Main(string[] args){
			Usuario usuario = new Usuario();

			usuario.nome = "Rodrigo";
			usuario.login = "root";
			usuario.senha = "qwe123";
			//-----------
			string login;
			string senha;

			do{

			Console.WriteLine("Digite seu login: ");
			login = Console.ReadLine();

			Console.WriteLine("Digite sua senha: ");
			senha = Console.ReadLine();
			}while (!usuario.Logar(login, senha));

			Console.WriteLine(usuario.Logar(login, senha));
			//Console.WriteLine("Olá, "+usuario.nome);
			//Console.WriteLine(usuario.Logar("root", "qwe123"));

			//string result = Console.ReadLine();
			//*Método para ler do teclado 
			//Console.WriteLine("O usuário digitiou: " + result);

			//usuario.Logar();
		}
	}
}