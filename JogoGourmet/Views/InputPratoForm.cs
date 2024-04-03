namespace JogoGourmet.Views
{
	public partial class InputPratoForm : Form
	{
		private readonly string _labelText;
		public string _inputResult { get; private set; }

		public InputPratoForm(string labelText)
		{
			_labelText = labelText;

			InitializeComponent();
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			_inputResult = TxtPrato.Text;

			Close();
		}

		private void InputPratoForm_Load(object sender, EventArgs e)
		{
			LblPergunta.Text = _labelText;
		}
	}
}
