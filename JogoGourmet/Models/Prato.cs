namespace JogoGourmet.Models
{
	public class Prato
	{
		public Prato() { }

		public Prato(string nome, string categoria = "")
		{
			Nome = nome;
			Categoria = categoria;
		}

		public string Nome { get; private set; }
		public string Categoria { get; private set; }

		public void SetNome(string nome)
		{
			Nome = nome;
		}

		public void SetCategoria(string categoria)
		{
			Categoria = categoria;
		}
	}
}
