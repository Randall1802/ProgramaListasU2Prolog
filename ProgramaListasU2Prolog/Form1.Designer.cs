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
			((System.ComponentModel.ISupportInitialize)dataGridViewCompras1).BeginInit();
			SuspendLayout();
			// 
			// textBoxClienteId
			// 
			textBoxClienteId.Location = new Point(327, 124);
			textBoxClienteId.Name = "textBoxClienteId";
			textBoxClienteId.PlaceholderText = "Id";
			textBoxClienteId.Size = new Size(125, 27);
			textBoxClienteId.TabIndex = 0;
			// 
			// textBoxProductoId
			// 
			textBoxProductoId.Location = new Point(509, 124);
			textBoxProductoId.Name = "textBoxProductoId";
			textBoxProductoId.PlaceholderText = "Id";
			textBoxProductoId.Size = new Size(125, 27);
			textBoxProductoId.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(361, 101);
			label1.Name = "label1";
			label1.Size = new Size(55, 20);
			label1.TabIndex = 4;
			label1.Text = "Cliente";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(537, 101);
			label2.Name = "label2";
			label2.Size = new Size(69, 20);
			label2.TabIndex = 5;
			label2.Text = "Producto";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(479, 320);
			label3.Name = "label3";
			label3.Size = new Size(68, 20);
			label3.TabIndex = 6;
			label3.Text = "Compras";
			// 
			// textBoxClienteNombre
			// 
			textBoxClienteNombre.Location = new Point(327, 171);
			textBoxClienteNombre.Name = "textBoxClienteNombre";
			textBoxClienteNombre.PlaceholderText = "Nombre";
			textBoxClienteNombre.Size = new Size(125, 27);
			textBoxClienteNombre.TabIndex = 8;
			// 
			// textBoxProductoNombre
			// 
			textBoxProductoNombre.Location = new Point(509, 171);
			textBoxProductoNombre.Name = "textBoxProductoNombre";
			textBoxProductoNombre.PlaceholderText = "Nombre";
			textBoxProductoNombre.Size = new Size(125, 27);
			textBoxProductoNombre.TabIndex = 9;
			// 
			// textBoxPrecio
			// 
			textBoxPrecio.Location = new Point(509, 216);
			textBoxPrecio.Name = "textBoxPrecio";
			textBoxPrecio.PlaceholderText = "Precio";
			textBoxPrecio.Size = new Size(125, 27);
			textBoxPrecio.TabIndex = 10;
			// 
			// buttonRealizarCompra
			// 
			buttonRealizarCompra.Location = new Point(742, 177);
			buttonRealizarCompra.Margin = new Padding(3, 4, 3, 4);
			buttonRealizarCompra.Name = "buttonRealizarCompra";
			buttonRealizarCompra.Size = new Size(86, 31);
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
			dataGridViewCompras1.Location = new Point(55, 347);
			dataGridViewCompras1.Margin = new Padding(3, 4, 3, 4);
			dataGridViewCompras1.MultiSelect = false;
			dataGridViewCompras1.Name = "dataGridViewCompras1";
			dataGridViewCompras1.RowHeadersWidth = 51;
			dataGridViewCompras1.RowTemplate.Height = 25;
			dataGridViewCompras1.Size = new Size(877, 200);
			dataGridViewCompras1.TabIndex = 12;
			// 
			// textBoxCantidad
			// 
			textBoxCantidad.Location = new Point(509, 264);
			textBoxCantidad.Name = "textBoxCantidad";
			textBoxCantidad.PlaceholderText = "Cantidad";
			textBoxCantidad.Size = new Size(125, 27);
			textBoxCantidad.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(37, 242);
			label4.Name = "label4";
			label4.Size = new Size(162, 20);
			label4.TabIndex = 14;
			label4.Text = "Integrantes del equipo:";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 216);
			label5.Name = "label5";
			label5.Size = new Size(228, 20);
			label5.TabIndex = 15;
			label5.Text = "Programación Lógica y Funcional";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(55, 271);
			label6.Name = "label6";
			label6.Size = new Size(193, 20);
			label6.TabIndex = 15;
			label6.Text = "Randy Iván Herrera Sánchez";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(55, 295);
			label7.Name = "label7";
			label7.Size = new Size(220, 20);
			label7.TabIndex = 16;
			label7.Text = "Soraya Michelle Quintana Rosas";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 255);
			ClientSize = new Size(978, 563);
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
	}
}
