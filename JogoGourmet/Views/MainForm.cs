using JogoGourmet.Extensions;
using JogoGourmet.Models;

namespace JogoGourmet.Views
{
	public partial class MainForm : Form
	{
		private IList<Prato> _pratos;
		private Prato _pratoAtual;

		public MainForm()
		{
			CarregarPratos();

			InitializeComponent();
		}

		private void CarregarPratos()
		{
			_pratos =
			[
				new Prato("Lasanha", "Massa"),
				new Prato("Bolo de Chocolate", "")
			];
			_pratoAtual = null;
		}

		private void AdicionarNovoPrato()
		{
			var novoPrato = new Prato();

			using (var inputNomeForm = new InputPratoForm("Qual prato você pensou?"))
			{
				inputNomeForm.ShowDialog();

				if (!string.IsNullOrEmpty(inputNomeForm._inputResult)) novoPrato.SetNome(inputNomeForm._inputResult);
			}

			if (!string.IsNullOrEmpty(novoPrato.Nome))
			{
				using (var inputCategoriaForm = new InputPratoForm($"{novoPrato.Nome} é ________ mas {_pratoAtual.Nome} não."))
				{
					inputCategoriaForm.ShowDialog();

					if (!string.IsNullOrEmpty(inputCategoriaForm._inputResult)) novoPrato.SetCategoria(inputCategoriaForm._inputResult);
				}

				if (!_pratos.Any(p => p.Nome.Equals(novoPrato.Nome, StringComparison.OrdinalIgnoreCase) && p.Categoria.Equals(novoPrato.Categoria, StringComparison.OrdinalIgnoreCase))) _pratos.Add(novoPrato);
			}
		}

		private void BtnJogar_Click(object sender, EventArgs e)
		{
			var dialogAcertouCategoriaResult = DialogResult.None;
			var dialogAcertouPratoResult = DialogResult.None;

			var pratosGroup = _pratos.OrderBy(p => string.IsNullOrEmpty(p.Categoria)).GroupBy(p => p.Categoria.ToLower()).ToList();

			foreach (var pratoGroup in pratosGroup)
			{
				if (!string.IsNullOrEmpty(pratoGroup.Key))
				{
					dialogAcertouCategoriaResult = MsgBoxExtensions.Show($"O prato que você pensou é {pratoGroup.Key}?", MessageBoxButtons.YesNo);

					if (dialogAcertouCategoriaResult == DialogResult.No) continue;
				}

				foreach (var prato in pratoGroup)
				{
					_pratoAtual = prato;

					dialogAcertouPratoResult = MsgBoxExtensions.Show($"O prato que você pensou é {prato.Nome}?", MessageBoxButtons.YesNo);

					if (dialogAcertouPratoResult == DialogResult.Yes) break;
				}

				if (dialogAcertouPratoResult == DialogResult.Yes || dialogAcertouCategoriaResult == DialogResult.Yes) break;
			}

			if (dialogAcertouPratoResult == DialogResult.Yes)
			{
				MsgBoxExtensions.Show("Acertei de novo!", msgBoxIcon: MessageBoxIcon.Information);
			}
			else
			{
				AdicionarNovoPrato();
			}
		}
	}
}
