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
    public partial class frmEditarOrganizacion : Form
    {
        // Llamada a la Referencia Remota para poder instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Declaracion de variables para poder usarlas luego
        string nombreAux;
        string direccionAux;
        int idOrganizacion;
        char delimitador = '.';

        public frmEditarOrganizacion()
        {
            InitializeComponent();
        }
        // Se inicializa el formulario con el id que viene del formularrio de la Organizacion
        public frmEditarOrganizacion(int idAux)
        {
            InitializeComponent();
            this.idOrganizacion = idAux;
        }

        private void frmEditarOrganizacion_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            // Se realiza un alectura del cliente
            foreach (var iter in cliente.LeerOrganizacion())
            {
                // Se realiza la comparacion del id
                if (iter.idOrganizacion == idOrganizacion)
                {
                    // Se carga todo en los elementos del formulario Editar para que sea mas sencilla la edicion del cliente
                    CargarComboBox();
                    txtNombreOrg.Text = iter.Nombre;
                    this.nombreAux = txtNombreOrg.Text;
                    this.direccionAux = txtDireccionOrg.Text;
                    txtDireccionOrg.Text = iter.Direccion;
                    txtCodigoPostal.Text = iter.CodigoPostal;
                    txtCiudad.Text = iter.Ciudad;
                    cbProvincia.SelectedIndex = (iter.idOrganizacion - 1);
                    txtTelefono.Text = iter.Telefono;
                    txtCorreoElec.Text = iter.Correo;
                    txtSitioWeb.Text = iter.SitioWeb;
                    break;
                }
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Se compara si la cedula es la misma que la que esta actualmente
            // Esto con el fin de no generar un error si se requiere cambiar algo que sea diferente a la cedula
            if (nombreAux == txtNombreOrg.Text || direccionAux == txtDireccionOrg.Text)
            {
                // Se obtiene el id de la organizacion
                string[] provinciaID = cbProvincia.Text.Split(delimitador);
                // Llama a la referencia remota para poder llamar al metodo Agregar Contacto
                cliente.EditarOrganizacion(idOrganizacion,txtNombreOrg.Text, txtDireccionOrg.Text, txtCodigoPostal.Text,
                    txtCiudad.Text, Convert.ToInt32(provinciaID[0]), txtTelefono.Text, txtCorreoElec.Text, txtSitioWeb.Text);
                // Mensaje mostrado para el usuario de que se ha completado correctamente
                MessageBox.Show("Organizacion Actualizada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Se realiza una verficacion de que la cedula ingresada (En caso de que se actualice) no sea de algun otro Contacto
                if ((cliente.BuscarOrg_Nombre(txtNombreOrg.Text) == null) && (cliente.BuscarOrg_Direccion(txtDireccionOrg.Text) == null))
                {
                    // Se obtiene el id de la organizacion
                    string[] provinciaID = cbProvincia.Text.Split(delimitador);
                    // Llama a la referencia remota para poder llamar al metodo Agregar Contacto
                    cliente.EditarOrganizacion(idOrganizacion, txtNombreOrg.Text, txtDireccionOrg.Text, txtCodigoPostal.Text,
                        txtCiudad.Text, Convert.ToInt32(provinciaID[0]), txtTelefono.Text, txtCorreoElec.Text, txtSitioWeb.Text);
                    // Mensaje mostrado para el usuario de que se ha completado correctamente
                    MessageBox.Show("Organizacion Actualizada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                // Si la cedula pertenece ya a otro Contacto se muestra un mensaje
                else
                {
                    MessageBox.Show("No se puede Actualizar, datos existentes en otra organizacion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
