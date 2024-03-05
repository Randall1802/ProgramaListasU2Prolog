namespace ProgramaListasU2Prolog
{
	partial class Form1
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
			textBoxClienteId = new TextBox();
			textBoxProductoId = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBoxClienteNombre = new TextBox();
			textBoxProductoNombre = new TextBox();
			textBoxPrecio = new TextBox();
			buttonRealizarCompra = new Button();
			dataGridViewCompras1 = new DataGridView();
			textBoxCantidad = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewCompras1).BeginInit();
			SuspendLayout();
			// 
			// textBoxClienteId
			// 
			textBoxClienteId.Location = new Point(286, 93);
			textBoxClienteId.Margin = new Padding(3, 2, 3, 2);
			textBoxClienteId.Name = "textBoxClienteId";
			textBoxClienteId.PlaceholderText = "Id";
			textBoxClienteId.Size = new Size(110, 23);
			textBoxClienteId.TabIndex = 0;
			// 
			// textBoxProductoId
			// 
			textBoxProductoId.Location = new Point(445, 93);
			textBoxProductoId.Margin = new Padding(3, 2, 3, 2);
			textBoxProductoId.Name = "textBoxProductoId";
			textBoxProductoId.PlaceholderText = "Id";
			textBoxProductoId.Size = new Size(110, 23);
			textBoxProductoId.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(316, 76);
			label1.Name = "label1";
			label1.Size = new Size(44, 15);
			label1.TabIndex = 4;
			label1.Text = "Cliente";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(470, 76);
			label2.Name = "label2";
			label2.Size = new Size(56, 15);
			label2.TabIndex = 5;
			label2.Text = "Producto";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(419, 240);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 6;
			label3.Text = "Compras";
			// 
			// textBoxClienteNombre
			// 
			textBoxClienteNombre.Location = new Point(286, 128);
			textBoxClienteNombre.Margin = new Padding(3, 2, 3, 2);
			textBoxClienteNombre.Name = "textBoxClienteNombre";
			textBoxClienteNombre.PlaceholderText = "Nombre";
			textBoxClienteNombre.Size = new Size(110, 23);
			textBoxClienteNombre.TabIndex = 8;
			// 
			// textBoxProductoNombre
			// 
			textBoxProductoNombre.Location = new Point(445, 128);
			textBoxProductoNombre.Margin = new Padding(3, 2, 3, 2);
			textBoxProductoNombre.Name = "textBoxProductoNombre";
			textBoxProductoNombre.PlaceholderText = "Nombre";
			textBoxProductoNombre.Size = new Size(110, 23);
			textBoxProductoNombre.TabIndex = 9;
			// 
			// textBoxPrecio
			// 
			textBoxPrecio.Location = new Point(445, 162);
			textBoxPrecio.Margin = new Padding(3, 2, 3, 2);
			textBoxPrecio.Name = "textBoxPrecio";
			textBoxPrecio.PlaceholderText = "Precio";
			textBoxPrecio.Size = new Size(110, 23);
			textBoxPrecio.TabIndex = 10;
			// 
			// buttonRealizarCompra
			// 
			buttonRealizarCompra.Location = new Point(649, 133);
			buttonRealizarCompra.Name = "buttonRealizarCompra";
			buttonRealizarCompra.Size = new Size(75, 23);
			buttonRealizarCompra.TabIndex = 11;
			buttonRealizarCompra.Text = "Compraa";
			buttonRealizarCompra.UseVisualStyleBackColor = true;
			buttonRealizarCompra.Click += buttonRealizarCompra_Click;
			// 
			// dataGridViewCompras1
			// 
			dataGridViewCompras1.AllowUserToAddRows = false;
			dataGridViewCompras1.AllowUserToDeleteRows = false;
			dataGridViewCompras1.AllowUserToResizeColumns = false;
			dataGridViewCompras1.AllowUserToResizeRows = false;
			dataGridViewCompras1.BackgroundColor = SystemColors.AppWorkspace;
			dataGridViewCompras1.CausesValidation = false;
			dataGridViewCompras1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCompras1.Location = new Point(32, 260);
			dataGridViewCompras1.MultiSelect = false;
			dataGridViewCompras1.Name = "dataGridViewCompras1";
			dataGridViewCompras1.RowHeadersWidth = 51;
			dataGridViewCompras1.RowTemplate.Height = 25;
			dataGridViewCompras1.Size = new Size(788, 150);
			dataGridViewCompras1.TabIndex = 12;
			// 
			// textBoxCantidad
			// 
			textBoxCantidad.Location = new Point(445, 198);
			textBoxCantidad.Margin = new Padding(3, 2, 3, 2);
			textBoxCantidad.Name = "textBoxCantidad";
			textBoxCantidad.PlaceholderText = "Cantidad";
			textBoxCantidad.Size = new Size(110, 23);
			textBoxCantidad.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(32, 182);
			label4.Name = "label4";
			label4.Size = new Size(128, 15);
			label4.TabIndex = 14;
			label4.Text = "Integrantes del equipo:";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(10, 162);
			label5.Name = "label5";
			label5.Size = new Size(184, 15);
			label5.TabIndex = 15;
			label5.Text = "Programación Lógica y Funcional";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(48, 203);
			label6.Name = "label6";
			label6.Size = new Size(153, 15);
			label6.TabIndex = 15;
			label6.Text = "Randy Iván Herrera Sánchez";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(48, 221);
			label7.Name = "label7";
			label7.Size = new Size(175, 15);
			label7.TabIndex = 16;
			label7.Text = "Soraya Michelle Quintana Rosas";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 101);
			label8.Name = "label8";
			label8.Size = new Size(161, 15);
			label8.TabIndex = 17;
			label8.Text = "Programa de listas dinámicas";
			label8.Click += label8_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = Color.FromArgb(255, 192, 255);
			ClientSize = new Size(856, 422);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(textBoxCantidad);
			Controls.Add(dataGridViewCompras1);
			Controls.Add(buttonRealizarCompra);
			Controls.Add(textBoxPrecio);
			Controls.Add(textBoxProductoNombre);
			Controls.Add(textBoxClienteNombre);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxProductoId);
			Controls.Add(textBoxClienteId);
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "Form1";
			Text = "Listas";
			((System.ComponentModel.ISupportInitialize)dataGridViewCompras1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxClienteId;
		private TextBox textBoxProductoId;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBoxClienteNombre;
		private TextBox textBoxProductoNombre;
		private TextBox textBoxPrecio;
		private Button buttonRealizarCompra;
		private DataGridView dataGridViewCompras1;
		private TextBox textBoxCantidad;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
	}
}
