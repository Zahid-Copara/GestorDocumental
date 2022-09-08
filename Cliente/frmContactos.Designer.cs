
namespace Cliente
{
    partial class frmContactos
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rbtnBuscar = new System.Windows.Forms.RadioButton();
            this.rbtnIngresar = new System.Windows.Forms.RadioButton();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cbTitulo = new System.Windows.Forms.ComboBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumTelfono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoElec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbListaContactos = new System.Windows.Forms.GroupBox();
            this.lvwContactos = new System.Windows.Forms.ListView();
            this.idContacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.correoElectronico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Celular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbListaContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(659, 716);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(116, 41);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rbtnBuscar
            // 
            this.rbtnBuscar.AutoSize = true;
            this.rbtnBuscar.Location = new System.Drawing.Point(29, 23);
            this.rbtnBuscar.Name = "rbtnBuscar";
            this.rbtnBuscar.Size = new System.Drawing.Size(73, 21);
            this.rbtnBuscar.TabIndex = 1;
            this.rbtnBuscar.TabStop = true;
            this.rbtnBuscar.Text = "Buscar";
            this.rbtnBuscar.UseVisualStyleBackColor = true;
            this.rbtnBuscar.CheckedChanged += new System.EventHandler(this.rbtnBuscar_CheckedChanged);
            this.rbtnBuscar.Click += new System.EventHandler(this.rbtnBuscar_Click);
            // 
            // rbtnIngresar
            // 
            this.rbtnIngresar.AutoSize = true;
            this.rbtnIngresar.Location = new System.Drawing.Point(185, 23);
            this.rbtnIngresar.Name = "rbtnIngresar";
            this.rbtnIngresar.Size = new System.Drawing.Size(124, 21);
            this.rbtnIngresar.TabIndex = 2;
            this.rbtnIngresar.TabStop = true;
            this.rbtnIngresar.Text = "Crear Contacto";
            this.rbtnIngresar.UseVisualStyleBackColor = true;
            this.rbtnIngresar.CheckedChanged += new System.EventHandler(this.rbtnIngresar_CheckedChanged);
            this.rbtnIngresar.Click += new System.EventHandler(this.rbtnCrear_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnIngresar);
            this.gbCliente.Controls.Add(this.cbTitulo);
            this.gbCliente.Controls.Add(this.cbCargo);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnBuscar);
            this.gbCliente.Controls.Add(this.txtNumTelfono);
            this.gbCliente.Controls.Add(this.label8);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.txtNumCedula);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.txtCelular);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.txtCorreoElec);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txtApellidoContacto);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Controls.Add(this.txtNombreContacto);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Location = new System.Drawing.Point(29, 60);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(746, 222);
            this.gbCliente.TabIndex = 3;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Contacto:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(583, 158);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 38);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Crear";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cbTitulo
            // 
            this.cbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitulo.FormattingEnabled = true;
            this.cbTitulo.Location = new System.Drawing.Point(406, 172);
            this.cbTitulo.Name = "cbTitulo";
            this.cbTitulo.Size = new System.Drawing.Size(135, 24);
            this.cbTitulo.TabIndex = 16;
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(406, 130);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(135, 24);
            this.cbCargo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(583, 93);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 38);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumTelfono
            // 
            this.txtNumTelfono.Location = new System.Drawing.Point(116, 172);
            this.txtNumTelfono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTelfono.Name = "txtNumTelfono";
            this.txtNumTelfono.Size = new System.Drawing.Size(132, 22);
            this.txtNumTelfono.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Num. Cedula:";
            // 
            // txtNumCedula
            // 
            this.txtNumCedula.Location = new System.Drawing.Point(117, 46);
            this.txtNumCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCedula.Name = "txtNumCedula";
            this.txtNumCedula.Size = new System.Drawing.Size(132, 22);
            this.txtNumCedula.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cargo:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(406, 90);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(135, 22);
            this.txtCelular.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Celular:";
            // 
            // txtCorreoElec
            // 
            this.txtCorreoElec.Location = new System.Drawing.Point(406, 47);
            this.txtCorreoElec.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElec.Name = "txtCorreoElec";
            this.txtCorreoElec.Size = new System.Drawing.Size(135, 22);
            this.txtCorreoElec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo Electrónico:";
            // 
            // txtApellidoContacto
            // 
            this.txtApellidoContacto.Location = new System.Drawing.Point(116, 130);
            this.txtApellidoContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoContacto.Name = "txtApellidoContacto";
            this.txtApellidoContacto.Size = new System.Drawing.Size(132, 22);
            this.txtApellidoContacto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(116, 89);
            this.txtNombreContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreContacto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // gbListaContactos
            // 
            this.gbListaContactos.Controls.Add(this.lvwContactos);
            this.gbListaContactos.Location = new System.Drawing.Point(29, 289);
            this.gbListaContactos.Name = "gbListaContactos";
            this.gbListaContactos.Size = new System.Drawing.Size(746, 356);
            this.gbListaContactos.TabIndex = 4;
            this.gbListaContactos.TabStop = false;
            this.gbListaContactos.Text = "Lista Contactos";
            // 
            // lvwContactos
            // 
            this.lvwContactos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idContacto,
            this.idCargo,
            this.idTitulo,
            this.Nombre,
            this.Apellido,
            this.numCedula,
            this.correoElectronico,
            this.Telefono,
            this.Celular});
            this.lvwContactos.FullRowSelect = true;
            this.lvwContactos.GridLines = true;
            this.lvwContactos.HideSelection = false;
            this.lvwContactos.Location = new System.Drawing.Point(7, 22);
            this.lvwContactos.Name = "lvwContactos";
            this.lvwContactos.Size = new System.Drawing.Size(733, 328);
            this.lvwContactos.TabIndex = 0;
            this.lvwContactos.UseCompatibleStateImageBehavior = false;
            this.lvwContactos.View = System.Windows.Forms.View.Details;
            this.lvwContactos.SelectedIndexChanged += new System.EventHandler(this.lvwContactos_SelectedIndexChanged);
            // 
            // idContacto
            // 
            this.idContacto.Text = "ID Contacto";
            this.idContacto.Width = 58;
            // 
            // idCargo
            // 
            this.idCargo.Text = "ID Cargo";
            this.idCargo.Width = 57;
            // 
            // idTitulo
            // 
            this.idTitulo.Text = "ID Titulo";
            this.idTitulo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 50;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 53;
            // 
            // numCedula
            // 
            this.numCedula.Text = "Num. Cedula";
            this.numCedula.Width = 76;
            // 
            // correoElectronico
            // 
            this.correoElectronico.Text = "Correo Electronico";
            this.correoElectronico.Width = 99;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.Width = 64;
            // 
            // Celular
            // 
            this.Celular.Text = "Celular";
            this.Celular.Width = 73;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(245, 672);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 41);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(425, 672);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 41);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 770);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbListaContactos);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.rbtnIngresar);
            this.Controls.Add(this.rbtnBuscar);
            this.Controls.Add(this.btnRegresar);
            this.Name = "frmContactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbListaContactos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.RadioButton rbtnBuscar;
        private System.Windows.Forms.RadioButton rbtnIngresar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumTelfono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoElec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTitulo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListaContactos;
        private System.Windows.Forms.ListView lvwContactos;
        private System.Windows.Forms.ColumnHeader idContacto;
        private System.Windows.Forms.ColumnHeader idCargo;
        private System.Windows.Forms.ColumnHeader idTitulo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader numCedula;
        private System.Windows.Forms.ColumnHeader correoElectronico;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Celular;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}