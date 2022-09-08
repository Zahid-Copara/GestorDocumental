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
    public partial class frmOrganizaciones : Form
    {
        //Instancia de la referencia remota del Gestor de Documentos
        ReferenciaRemota.GestionDocumentoClient cliente;
        ReferenciaRemota.Organizacion organizacion;

        //Definicion de variables para su proximo uso
        private int IDOrganizacion;
        private int idAuxOrg;
        private char delimitador = '.';

        public frmOrganizaciones()
        {
            InitializeComponent();
            // Al inicializar el componente se muestra solo lo necesario
            EstadoInicial();
        }
        // Metodo para regresar al Estado Inicial del formulario
        public void EstadoInicial()
        {

            txtRUC.Clear();
            txtNombreOrg.Clear();
            txtDireccionOrg.Clear();
            txtCodigoPostal.Clear();
            txtCiudad.Clear();
            cbProvincia.Items.Clear();
            txtTelefono.Clear();
            txtCorreoElec.Clear();
            txtSitioWeb.Clear();
            lblRUC.Enabled = false;
            txtRUC.Enabled = false;
            btnIngresar.Enabled = false;
            btnBuscar.Enabled = false;
            gbOrganizacion.Enabled = false;
        }
        // Metodo para dejar por defecto al CheckBox
        private void EstadoCheckBoxInicial()
        {
            rbtnBuscarOrg.Checked = false;
            rbtnCrearOrg.Checked = false;
        }
        private void frmOrganizaciones_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarOrganizacion();
        }
        // Evento de Regresar para volver al formulario Inicio
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Close();
        }
        // Metodo para cargar el combobox
        public void CargarComboBox()
        {
            //Se limpia el combobox para evitar errores
            cbProvincia.Items.Clear();
            // Se recorre la lista proveniente de la referencia remota el cual contiene las provincias
            foreach (var iterC in cliente.LeerProvincia())
            {
                cbProvincia.Items.Add(iterC.idProvincia + "." + iterC.Nombre);
            }
        }
        // Si se ha hecho un click en el radio button Buscar, entonces se realiza por defecto el uso de elementos en el formulario que se requiera
        private void rbtnBuscar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            lblRUC.Enabled = true;
            txtRUC.Enabled = true;
            btnBuscar.Enabled = true;
        }
        // Si se ha hecho un click en el radio button Crear, entonces se realiza por defecto el uso de elementos en el formulario que se requiera
        private void rbtnCrear_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            gbOrganizacion.Enabled = true;
            btnIngresar.Enabled = true;
            CargarComboBox();
        }
        // Metodo para cargar contactos en la tabla del formulario
        public void CargarOrganizacion()
        {
            lvwOrg.Items.Clear();
            foreach (var iter in cliente.LeerOrganizacion())
            {
                ListViewItem item = new ListViewItem();
                item = lvwOrg.Items.Add(Convert.ToString(iter.idOrganizacion));
                item.SubItems.Add(iter.Nombre);
                item.SubItems.Add(iter.Direccion);
                item.SubItems.Add(iter.CodigoPostal);
                item.SubItems.Add(iter.Ciudad);
                item.SubItems.Add(Convert.ToString(iter.idProvincia));
                item.SubItems.Add(iter.Telefono);
                item.SubItems.Add(iter.Correo);
                item.SubItems.Add(iter.SitioWeb);
            }
        }
        // El evento del boton Ingresar Click para poder guardar el contacto
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Condicion para que no existan casillas vacias
            if ((string.IsNullOrEmpty(txtNombreOrg.Text) == true || string.IsNullOrEmpty(txtDireccionOrg.Text) == true ||
                string.IsNullOrEmpty(txtCodigoPostal.Text) == true || string.IsNullOrEmpty(txtCiudad.Text)) ||
                string.IsNullOrEmpty(cbProvincia.Text) == true || string.IsNullOrEmpty(txtTelefono.Text) == true ||
                string.IsNullOrEmpty(txtCorreoElec.Text) == true || string.IsNullOrEmpty(txtSitioWeb.Text) == true)
            {
                // Mensaje para el usuario
                MessageBox.Show("No deje casillas en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Si todo sale bien entonces, se procede a guardar al contacto
            else
            {
                // Se verifica que la provincia no exista o que la organizacion no se este usando
                if ((cliente.BuscarOrg_Nombre(txtNombreOrg.Text) == null) || (cliente.BuscarOrg_Direccion(txtDireccionOrg.Text) == null))
                {
                    // Se obtiene el id de la organizacion
                    string[] provinciaID = cbProvincia.Text.Split(delimitador);
                    // Llama a la referencia remota para poder llamar al metodo Agregar Contacto
                    cliente.AgregarOrganizacion(txtNombreOrg.Text, txtDireccionOrg.Text, txtCodigoPostal.Text,
                        txtCiudad.Text, Convert.ToInt32(provinciaID[0]), txtTelefono.Text, txtCorreoElec.Text, txtSitioWeb.Text);
                    // Mensaje mostrado para el usuario de que se ha completado correctamente
                    MessageBox.Show("Organizacion Guardada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se muestra el formulario normal 
                    EstadoCheckBoxInicial();
                    EstadoInicial();
                    CargarOrganizacion();

                }
                // Si el contacto ya existe entonces se muestra un mensaje
                else
                {
                    MessageBox.Show("La Organizacion ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EstadoCheckBoxInicial();
                    EstadoInicial();
                }

            }

        }
        // Evento de que se ha presionado el boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo de la referencia remota para buscar a la organizacion
            organizacion = cliente.BuscarOrganizacion(Convert.ToInt32(txtRUC.Text));
            // Si la organizacion existe entonces 
            if (organizacion != null)
            {
                // Se guardan todos los datos en los elementos del formulario para su visualizacion
                CargarComboBox();
                IDOrganizacion = organizacion.idOrganizacion;
                txtNombreOrg.Text = organizacion.Nombre;
                txtDireccionOrg.Text = organizacion.Direccion;
                txtCodigoPostal.Text = organizacion.CodigoPostal;
                txtCiudad.Text = organizacion.Ciudad;
                cbProvincia.SelectedIndex = (organizacion.idOrganizacion - 1);
                txtTelefono.Text = organizacion.Telefono;
                txtCorreoElec.Text = organizacion.Correo;
                txtSitioWeb.Text = organizacion.SitioWeb;
                // Tambien se cargan los datos del Contacto que se requeria en la tabla
                lvwOrg.Items.Clear();
                foreach (var iter in cliente.LeerOrganizacion())
                {
                    if (iter.idOrganizacion == Convert.ToInt32(txtRUC.Text))
                    {
                        ListViewItem item = new ListViewItem();
                        item = lvwOrg.Items.Add(Convert.ToString(iter.idOrganizacion));
                        item.SubItems.Add(iter.Nombre);
                        item.SubItems.Add(iter.Direccion);
                        item.SubItems.Add(iter.CodigoPostal);
                        item.SubItems.Add(iter.Ciudad);
                        item.SubItems.Add(Convert.ToString(iter.idProvincia));
                        item.SubItems.Add(iter.Telefono);
                        item.SubItems.Add(iter.Correo);
                        item.SubItems.Add(iter.SitioWeb);
                    }

                }
            }
            lblRUC.Enabled = false;
            txtRUC.Enabled = false;
            btnBuscar.Enabled = false;
            EstadoCheckBoxInicial();
        }
        // Si se presiona el boton de Editar 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Se comprueba que se haya seleccionado algun elemento en la tabla del formulario
            if (lvwOrg.SelectedItems.Count > 0)
            {
                // Se realiza un auxiliar del elemento que se requiere editar
                int idAux;
                ListViewItem item = lvwOrg.SelectedItems[0];
                idAux = Convert.ToInt32(item.Text);
                // Se envia el id al formulario para Editar Contacto
                frmEditarOrganizacion frmEditarOrganizacion = new frmEditarOrganizacion(idAux);
                // Se muestra el formulario
                frmEditarOrganizacion.ShowDialog();
                // Una vez realizado se actualiza la tabla del formulario
                CargarOrganizacion();
            }
            // Si no se ha seleccionado una fila se muestra un mensaje al usuario.
            else
            {
                MessageBox.Show("Seleccione una organizacion para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba que se haya seleccionado una fila de la tabla
            if (lvwOrg.SelectedItems.Count > 0)
            {
                // Se realiza un auxiliar con el id del Contacto a eliminar
                int idAux;
                ListViewItem item = lvwOrg.SelectedItems[0];
                idAux = Convert.ToInt32(item.Text);
                // Se llama a la referencia remota para obtener el Metodo Eliminar Contacto
                cliente.EliminarOrganizacion(idAux);
                // Un mensaje es presentado al cliente, luego de que se haya realizado correctamente la eliminacion del Contacto
                MessageBox.Show("Organizacion eliminada correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarOrganizacion();
            }
            // Si no se ha seleccionado un item se lo hace saber al usuario
            else
            {
                MessageBox.Show("Seleccione una organizacion para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
