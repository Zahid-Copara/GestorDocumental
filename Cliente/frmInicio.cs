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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }

        //Evento de cierre de Formulario Principal
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Evento para ingresar al formulario de Contactos
        private void btnContactos_Click(object sender, EventArgs e)
        {
            frmContactos contactos = new frmContactos();
            contactos.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Provincias
        private void btnProvincias_Click(object sender, EventArgs e)
        {
            frmProvincias provincias = new frmProvincias();
            provincias.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Cargos
        private void btnCargos_Click(object sender, EventArgs e)
        {
            frmCargos cargos = new frmCargos();
            cargos.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Categoria Correo
        private void btnCategoriaCorreo_Click(object sender, EventArgs e)
        {
            frmCategoriaCorreos categoriaCorreos = new frmCategoriaCorreos();
            categoriaCorreos.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Grupo Costos
        private void btnGrupoCostos_Click(object sender, EventArgs e)
        {
            frmGrupoCostos grupoCostos = new frmGrupoCostos();
            grupoCostos.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Titulos
        private void btnTitulo_Click(object sender, EventArgs e)
        {
            frmTitulo titulos = new frmTitulo();
            titulos.Show();
            this.Hide();
        }
        //Evento para ingresar al formulario de Organizaciones
        private void btnOrganizaciones_Click(object sender, EventArgs e)
        {
            frmOrganizaciones organizacion = new frmOrganizaciones();
            organizacion.Show();
            this.Hide();
        }
        

    }
}
