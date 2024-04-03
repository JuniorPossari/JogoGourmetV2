namespace JogoGourmet.Views
{
	partial class InputPratoForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LblPergunta = new Label();
			BtnSalvar = new Button();
			BtnCancelar = new Button();
			TxtPrato = new TextBox();
			SuspendLayout();
			// 
			// LblPergunta
			// 
			LblPergunta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			LblPergunta.Location = new Point(0, 9);
			LblPergunta.Name = "LblPergunta";
			LblPergunta.Size = new Size(386, 21);
			LblPergunta.TabIndex = 0;
			LblPergunta.Text = "Pergunta";
			LblPergunta.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BtnSalvar
			// 
			BtnSalvar.Location = new Point(95, 90);
			BtnSalvar.Name = "BtnSalvar";
			BtnSalvar.Size = new Size(75, 23);
			BtnSalvar.TabIndex = 1;
			BtnSalvar.Text = "OK";
			BtnSalvar.UseVisualStyleBackColor = true;
			BtnSalvar.Click += BtnSalvar_Click;
			// 
			// BtnCancelar
			// 
			BtnCancelar.Location = new Point(218, 90);
			BtnCancelar.Name = "BtnCancelar";
			BtnCancelar.Size = new Size(75, 23);
			BtnCancelar.TabIndex = 2;
			BtnCancelar.Text = "Cancelar";
			BtnCancelar.UseVisualStyleBackColor = true;
			BtnCancelar.Click += BtnCancelar_Click;
			// 
			// TxtPrato
			// 
			TxtPrato.Location = new Point(95, 46);
			TxtPrato.MaxLength = 20;
			TxtPrato.Name = "TxtPrato";
			TxtPrato.Size = new Size(198, 23);
			TxtPrato.TabIndex = 3;
			// 
			// InputPratoForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(386, 125);
			Controls.Add(TxtPrato);
			Controls.Add(BtnCancelar);
			Controls.Add(BtnSalvar);
			Controls.Add(LblPergunta);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "InputPratoForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Jogo Gourmet";
			Load += InputPratoForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LblPergunta;
		private Button BtnSalvar;
		private Button BtnCancelar;
		private TextBox TxtPrato;
	}
}
