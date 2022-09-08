
namespace Cliente
{
    partial class frmOrganizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbListaOrg = new System.Windows.Forms.GroupBox();
            this.lvwOrg = new System.Windows.Forms.ListView();
            this.idOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.direccionOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ciudadOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idProvincia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonoOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.correoOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sitioWebOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbOrganizacion = new System.Windows.Forms.GroupBox();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoElec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionOrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRUC = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rbtnBuscarOrg = new System.Windows.Forms.RadioButton();
            this.rbtnCrearOrg = new System.Windows.Forms.RadioButton();
            this.gbListaOrg.SuspendLayout();
            this.gbOrganizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaOrg
            // 
            this.gbListaOrg.Controls.Add(this.lvwOrg);
            this.gbListaOrg.Location = new System.Drawing.Point(20, 340);
            this.gbListaOrg.Name = "gbListaOrg";
            this.gbListaOrg.Size = new System.Drawing.Size(746, 303);
            this.gbListaOrg.TabIndex = 6;
            this.gbListaOrg.TabStop = false;
            this.gbListaOrg.Text = "Lista Organizaciones";
            // 
            // lvwOrg
            // 
            this.lvwOrg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idOrg,
            this.nombreOrg,
            this.direccionOrg,
            this.codigoPostal,
            this.ciudadOrg,
            this.idProvincia,
            this.telefonoOrg,
            this.correoOrg,
            this.sitioWebOrg});
            this.lvwOrg.FullRowSelect = true;
            this.lvwOrg.GridLines = true;
            this.lvwOrg.HideSelection = false;
            this.lvwOrg.Location = new System.Drawing.Point(6, 22);
            this.lvwOrg.Name = "lvwOrg";
            this.lvwOrg.Size = new System.Drawing.Size(733, 275);
            this.lvwOrg.TabIndex = 0;
            this.lvwOrg.UseCompatibleStateImageBehavior = false;
            this.lvwOrg.View = System.Windows.Forms.View.Details;
            // 
            // idOrg
            // 
            this.idOrg.Text = "ID";
            // 
            // nombreOrg
            // 
            this.nombreOrg.Text = "Nombre";
            // 
            // direccionOrg
            // 
            this.direccionOrg.Text = "Direccion";
            // 
            // codigoPostal
            // 
            this.codigoPostal.Text = "Codigo Postal";
            // 
            // ciudadOrg
            // 
            this.ciudadOrg.Text = "Ciudad";
            // 
            // telefonoOrg
            // 
            this.telefonoOrg.Text = "Telefono";
            // 
            // correoOrg
            // 
            this.correoOrg.Text = "Correo Electronico";
            // 
            // sitioWebOrg
            // 
            this.sitioWebOrg.Text = "Sitio Web";
            // 
            // gbOrganizacion
            // 
            this.gbOrganizacion.Controls.Add(this.txtSitioWeb);
            this.gbOrganizacion.Controls.Add(this.label9);
            this.gbOrganizacion.Controls.Add(this.txtCiudad);
            this.gbOrganizacion.Controls.Add(this.btnIngresar);
            this.gbOrganizacion.Controls.Add(this.cbProvincia);
            this.gbOrganizacion.Controls.Add(this.label1);
            this.gbOrganizacion.Controls.Add(this.txtCodigoPostal);
            this.gbOrganizacion.Controls.Add(this.label8);
            this.gbOrganizacion.Controls.Add(this.label7);
            this.gbOrganizacion.Controls.Add(this.txtTelefono);
            this.gbOrganizacion.Controls.Add(this.label6);
            this.gbOrganizacion.Controls.Add(this.txtCorreoElec);
            this.gbOrganizacion.Controls.Add(this.label5);
            this.gbOrganizacion.Controls.Add(this.txtDireccionOrg);
            this.gbOrganizacion.Controls.Add(this.label3);
            this.gbOrganizacion.Controls.Add(this.txtNombreOrg);
            this.gbOrganizacion.Controls.Add(this.label2);
            this.gbOrganizacion.Location = new System.Drawing.Point(20, 118);
            this.gbOrganizacion.Name = "gbOrganizacion";
            this.gbOrganizacion.Size = new System.Drawing.Size(746, 216);
            this.gbOrganizacion.TabIndex = 5;
            this.gbOrganizacion.TabStop = false;
            this.gbOrganizacion.Text = "Datos Organizacion:";
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.Location = new System.Drawing.Point(406, 172);
            this.txtSitioWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(135, 22);
            this.txtSitioWeb.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sitio Web:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(117, 172);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(135, 22);
            this.txtCiudad.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(591, 92);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 38);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Crear";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(406, 49);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(135, 24);
            this.cbProvincia.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ciudad:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(117, 131);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(135, 22);
            this.txtCodigoPostal.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "CodigoPostal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Provincia:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(406, 90);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono:";
            // 
            // txtCorreoElec
            // 
            this.txtCorreoElec.Location = new System.Drawing.Point(406, 131);
            this.txtCorreoElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElec.Name = "txtCorreoElec";
            this.txtCorreoElec.Size = new System.Drawing.Size(135, 22);
            this.txtCorreoElec.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correo Electrónico:";
            // 
            // txtDireccionOrg
            // 
            this.txtDireccionOrg.Location = new System.Drawing.Point(117, 89);
            this.txtDireccionOrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionOrg.Name = "txtDireccionOrg";
            this.txtDireccionOrg.Size = new System.Drawing.Size(135, 22);
            this.txtDireccionOrg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // txtNombreOrg
            // 
            this.txtNombreOrg.Location = new System.Drawing.Point(117, 48);
            this.txtNombreOrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreOrg.Name = "txtNombreOrg";
            this.txtNombreOrg.Size = new System.Drawing.Size(135, 22);
            this.txtNombreOrg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(228, 65);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Location = new System.Drawing.Point(17, 69);
            this.lblRUC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(41, 17);
            this.lblRUC.TabIndex = 2;
            this.lblRUC.Text = "RUC:";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(66, 67);
            this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(132, 22);
            this.txtRUC.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(416, 666);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(236, 666);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 41);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(650, 710);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 41);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rbtnBuscarOrg
            // 
            this.rbtnBuscarOrg.AutoSize = true;
            this.rbtnBuscarOrg.Location = new System.Drawing.Point(20, 21);
            this.rbtnBuscarOrg.Name = "rbtnBuscarOrg";
            this.rbtnBuscarOrg.Size = new System.Drawing.Size(73, 21);
            this.rbtnBuscarOrg.TabIndex = 10;
            this.rbtnBuscarOrg.TabStop = true;
            this.rbtnBuscarOrg.Text = "Buscar";
            this.rbtnBuscarOrg.UseVisualStyleBackColor = true;
            this.rbtnBuscarOrg.Click += new System.EventHandler(this.rbtnBuscar_Click);
            // 
            // rbtnCrearOrg
            // 
            this.rbtnCrearOrg.AutoSize = true;
            this.rbtnCrearOrg.Location = new System.Drawing.Point(162, 21);
            this.rbtnCrearOrg.Name = "rbtnCrearOrg";
            this.rbtnCrearOrg.Size = new System.Drawing.Size(152, 21);
            this.rbtnCrearOrg.TabIndex = 11;
            this.rbtnCrearOrg.TabStop = true;
            this.rbtnCrearOrg.Text = "Crear Organizacion";
            this.rbtnCrearOrg.UseVisualStyleBackColor = true;
            this.rbtnCrearOrg.Click += new System.EventHandler(this.rbtnCrear_Click);
            // 
            // frmOrganizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 763);
            this.ControlBox = false;
            this.Controls.Add(this.rbtnCrearOrg);
            this.Controls.Add(this.rbtnBuscarOrg);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbListaOrg);
            this.Controls.Add(this.gbOrganizacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.txtRUC);
            this.Name = "frmOrganizaciones";
            this.Text = "Organizaciones";
            this.Load += new System.EventHandler(this.frmOrganizaciones_Load);
            this.gbListaOrg.ResumeLayout(false);
            this.gbOrganizacion.ResumeLayout(false);
            this.gbOrganizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaOrg;
        private System.Windows.Forms.ListView lvwOrg;
        private System.Windows.Forms.GroupBox gbOrganizacion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoElec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ColumnHeader idOrg;
        private System.Windows.Forms.ColumnHeader nombreOrg;
        private System.Windows.Forms.ColumnHeader direccionOrg;
        private System.Windows.Forms.ColumnHeader codigoPostal;
        private System.Windows.Forms.ColumnHeader ciudadOrg;
        private System.Windows.Forms.ColumnHeader idProvincia;
        private System.Windows.Forms.ColumnHeader telefonoOrg;
        private System.Windows.Forms.ColumnHeader correoOrg;
        private System.Windows.Forms.ColumnHeader sitioWebOrg;
        private System.Windows.Forms.RadioButton rbtnBuscarOrg;
        private System.Windows.Forms.RadioButton rbtnCrearOrg;
    }
}