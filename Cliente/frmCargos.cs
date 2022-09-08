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
    public partial class frmCargos : Form
    {
        // Se llama a la Referencia Remota para instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Se declaran variables para poder utilizarlas en el formulario
        private string nombreCargoAux;
        private int control;
        private int cargoID;

        public frmCargos()
        {
            InitializeComponent();
        }
        // Se realiza un metodo Cargar Cargos
        public void CargarCargos()
        {
            // Se cargan los cargos en la tabla del formulario
            lvwListaCargos.Items.Clear();
            foreach (var iter in cliente.LeerCargo())
            {
                ListViewItem item = new ListViewItem();
                item = lvwListaCargos.Items.Add(Convert.ToString(iter.idCargo));
                item.SubItems.Add(Convert.ToString(iter.Nombre));
            }
        }
        // Al inicializar el formmulario se Carga los cargos y un Estado Inicial, ademas de la referencia Remota
        private void frmCargos_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarCargos();
            EstadoInicial();
        }
        // Se realiza un metodo de Estado Inicial para poder mantener de la misma manera como inicio el Formulario
        public void EstadoInicial()
        {
            txtNombreCargo.Clear();
            txtNombreCargo.Enabled = false;
            rbtnAgregarCargo.Checked = false;
            rbtnEditarCargo.Checked = false;
            rbtnEditarCargo.Enabled = false;
            rbtnEliminarCargo.Checked = false;
            rbtnEliminarCargo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // El boton Regresar, envia al formulario de Inicio
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Close();
        }
        // Se realiza un evento al presionar alguna fila de la tabla
        private void lvwListaCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se controla que se haya presionado alguna fila no nula
            if (lvwListaCargos.SelectedItems.Count > 0)
            {
                // Se realiza un cambio en los elementos del formulario
                EstadoInicial();
                rbtnAgregarCargo.Checked = false;
                rbtnEditarCargo.Enabled = true;
                rbtnEliminarCargo.Enabled = true;

            }
            // Si no se haya presionado una fila de la tabla del formulario se vuelve al Estado Inicial
            else
            {

                EstadoInicial();
            }
        }
        // Si se presiona el radio button Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            // Se muestra el estado inicial del GroupBox
            EstadoInicialGroupBox();
            // Se define los elementos que se van a utilizar dentro del GroupBox
            txtNombreCargo.Clear();
            lblNombre.Enabled = true;
            txtNombreCargo.Enabled = true;
            btnGuardar.Enabled = true;
            control = 0;
        }
        // Si se presiona el radio button de Editar
        private void Editar_Click(object sender, EventArgs e)
        {
            // Se llama al Estado Inicial GroupBox
            EstadoInicialGroupBox();
            // Se habilitan los elementos que se requieren
            lblNombre.Enabled = true;
            txtNombreCargo.Enabled = true;
            txtNombreCargo.Text = lvwListaCargos.SelectedItems[0].SubItems[1].Text;
            this.nombreCargoAux = txtNombreCargo.Text;
            btnGuardar.Enabled = true;
            control = 1;
        }
        // Metodo para el Estado Inicial del GroupBox
        public void EstadoInicialGroupBox()
        {
            // Se habilitan los elementos necesarios
            gbControlCargo.Enabled = true;
            lblNombre.Enabled = false;
            txtNombreCargo.Clear();
            txtNombreCargo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Si se presiona el radio buton de Eliminar 
        private void Eliminar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo Estado Inicial GroupBox
            EstadoInicialGroupBox();
            // Se definen los elementos necesarios para usar
            txtNombreCargo.Enabled = false;
            btnEliminar.Enabled = true;
            txtNombreCargo.Text = lvwListaCargos.SelectedItems[0].SubItems[1].Text;
        }
        // Se llama al boton de Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Control de que no este en blanco el textbox
            if (string.IsNullOrEmpty(txtNombreCargo.Text) == true)
            {
                // Se muestra un mensaje al usaurio de que existen casillas en blanco
                MessageBox.Show("Casilla en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si el control es el de Agregar
                if (control == 0)
                {
                    // Se realiza un control de que no exista el Cargo a ingresar
                    if (cliente.BuscarCargo(txtNombreCargo.Text) == null)
                    {
                        // Se llama al metodo para Agregar Cargo de la referencia remota
                        cliente.AgregarCargo(txtNombreCargo.Text);
                        // Si se ha guardado exitosamente se muestra un mensaje
                        MessageBox.Show("Cargo Guardado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se llama al Estado Inicial
                        EstadoInicial();
                        // Se actualiza la tabla del formulario
                        CargarCargos();
                    }
                    else
                    {
                        // Se muestra un mensaje de que ya existe el Cargo si se verifica lo mismo
                        MessageBox.Show("El Cargo ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EstadoInicial();
                    }
                }
                // Si el control es el de Editar
                else if (control == 1)
                {
                    // Se verifica que se haya seleccionado una fila de la tabla del formulario
                    if (lvwListaCargos.SelectedItems.Count > 0)
                    {
                        // Se guarda en un id auxiliar el id seleccionado en la tabla
                        int idAux;
                        ListViewItem item = lvwListaCargos.SelectedItems[0];
                        idAux = Convert.ToInt32(item.Text);
                        // Se verifica si el Cargo que se edita es el mismo del textbox
                        // Con el fin de que no genere error
                        if (nombreCargoAux == txtNombreCargo.Text)
                        {
                            // Se llama al Metodo de la referencia Remota para actualizar la Cargo
                            cliente.EditarCargo(idAux, txtNombreCargo.Text);
                            // Se muestra un mensaje al usuario de que el proceso ha sido exitoso
                            MessageBox.Show("Cargo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                        }
                        // Si el Cargo es diferente a su edicion
                        else
                        {
                            // Se verifica de que no sea un Cargo ya ingresado
                            if (cliente.BuscarCargo(txtNombreCargo.Text) == null)
                            {
                                // Se realiza el mismo proceso de actualziacion
                                cliente.EditarCargo(idAux, txtNombreCargo.Text);
                                MessageBox.Show("Cargo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EstadoInicial();
                            }
                            // Si ya existe un Cargo se le hace saber al usuario
                            else
                            {
                                MessageBox.Show("Cargo ya ingresado!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                EstadoInicial();
                            }
                        }
                        // Se actualiza la tabla del formulario
                        CargarCargos();
                    }
                    // Si no se ha seleccionado una fila del formulario se lo hace saber al usuario
                    else
                    {
                        MessageBox.Show("Seleccione un Cargo para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
        // Se llama al evento del boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se verifica de que se haya seleccionado un elemento del formulario
            if (lvwListaCargos.SelectedItems.Count > 0)
            {
                // Se guarda el id
                cargoID = Convert.ToInt32(lvwListaCargos.SelectedItems[0].Text);
                // Se llama al metodo de la referencia remota para eliminar el elemento
                cliente.EliminarCargo(cargoID);
                // Se hace saber al cliente de que se ha realizado el proceso correctamente
                MessageBox.Show("Cargo eliminado correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarCargos();
                // Se llama al metodo de Estado Inicial
                EstadoInicial();
            }
            // Si no se ha seleccionado un elemento de la tabla, se lo hace saber al cliente
            else
            {
                MessageBox.Show("Seleccione un Cargo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
