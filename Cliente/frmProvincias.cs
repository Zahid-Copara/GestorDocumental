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
    public partial class frmProvincias : Form
    {
        // Se llama a la Referencia Remota para instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Se declaran variables para poder utilizarlas en el formulario
        private string nombreProvinciaAux;
        private int control;
        private int provinciaID;

        public frmProvincias()
        {
            InitializeComponent();

        }
        // Se realiza un metodo Cargar Provincias
        public void CargarProvincias()
        {
            // Se cargan las provincias en la tabla del formulario
            lvwListaProvincias.Items.Clear();
            foreach (var iter in cliente.LeerProvincia())
            {
                ListViewItem item = new ListViewItem();
                item = lvwListaProvincias.Items.Add(Convert.ToString(iter.idProvincia));
                item.SubItems.Add(Convert.ToString(iter.Nombre));
            }
        }
        // Al inicializar el formmulario se Carga la Provincia y un Estado Inicial, ademas de la referencia Remota
        private void frmProvincias_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarProvincias();
            EstadoInicial();
        }
        // Se realiza un metodo de Estado Inicial para poder mantener de la misma manera como inicio el Formulario
        public void EstadoInicial()
        {
            txtNombreProvincia.Clear();
            txtNombreProvincia.Enabled = false;
            rbtnAgregarProvincia.Checked = false;
            rbtnEditarProvincia.Checked = false;
            rbtnEditarProvincia.Enabled = false;
            rbtnEliminarProvincia.Checked = false;
            rbtnEliminarProvincia.Enabled = false;
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
        private void lvwListaProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se controla que se haya presionado alguna fila no nula
            if (lvwListaProvincias.SelectedItems.Count > 0)
            {
                // Se realiza un cambio en los elementos del formulario
                EstadoInicial();
                rbtnAgregarProvincia.Checked = false;
                rbtnEditarProvincia.Enabled = true;
                rbtnEliminarProvincia.Enabled = true;

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
            txtNombreProvincia.Clear();
            lblNombre.Enabled = true;
            txtNombreProvincia.Enabled = true;
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
            txtNombreProvincia.Enabled = true;
            txtNombreProvincia.Text = lvwListaProvincias.SelectedItems[0].SubItems[1].Text;
            this.nombreProvinciaAux = txtNombreProvincia.Text;
            btnGuardar.Enabled = true;
            control = 1;
        }
        // Metodo para el Estado Inicial del GroupBox
        public void EstadoInicialGroupBox()
        {
            // Se habilitan los elementos necesarios
            gbControlProvincia.Enabled = true;
            lblNombre.Enabled = false;
            txtNombreProvincia.Clear();
            txtNombreProvincia.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Si se presiona el radio buton de Eliminar 
        private void Eliminar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo Estado Inicial GroupBox
            EstadoInicialGroupBox();
            // Se definen los elementos necesarios para usar
            txtNombreProvincia.Enabled = false;
            btnEliminar.Enabled = true;
            txtNombreProvincia.Text = lvwListaProvincias.SelectedItems[0].SubItems[1].Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Control de que no este en blanco el textbox
            if (string.IsNullOrEmpty(txtNombreProvincia.Text) == true)
            {
                // Se muestra un mensaje al usaurio de que existen casillas en blanco
                MessageBox.Show("Casilla en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si el control es el de Agregar
                if (control == 0)
                {
                    // Se realiza un control de que no exista la provincia a ingresar
                    if (cliente.BuscarProvincia(txtNombreProvincia.Text) == null)
                    {
                        // Se llama al metodo para Agregar Provincia de la referencia remota
                        cliente.AgregarProvincia(txtNombreProvincia.Text);
                        // Si se ha guardado exitosamente se muestra un mensaje
                        MessageBox.Show("Provincia Guardada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se llama al Estado Inicial
                        EstadoInicial();
                        // Se actualiza la tabla del formulario
                        CargarProvincias();
                    }
                    else 
                    {
                        // Se muestra un mensaje de que ya existe la provincia si se verifica lo mismo
                        MessageBox.Show("La provincia ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EstadoInicial();
                    }
                }
                // Si el control es el de Editar
                else if (control == 1)
                {
                    // Se verifica que se haya seleccionado una fila de la tabla del formulario
                    if (lvwListaProvincias.SelectedItems.Count > 0)
                    {
                        // Se guarda en un id auxiliar el id seleccionado en la tabla
                        int idAux;
                        ListViewItem item = lvwListaProvincias.SelectedItems[0];
                        idAux = Convert.ToInt32(item.Text);
                        // Se verifica si la provincia que se edita es la misma del textbox
                        // Con el fin de que no genere error
                        if (nombreProvinciaAux == txtNombreProvincia.Text)
                        {
                            // Se llama al Metodo de la referencia Remota para actualizar la provincia
                            cliente.EditarProvincia(idAux,txtNombreProvincia.Text);
                            // Se muestra un mensaje al usuario de que el proceso ha sido exitoso
                            MessageBox.Show("Provincia Actualizada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                        }
                        // Si la provincia es diferente a su edicion
                        else
                        {
                            // Se verifica de que no sea una provincia ya ingresada
                            if (cliente.BuscarProvincia(txtNombreProvincia.Text) == null)
                            {
                                // Se realiza el mismo proceso de actualziacion
                                cliente.EditarProvincia(idAux, txtNombreProvincia.Text);
                                MessageBox.Show("Provincia Actualizada Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EstadoInicial();
                            }
                            // Si ya existe una provincia se le hace saber al usuario
                            else
                            {
                                MessageBox.Show("Provincia ya ingresada!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                EstadoInicial();
                            }
                        }
                        // Se actualiza la tabla del formulario
                        CargarProvincias();
                    }
                    // Si no se ha seleccionado una fila del formulario se lo hace saber al usuario
                    else
                    {
                        MessageBox.Show("Seleccione una provincia para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }
        // Si se presiona el boton Eliminar, se elimina la fila seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se verifica de que se haya seleccionado un elemento dle formulario
            if (lvwListaProvincias.SelectedItems.Count > 0)
            {
                // Se guarda el id
                provinciaID = Convert.ToInt32(lvwListaProvincias.SelectedItems[0].Text);
                // Se llama al metodo de la referencia remota para eliminar el elemento
                cliente.EliminarProvincia(provinciaID);
                // Se hace saber al cliente de que se ha realizado el proceso correctamente
                MessageBox.Show("Provincia eliminada correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarProvincias();
                // Se llama al metodo de Estado Inicial
                EstadoInicial();
            }
            // Si no se ha seleccionado un elemento de la tabla, se lo hace saber al cliente
            else
            {
                MessageBox.Show("Seleccione una provincia para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
