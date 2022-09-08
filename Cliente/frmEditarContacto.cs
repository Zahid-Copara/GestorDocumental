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
    public partial class frmEditarContacto : Form
    {
        // Llamada a la Referencia Remota para poder instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Declaracion de variables para poder usarlas luego
        string cedulaAux;
        int idContacto;
        char delimitador = '.';
        public frmEditarContacto()
        {
            InitializeComponent();
        }
        // Se inicializa el formulario con el id que viene del formulario Contacto
        public frmEditarContacto(int idAux)
        {
            this.idContacto = idAux;
            InitializeComponent();
        }
        // Al inicializar el contacto se definen algunas cosas
        private void frmEditarContacto_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            // Se realiza un alectura del cliente
            foreach (var iter in cliente.LeerContacto())
            {
                // Se realiza la comparacion del id
                if (iter.idContacto == idContacto)
                {
                    // Se carga todo en los elementos del formulario Editar para que sea mas sencilla la edicion del cliente
                    CargarComboBox();
                    txtNumCedula.Text = iter.numCedula;
                    this.cedulaAux = txtNumCedula.Text;
                    txtNombreContacto.Text = iter.Nombre;
                    txtApellidoContacto.Text = iter.Apellido;
                    txtNumTelfono.Text = iter.Telefono;
                    txtCorreoElec.Text = iter.CorreoElectronico;
                    txtCelular.Text = iter.Celular;
                    cbCargo.SelectedIndex = (iter.idCargo - 1);
                    cbTitulo.SelectedIndex = (iter.idTitulo - 1);
                    break;
                }
            }
        }
        // Carga del Combobox que seran requeridos en el formulario
        public void CargarComboBox()
        {
            cbCargo.Items.Clear();
            cbTitulo.Items.Clear();

            foreach (var iterC in cliente.LeerCargo())
            {
                cbCargo.Items.Add(iterC.idCargo + "." + iterC.Nombre);
            }
            foreach (var iterT in cliente.LeerTitulo())
            {
                cbTitulo.Items.Add(iterT.idTitulo + "." + iterT.Nombre);
            }
        }
        // Si se presiona cancelar se cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Si se presiona el boton Aceptar entonces se realiza el siguiente evento
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Se compara si la cedula es la misma que la que esta actualmente
            // Esto con el fin de no generar un error si se requiere cambiar algo que sea diferente a la cedula
            if (cedulaAux == txtNumCedula.Text)
            {
                // Se realiza la actualizacion del Contacto generando primero los ID de cargo y titulo
                string[] cargoID = cbCargo.Text.Split(delimitador);
                string[] tituloID = cbTitulo.Text.Split(delimitador);
                // Se llama al metodo Editar Contacto de la referencia Remota para poder realizar la actualizacion del Contacto
                cliente.EditarContacto(idContacto, Convert.ToInt32(cargoID[0]), Convert.ToInt32(tituloID[0]), txtNombreContacto.Text,
                    txtApellidoContacto.Text, txtNumCedula.Text, txtCorreoElec.Text, txtNumTelfono.Text, txtCelular.Text);
                // Se muestra un mensaje de que el Contacto ha sido Actualziado correctamente
                MessageBox.Show("Contacto Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Se realiza una verficacion de que la cedula ingresada (En caso de que se actualice) no sea de algun otro Contacto
                if (cliente.BuscarContacto(txtNumCedula.Text) == null)
                {
                    // Se realiza el mismo procedimiento anterior
                    string[] cargoID = cbCargo.Text.Split(delimitador);
                    string[] tituloID = cbTitulo.Text.Split(delimitador);
                    cliente.EditarContacto(idContacto, Convert.ToInt32(cargoID[0]), Convert.ToInt32(tituloID[0]), txtNombreContacto.Text,
                        txtApellidoContacto.Text, txtNumCedula.Text, txtCorreoElec.Text, txtNumTelfono.Text, txtCelular.Text);
                    MessageBox.Show("Contacto Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                // Si la cedula pertenece ya a otro Contacto se muestra un mensaje
                else
                {
                    MessageBox.Show("Cedula pertenece a otro usuario!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
