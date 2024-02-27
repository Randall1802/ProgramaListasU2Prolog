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
			dataGridViewCompras1.CausesValidation = false;
			dataGridViewCompras1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCompras1.Location = new Point(124, 260);
			dataGridViewCompras1.Name = "dataGridViewCompras1";
			dataGridViewCompras1.ReadOnly = true;
			dataGridViewCompras1.RowTemplate.Height = 25;
			dataGridViewCompras1.Size = new Size(622, 150);
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 255);
			ClientSize = new Size(856, 422);
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
			Name = "Form1";
			Text = "Form1";
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
	}
}
