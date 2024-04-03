namespace JogoGourmet.Extensions
{
	public static class MsgBoxExtensions
	{
		private static readonly string _defaultMsgBoxCaption = "Jogo Gourmet";

		public static DialogResult Show(string text, MessageBoxButtons msgBoxBtn = MessageBoxButtons.OK, MessageBoxIcon msgBoxIcon = MessageBoxIcon.Question)
		{
			return MessageBox.Show(text, _defaultMsgBoxCaption, msgBoxBtn, msgBoxIcon);
		}
	}
}
