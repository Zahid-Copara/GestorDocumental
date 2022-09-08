using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmContactos : Form
    {
        //Instancia de la referencia remota del Gestor de Documentos
        ReferenciaRemota.GestionDocumentoClient cliente;
        ReferenciaRemota.Contacto contacto;
        //Definicion de variables para su proximo uso
        int IDContacto;
        char delimitador = '.';

        public frmContactos()
        {
            InitializeComponent();
            //Se inicia el formulario con un groupbox en falso
            gbCliente.Enabled = false;
            
        }
        // Evento de Regresar para volver al formulario Inicio
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        // Metodo para cargar el combobox
        public void CargarComboBox()
        {
            //Se limpia el combobox para evitar errores
            cbCargo.Items.Clear();
            cbTitulo.Items.Clear();
            // Se recorre la lista proveniente de la referencia remota el cual contiene los cargos
            foreach (var iterC in cliente.LeerCargo())
            {
                cbCargo.Items.Add(iterC.idCargo+"."+iterC.Nombre);
            }
            // Se recorre la lista proveniente de la referencia remota el cual contiene los titulos
            foreach (var iterT in cliente.LeerTitulo())
            {
                cbTitulo.Items.Add(iterT.idTitulo+"."+iterT.Nombre);
            }
        }
        // Metodo para regresar al Estado Inicial del formulario
        public void EstadoInicial()
        {
            txtNumCedula.Clear();
            txtApellidoContacto.Clear();
            txtCelular.Clear();
            txtCorreoElec.Clear();
            txtNombreContacto.Clear();
            txtNumTelfono.Clear();
            cbCargo.Items.Clear();
            cbTitulo.Items.Clear();
            btnIngresar.Enabled=false;
            btnBuscar.Enabled=false;
            gbCliente.Enabled = false;
        }
        // Metodo para dejar por defecto al CheckBox
        private void EstadoCheckBoxInicial()
        {
            rbtnBuscar.Checked = false;
            rbtnIngresar.Checked = false;
        }

        private void rbtnBuscar_CheckedChanged(object sender, EventArgs e)
        {            
            
        }

        private void rbtnIngresar_CheckedChanged(object sender, EventArgs e)
        {
           

        }
        // Al inicializar el formulario se cargan los contactos en la tabla
        private void frmContactos_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarContactos();
        }
        // El evento del boton Ingresar Click para poder guardar el contacto
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Condicion para que no existan casillas vacias
            if ((string.IsNullOrEmpty(txtNumCedula.Text) == true || string.IsNullOrEmpty(txtNombreContacto.Text) == true ||
                string.IsNullOrEmpty(txtApellidoContacto.Text) == true || string.IsNullOrEmpty(txtCorreoElec.Text)) ||
                string.IsNullOrEmpty(txtCelular.Text) == true || string.IsNullOrEmpty(txtNumTelfono.Text) == true ||
                string.IsNullOrEmpty(cbCargo.Text) == true || string.IsNullOrEmpty(cbTitulo.Text) == true)
            {
                // Mensaje para el usuario
                MessageBox.Show("No deje casillas en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Si todo sale bien entonces, se procede a guardar al contacto
            else
            {
                // Se verifica que el contacto no exista o que la cedula no este siendo usado
                if (cliente.BuscarContacto(txtNumCedula.Text) == null)
                {
                    // Se obtiene los ids de Cargo y Titulo
                    string[] cargoID = cbCargo.Text.Split(delimitador);
                    string[] tituloID = cbTitulo.Text.Split(delimitador);
                    // Llama a la referencia remota para poder llamar al metodo Agregar Contacto
                    cliente.AgregarContacto(Convert.ToInt32(cargoID[0]),Convert.ToInt32(tituloID[0]),txtNombreContacto.Text,
                        txtApellidoContacto.Text,txtNumCedula.Text,txtCorreoElec.Text,txtNumTelfono.Text,txtCelular.Text);
                    // Mensaje mostrado para el usuario de que se ha completado correctamente
                    MessageBox.Show("Contacto Guardado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se muestra el formulario normal 
                    EstadoCheckBoxInicial();
                    EstadoInicial();
                    CargarContactos();

                }
                // Si el contacto ya existe entonces se muestra un mensaje
                else
                {
                    MessageBox.Show("El contacto ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EstadoCheckBoxInicial();
                    EstadoInicial();
                }

            }

        }
        // Evento de que se ha presionado el boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo de la referencia remota para buscar contacto
            contacto = cliente.BuscarContacto(txtNumCedula.Text);
            // Si el contacto existe entonces 
            if (contacto != null)
            {
                // Se guardan todos los datos en los elementos del formulario para su visualizacion
                CargarComboBox();
                IDContacto = contacto.idContacto;
                txtNombreContacto.Text = contacto.Nombre;
                txtApellidoContacto.Text = contacto.Apellido;
                txtNumTelfono.Text = contacto.Telefono;
                txtCorreoElec.Text = contacto.CorreoElectronico;
                txtCelular.Text = contacto.Celular;
                cbCargo.SelectedIndex = (contacto.idCargo - 1);
                cbTitulo.SelectedIndex = (contacto.idTitulo - 1);
                txtNumCedula.Enabled = false;
                // Tambien se cargan los datos del Contacto que se requeria en la tabla
                lvwContactos.Items.Clear();
                foreach (var iter in cliente.LeerContacto())
                {
                    if (iter.numCedula == txtNumCedula.Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvwContactos.Items.Add(Convert.ToString(iter.idContacto));
                        item.SubItems.Add(Convert.ToString(iter.idCargo));
                        item.SubItems.Add(Convert.ToString(iter.idTitulo));
                        item.SubItems.Add(iter.Nombre);
                        item.SubItems.Add(iter.Apellido);
                        item.SubItems.Add(iter.numCedula);
                        item.SubItems.Add(iter.CorreoElectronico);
                        item.SubItems.Add(iter.Telefono);
                        item.SubItems.Add(iter.Celular);
                        break;
                    }

                }

            }
            // Si no existe el contacto entonces se muestra un mensaje
            else
            {
                MessageBox.Show("No existe el contacto!!", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                EstadoInicial();
            }
            rbtnBuscar.Checked = false;

        }

        private void lvwContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Si se ha hecho un click en el radio button Buscar, entonces se realiza por defecto el uso de elementos en el formulario que se requiera
        private void rbtnBuscar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            gbCliente.Enabled = true;
            txtNumCedula.Enabled = true;
            txtApellidoContacto.Enabled = false;
            txtCelular.Enabled = false;
            txtCorreoElec.Enabled = false;
            txtNombreContacto.Enabled = false;
            txtNumTelfono.Enabled = false;
            cbCargo.Enabled = false;
            cbTitulo.Enabled = false;
            btnIngresar.Enabled = false;
            btnBuscar.Enabled = true;
        }
        // Si se ha hecho un click en el radio button Crear, entonces se realiza por defecto el uso de elementos en el formulario que se requiera
        private void rbtnCrear_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            gbCliente.Enabled = true;
            txtNumCedula.Enabled = true;
            txtApellidoContacto.Enabled = true;
            txtCelular.Enabled = true;
            txtCorreoElec.Enabled = true;
            txtNombreContacto.Enabled = true;
            txtNumTelfono.Enabled = true;
            cbCargo.Enabled = true;
            cbTitulo.Enabled = true;
            btnBuscar.Enabled = false;
            btnIngresar.Enabled = true;
            CargarComboBox();
        }
        // Metodo para cargar contactos en la tabla del formulario
        public void CargarContactos()
        {
            lvwContactos.Items.Clear();
            foreach (var iter in cliente.LeerContacto())
            {
                ListViewItem item = new ListViewItem();
                item = lvwContactos.Items.Add(Convert.ToString(iter.idContacto));
                item.SubItems.Add(Convert.ToString(iter.idCargo));
                item.SubItems.Add(Convert.ToString(iter.idTitulo));
                item.SubItems.Add(iter.Nombre);
                item.SubItems.Add(iter.Apellido);
                item.SubItems.Add(iter.numCedula);
                item.SubItems.Add(iter.CorreoElectronico);
                item.SubItems.Add(iter.Telefono);
                item.SubItems.Add(iter.Celular);
            }
        }
        // Si se presiona el boton Eliminar se realiza el siguiente evento
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba que se haya seleccionado una fila de la tabla
            if (lvwContactos.SelectedItems.Count > 0)
            {
                // Se realiza un auxiliar con el id del Contacto a eliminar
                int idAux;
                ListViewItem item = lvwContactos.SelectedItems[0];
                idAux = Convert.ToInt32(item.Text);
                // Se llama a la referencia remota para obtener el Metodo Eliminar Contacto
                cliente.EliminarContacto(idAux);
                // Un mensaje es presentado al cliente, luego de que se haya realizado correctamente la eliminacion del Contacto
                MessageBox.Show("Contacto eliminado correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarContactos();
            }
            // Si no se ha seleccionado un item se lo hace saber al usuario
            else
            {
                MessageBox.Show("Seleccione un contacto para eliminar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        // Si se presiona el boton de Editar 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Se comprueba que se haya seleccionado algun elemento en la tabla del formulario
            if (lvwContactos.SelectedItems.Count > 0)
            {
                // Se realiza un auxiliar del elemento que se requiere editar
                int idAux;
                ListViewItem item = lvwContactos.SelectedItems[0];
                idAux = Convert.ToInt32(item.Text);
                // Se envia el id al formulario para Editar Contacto
                frmEditarContacto frmEditarContacto = new frmEditarContacto(idAux);
                // Se muestra el formulario
                frmEditarContacto.ShowDialog();
                // Una vez realizado se actualiza la tabla del formulario
                CargarContactos();
            }
            // Si no se ha seleccionado una fila se muestra un mensaje al usuario.
            else
            {
                MessageBox.Show("Seleccione un contacto para editar","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

    }
}
