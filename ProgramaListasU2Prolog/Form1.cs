namespace ProgramaListasU2Prolog
{
	public partial class Form1 : Form
	{
		private List<Cliente> clientes;
		private List<Producto> productos;
		private List<Compra> compras;

		public Form1()
		{
			InitializeComponent();
			// Inicializar las listas
			clientes = new List<Cliente>();
			productos = new List<Producto>();
			compras = new List<Compra>();

			// Configurar el DataGridView
			dataGridViewCompras1.AutoGenerateColumns = true;
			dataGridViewCompras1.DataSource = compras;
		}


		class Cliente
		{
			public int ClienteId { get; set; }
			public string Nombre { get; set; }
			public string NombreCliente => Nombre;

		}

		class Producto
		{
			public int ProductoId { get; set; }
			public string Nombre { get; set; }
			public decimal Precio { get; set; }
			public string NombreProducto => Nombre;

		}

		class Compra
		{
			public int CompraId { get; set; }
			public string Cliente { get; set; }
			public string Producto { get; set; }
			public decimal Precio { get; set; }
			public int Cantidad { get; set; }

			// propiedades para mostrar en el DataGridView
			//public string NombreCliente => Cliente?.NombreCliente ?? "";
			//public string NombreProducto => Producto?.NombreProducto ?? "";
			public decimal Total => Precio * Cantidad;
		}

		private void buttonRealizarCompra_Click(object sender, EventArgs e)
		{
			try
			{
				string clienteNombre = "";
				// Obtener los valores de los TextBox
				int clienteId = int.Parse(textBoxClienteId.Text);
				clienteNombre = textBoxClienteNombre.Text;
				int productoId = int.Parse(textBoxProductoId.Text);
				string productoNombre = textBoxProductoNombre.Text;
				decimal precio = decimal.Parse(textBoxPrecio.Text);
				int cantidad = int.Parse(textBoxCantidad.Text);

				// Buscar cliente en la lista
				Cliente cliente = new Cliente(); //clientes.FirstOrDefault(c => c.ClienteId == clienteId || c.Nombre == clienteNombre);
				if (cliente == null)
				{
					// Si no se encuentra, agregar nuevo cliente
					cliente = new Cliente { ClienteId = clienteId, Nombre = clienteNombre };
					clientes.Add(cliente);
				}

				// Buscar producto en la lista
				Producto producto = new Producto();// productos.FirstOrDefault(p => p.ProductoId == productoId || p.Nombre == productoNombre);
				if (producto == null)
				{
					// Si no se encuentra, agregar nuevo producto
					producto = new Producto { ProductoId = productoId, Nombre = productoNombre, Precio = precio };
					productos.Add(producto);
				}

				// Crear una nueva compra
				Compra nuevaCompra = new Compra
				{
					CompraId = compras.Count + 1,
					Cliente = clienteNombre,
					Producto = productoNombre,
					Precio = precio,
					Cantidad = cantidad,
				};

				// Agregar la compra a la lista
				compras.Add(nuevaCompra);

				// Actualizar el origen de datos del DataGridView
				dataGridViewCompras1.DataSource = null;
				dataGridViewCompras1.DataSource = compras;
			}
			catch (FormatException)
			{
				MessageBox.Show("Por favor, ingrese números válidos en Cliente ID, Producto ID y Precio.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}");
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}
