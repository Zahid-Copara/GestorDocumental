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
    public partial class frmTitulo : Form
    {
        // Se llama a la Referencia Remota para instanciarla en el formulario
        ReferenciaRemota.GestionDocumentoClient cliente;
        // Se declaran variables para poder utilizarlas en el formulario
        private string nombreTituloAux;
        private int control;
        private int tituloID;

        public frmTitulo()
        {
            InitializeComponent();
        }
        // Se realiza un metodo Cargar Titulos
        public void CargarTitulos()
        {
            // Se cargan los Titulos en la tabla del formulario
            lvwListaTitulos.Items.Clear();
            foreach (var iter in cliente.LeerTitulo())
            {
                ListViewItem item = new ListViewItem();
                item = lvwListaTitulos.Items.Add(Convert.ToString(iter.idTitulo));
                item.SubItems.Add(Convert.ToString(iter.Nombre));
            }
        }
        // Se realiza un metodo de Estado Inicial para poder mantener de la misma manera como inicio el Formulario
        public void EstadoInicial()
        {
            txtNombreTitulo.Clear();
            txtNombreTitulo.Enabled = false;
            rbtnAgregarTitulo.Checked = false;
            rbtnEditarTitulo.Checked = false;
            rbtnEditarTitulo.Enabled = false;
            rbtnEliminarTitulo.Checked = false;
            rbtnEliminarTitulo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Metodo para el Estado Inicial del GroupBox
        public void EstadoInicialGroupBox()
        {
            // Se habilitan los elementos necesarios
            gbControlTitulos.Enabled = true;
            lblNombre.Enabled = false;
            txtNombreTitulo.Clear();
            txtNombreTitulo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        // Si se presiona el radio button Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            // Se muestra el estado inicial del GroupBox
            EstadoInicialGroupBox();
            // Se define los elementos que se van a utilizar dentro del GroupBox
            txtNombreTitulo.Clear();
            lblNombre.Enabled = true;
            txtNombreTitulo.Enabled = true;
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
            txtNombreTitulo.Enabled = true;
            txtNombreTitulo.Text = lvwListaTitulos.SelectedItems[0].SubItems[1].Text;
            this.nombreTituloAux = txtNombreTitulo.Text;
            btnGuardar.Enabled = true;
            control = 1;
        }
        // Si se presiona el radio buton de Eliminar
        private void Eliminar_Click(object sender, EventArgs e)
        {
            // Se llama al metodo Estado Inicial GroupBox
            EstadoInicialGroupBox();
            // Se definen los elementos necesarios para usar
            txtNombreTitulo.Enabled = false;
            btnEliminar.Enabled = true;
            txtNombreTitulo.Text = lvwListaTitulos.SelectedItems[0].SubItems[1].Text;
        }
        // Al inicializar el formmulario se Carga los Titulos y un Estado Inicial, ademas de la referencia Remota
        private void frmTitulo_Load(object sender, EventArgs e)
        {
            cliente = new ReferenciaRemota.GestionDocumentoClient();
            CargarTitulos();
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
        private void lvwListaTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se controla que se haya presionado alguna fila no nula
            if (lvwListaTitulos.SelectedItems.Count > 0)
            {
                // Se realiza un cambio en los elementos del formulario
                EstadoInicial();
                rbtnAgregarTitulo.Checked = false;
                rbtnEditarTitulo.Enabled = true;
                rbtnEliminarTitulo.Enabled = true;

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
            if (string.IsNullOrEmpty(txtNombreTitulo.Text) == true)
            {
                // Se muestra un mensaje al usaurio de que existen casillas en blanco
                MessageBox.Show("Casilla en blanco!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si el control es el de Agregar
                if (control == 0)
                {
                    // Se realiza un control de que no exista el Titulo a ingresar
                    if (cliente.BuscarTitulo(txtNombreTitulo.Text) == null)
                    {
                        // Se llama al metodo para Agregar Titulo de la referencia remota
                        cliente.AgregarTitulo(txtNombreTitulo.Text);
                        // Si se ha guardado exitosamente se muestra un mensaje
                        MessageBox.Show("Titulo Guardado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se llama al Estado Inicial
                        EstadoInicial();
                        // Se actualiza la tabla del formulario
                        CargarTitulos();
                    }
                    else
                    {
                        // Se muestra un mensaje de que ya existe el Titulo si se verifica lo mismo
                        MessageBox.Show("El Titulo ya existe!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EstadoInicial();
                    }
                }
                // Si el control es el de Editar
                else if (control == 1)
                {
                    // Se verifica que se haya seleccionado una fila de la tabla del formulario
                    if (lvwListaTitulos.SelectedItems.Count > 0)
                    {
                        // Se guarda en un id auxiliar el id seleccionado en la tabla
                        int idAux;
                        ListViewItem item = lvwListaTitulos.SelectedItems[0];
                        idAux = Convert.ToInt32(item.Text);
                        // Se verifica si el Titulo que se edita es el mismo del textbox
                        // Con el fin de que no genere error
                        if (nombreTituloAux == txtNombreTitulo.Text)
                        {
                            // Se llama al Metodo de la referencia Remota para actualizar el Titulo
                            cliente.EditarTitulo(idAux, txtNombreTitulo.Text);
                            // Se muestra un mensaje al usuario de que el proceso ha sido exitoso
                            MessageBox.Show("Titulo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                        }
                        // Si el Titulo es diferente a su edicion
                        else
                        {
                            // Se verifica de que no sea un Titulo ya ingresado
                            if (cliente.BuscarTitulo(txtNombreTitulo.Text) == null)
                            {
                                // Se realiza el mismo proceso de actualziacion
                                cliente.EditarTitulo(idAux, txtNombreTitulo.Text);
                                MessageBox.Show("Titulo Actualizado Exitosamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EstadoInicial();
                            }
                            // Si ya existe un Titulo se le hace saber al usuario
                            else
                            {
                                MessageBox.Show("Titulo ya ingresado!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                EstadoInicial();
                            }
                        }
                        // Se actualiza la tabla del formulario
                        CargarTitulos();
                    }
                    // Si no se ha seleccionado una fila del formulario se lo hace saber al usuario
                    else
                    {
                        MessageBox.Show("Seleccione un Titulo para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        // Se llama al evento del boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se verifica de que se haya seleccionado un elemento del formulario
            if (lvwListaTitulos.SelectedItems.Count > 0)
            {
                // Se guarda el id
                tituloID = Convert.ToInt32(lvwListaTitulos.SelectedItems[0].Text);
                // Se llama al metodo de la referencia remota para eliminar el elemento
                cliente.EliminarTitulo(tituloID);
                // Se hace saber al cliente de que se ha realizado el proceso correctamente
                MessageBox.Show("Titulo eliminado correctamente!!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Se actualiza la tabla del formulario
                CargarTitulos();
                // Se llama al metodo de Estado Inicial
                EstadoInicial();
            }
            // Si no se ha seleccionado un elemento de la tabla, se lo hace saber al cliente
            else
            {
                MessageBox.Show("Seleccione un Titulo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
