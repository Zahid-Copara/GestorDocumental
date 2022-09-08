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
    public partial class frmGrupoCostos : Form
    {
        // Se llama a la Referencia Remota para instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Se declaran variables para poder utilizarlas en el formulario
        private string nombreGrupoCostoAux;
        private int control;
        private int grupoCostosID;

        public frmGrupoCostos()
        {
            InitializeComponent();
        }

        // Se realiza un metodo Cargar Grupo Costos
        public void CargarGrupoCostos()
        {
            // Se cargan los GrupoCostos en la tabla del formulario
            lvwListaGrupoCostos.Items.Clear();
            foreach (var iter in cliente.LeerGrupoCosto())
            {
                ListViewItem item = new ListViewItem();
                item = lvwListaGrupoCostos.Items.Add(Convert.ToString(iter.idGrupoCostos));
                item.SubItems.Add(Convert.ToString(iter.Nombre));
            }
        }
        // Se realiza un metodo de Estado Inicial para poder mantener de la misma manera como inicio el Formulario
        public void EstadoInicial()
        {
            txtNombreGrupoCosto.Clear();
            txtNombreGrupoCosto.Enabled = false;
            rbtnAgregarGrupoCosto.Checked = false;
            rbtnEditarGrupoCosto.Checked = false;
            rbtnEditarGrupoCosto.Enabled = false;
            rbtnEliminarGrupoCosto.Checked = false;
            rbtnEliminarGrupoCosto.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Metodo para el Estado Inicial del GroupBox
        public void EstadoInicialGroupBox()
        {
            // Se habilitan los elementos necesarios
            gbControlGrupoCostos.Enabled = true;
            lblNombre.Enabled = false;
            txtNombreGrupoCosto.Clear();
            txtNombreGrupoCosto.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Si se presiona el radio button Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            // Se muestra el estado inicial del GroupBox
            EstadoInicialGroupBox();
            // Se define los elementos que se van a utilizar dentro del GroupBox
            txtNombreGrupoCosto.Clear();
            lblNombre.Enabled = true;
            txtNombreGrupoCosto.Enabled = true;
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
            txtNombreGrupoCosto.Enabled = true;
            txtNombreGrupoCosto.Text = lvwListaGrupoCostos.SelectedItems[0].SubItems[1].Text;
            this.nombreGrupoCostoAux = txtNombreGrupoCosto.Text;
            btnGuardar.Enabled = true;
            control = 1;
        }
        // Si se presiona el radio buton de Eliminar
        private void Eliminar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo Estado Inicial GroupBox
            EstadoInicialGroupBox();
            // Se definen los elementos necesarios para usar
            txtNombreGrupoCosto.Enabled = false;
            btnEliminar.Enabled = true;
            txtNombreGrupoCosto.Text = lvwListaGrupoCostos.SelectedItems[0].SubItems[1].Text;
        }
        // Al inicializar el formmulario se Carga los GrupoCostos y un Estado Inicial, ademas de la referencia Remota
        private void frmGrupoCostos_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarGrupoCostos();
            EstadoInicial();
        }
        // El boton Regresar, envia al formulario de Inicio
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.Show();
            this.Close();
        }
        // Se realiza un evento al presionar alguna fila de la tabla
        private void lvwListaGrupoCostos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se controla que se haya presionado alguna fila no nula
            if (lvwListaGrupoCostos.SelectedItems.Count > 0)
            {
                // Se realiza un cambio en los elementos del formulario
                EstadoInicial();
                rbtnAgregarGrupoCosto.Checked = false;
                rbtnEditarGrupoCosto.Enabled = true;
                rbtnEliminarGrupoCosto.Enabled = true;

            }
            // Si no se haya presionado una fila de la tabla del formulario se vuelve al Estado Inicial
            else
            {
                EstadoInicial();
            }
        }
        // Se llama al boton de Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Control de que no este en blanco el textbox
            if (string.IsNullOrEmpty(txtNombreGrupoCosto.Text) == true)
            {
                // Se muestra un mensaje al usaurio de que existen casillas en blanco
                MessageBox.Show("Casilla en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si el control es el de Agregar
                if (control == 0)
                {
                    // Se realiza un control de que no exista el GrupoCosto a ingresar
                    if (cliente.BuscarGrupoCosto(txtNombreGrupoCosto.Text) == null)
                    {
                        // Se llama al metodo para Agregar GrupoCosto de la referencia remota
                        cliente.AgregarGrupoCosto(txtNombreGrupoCosto.Text);
                        // Si se ha guardado exitosamente se muestra un mensaje
                        MessageBox.Show("Grupo Costo Guardado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se llama al Estado Inicial
                        EstadoInicial();
                        // Se actualiza la tabla del formulario
                        CargarGrupoCostos();
                    }
                    else
                    {
                        // Se muestra un mensaje de que ya existe el Grupo Costo si se verifica lo mismo
                        MessageBox.Show("El Grupo Costo ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EstadoInicial();
                    }
                }
                // Si el control es el de Editar
                else if (control == 1)
                {
                    // Se verifica que se haya seleccionado una fila de la tabla del formulario
                    if (lvwListaGrupoCostos.SelectedItems.Count > 0)
                    {
                        // Se guarda en un id auxiliar el id seleccionado en la tabla
                        int idAux;
                        ListViewItem item = lvwListaGrupoCostos.SelectedItems[0];
                        idAux = Convert.ToInt32(item.Text);
                        // Se verifica si el Grupo Costo que se edita es el mismo del textbox
                        // Con el fin de que no genere error
                        if (nombreGrupoCostoAux == txtNombreGrupoCosto.Text)
                        {
                            // Se llama al Metodo de la referencia Remota para actualizar el Grupo Costo
                            cliente.EditarGrupoCosto(idAux, txtNombreGrupoCosto.Text);
                            // Se muestra un mensaje al usuario de que el proceso ha sido exitoso
                            MessageBox.Show("Grupo Costo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                        }
                        // Si el Grupo Costo es diferente a su edicion
                        else
                        {
                            // Se verifica de que no sea un Grupo Costo ya ingresado
                            if (cliente.BuscarGrupoCosto(txtNombreGrupoCosto.Text) == null)
                            {
                                // Se realiza el mismo proceso de actualziacion
                                cliente.EditarGrupoCosto(idAux, txtNombreGrupoCosto.Text);
                                MessageBox.Show("Grupo Costo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EstadoInicial();
                            }
                            // Si ya existe un Grupo Costo se le hace saber al usuario
                            else
                            {
                                MessageBox.Show("Grupo Costo ya ingresado!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                EstadoInicial();
                            }
                        }
                        // Se actualiza la tabla del formulario
                        CargarGrupoCostos();
                    }
                    // Si no se ha seleccionado una fila del formulario se lo hace saber al usuario
                    else
                    {
                        MessageBox.Show("Seleccione un Grupo Costo para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        // Se llama al evento del boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se verifica de que se haya seleccionado un elemento del formulario
            if (lvwListaGrupoCostos.SelectedItems.Count > 0)
            {
                // Se guarda el id
                grupoCostosID = Convert.ToInt32(lvwListaGrupoCostos.SelectedItems[0].Text);
                // Se llama al metodo de la referencia remota para eliminar el elemento
                cliente.EliminarGrupoCosto(grupoCostosID);
                // Se hace saber al cliente de que se ha realizado el proceso correctamente
                MessageBox.Show("Grupo Costo eliminado correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarGrupoCostos();
                // Se llama al metodo de Estado Inicial
                EstadoInicial();
            }
            // Si no se ha seleccionado un elemento de la tabla, se lo hace saber al cliente
            else
            {
                MessageBox.Show("Seleccione un Grupo Costo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
