
namespace Cliente
{
    partial class frmCategoriaCorreos
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
            this.gbControlCorreos = new System.Windows.Forms.GroupBox();
            this.txtNombreCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbtnEliminarCorreo = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnEditarCorreo = new System.Windows.Forms.RadioButton();
            this.rbtnAgregarCorreo = new System.Windows.Forms.RadioButton();
            this.gbListaCorreos = new System.Windows.Forms.GroupBox();
            this.lvwListaCorreos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoriaCorreos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControlCorreos.SuspendLayout();
            this.gbListaCorreos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(342, 394);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 40);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbControlCorreos
            // 
            this.gbControlCorreos.Controls.Add(this.txtNombreCorreo);
            this.gbControlCorreos.Controls.Add(this.lblNombre);
            this.gbControlCorreos.Controls.Add(this.rbtnEliminarCorreo);
            this.gbControlCorreos.Controls.Add(this.btnEliminar);
            this.gbControlCorreos.Controls.Add(this.btnGuardar);
            this.gbControlCorreos.Controls.Add(this.rbtnEditarCorreo);
            this.gbControlCorreos.Controls.Add(this.rbtnAgregarCorreo);
            this.gbControlCorreos.Location = new System.Drawing.Point(12, 67);
            this.gbControlCorreos.Name = "gbControlCorreos";
            this.gbControlCorreos.Size = new System.Drawing.Size(346, 266);
            this.gbControlCorreos.TabIndex = 7;
            this.gbControlCorreos.TabStop = false;
            this.gbControlCorreos.Text = "Control Categoria Correos";
            // 
            // txtNombreCorreo
            // 
            this.txtNombreCorreo.Location = new System.Drawing.Point(79, 147);
            this.txtNombreCorreo.Name = "txtNombreCorreo";
            this.txtNombreCorreo.Size = new System.Drawing.Size(240, 22);
            this.txtNombreCorreo.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // rbtnEliminarCorreo
            // 
            this.rbtnEliminarCorreo.AutoSize = true;
            this.rbtnEliminarCorreo.Location = new System.Drawing.Point(6, 86);
            this.rbtnEliminarCorreo.Name = "rbtnEliminarCorreo";
            this.rbtnEliminarCorreo.Size = new System.Drawing.Size(191, 21);
            this.rbtnEliminarCorreo.TabIndex = 4;
            this.rbtnEliminarCorreo.TabStop = true;
            this.rbtnEliminarCorreo.Text = "Eliminar Categoria Correo";
            this.rbtnEliminarCorreo.UseVisualStyleBackColor = true;
            this.rbtnEliminarCorreo.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(185, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbtnEditarCorreo
            // 
            this.rbtnEditarCorreo.AutoSize = true;
            this.rbtnEditarCorreo.Location = new System.Drawing.Point(6, 59);
            this.rbtnEditarCorreo.Name = "rbtnEditarCorreo";
            this.rbtnEditarCorreo.Size = new System.Drawing.Size(178, 21);
            this.rbtnEditarCorreo.TabIndex = 1;
            this.rbtnEditarCorreo.TabStop = true;
            this.rbtnEditarCorreo.Text = "Editar Categoria Correo";
            this.rbtnEditarCorreo.UseVisualStyleBackColor = true;
            this.rbtnEditarCorreo.Click += new System.EventHandler(this.Editar_Click);
            // 
            // rbtnAgregarCorreo
            // 
            this.rbtnAgregarCorreo.AutoSize = true;
            this.rbtnAgregarCorreo.Location = new System.Drawing.Point(6, 31);
            this.rbtnAgregarCorreo.Name = "rbtnAgregarCorreo";
            this.rbtnAgregarCorreo.Size = new System.Drawing.Size(192, 21);
            this.rbtnAgregarCorreo.TabIndex = 0;
            this.rbtnAgregarCorreo.TabStop = true;
            this.rbtnAgregarCorreo.Text = "Agregar Categoria Correo";
            this.rbtnAgregarCorreo.UseVisualStyleBackColor = true;
            this.rbtnAgregarCorreo.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // gbListaCorreos
            // 
            this.gbListaCorreos.Controls.Add(this.lvwListaCorreos);
            this.gbListaCorreos.Location = new System.Drawing.Point(364, 17);
            this.gbListaCorreos.Name = "gbListaCorreos";
            this.gbListaCorreos.Size = new System.Drawing.Size(424, 354);
            this.gbListaCorreos.TabIndex = 6;
            this.gbListaCorreos.TabStop = false;
            this.gbListaCorreos.Text = "Lista Categoria Correos";
            // 
            // lvwListaCorreos
            // 
            this.lvwListaCorreos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CategoriaCorreos});
            this.lvwListaCorreos.FullRowSelect = true;
            this.lvwListaCorreos.GridLines = true;
            this.lvwListaCorreos.HideSelection = false;
            this.lvwListaCorreos.Location = new System.Drawing.Point(6, 22);
            this.lvwListaCorreos.Name = "lvwListaCorreos";
            this.lvwListaCorreos.Size = new System.Drawing.Size(412, 322);
            this.lvwListaCorreos.TabIndex = 0;
            this.lvwListaCorreos.UseCompatibleStateImageBehavior = false;
            this.lvwListaCorreos.View = System.Windows.Forms.View.Details;
            this.lvwListaCorreos.SelectedIndexChanged += new System.EventHandler(this.lvwListaCorreos_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // CategoriaCorreos
            // 
            this.CategoriaCorreos.Text = "Categoria Correos";
            this.CategoriaCorreos.Width = 164;
            // 
            // frmCategoriaCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbControlCorreos);
            this.Controls.Add(this.gbListaCorreos);
            this.Name = "frmCategoriaCorreos";
            this.Text = "Categoria Correos";
            this.Load += new System.EventHandler(this.frmCategoriaCorreos_Load);
            this.gbControlCorreos.ResumeLayout(false);
            this.gbControlCorreos.PerformLayout();
            this.gbListaCorreos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbControlCorreos;
        private System.Windows.Forms.TextBox txtNombreCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnEliminarCorreo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnEditarCorreo;
        private System.Windows.Forms.RadioButton rbtnAgregarCorreo;
        private System.Windows.Forms.GroupBox gbListaCorreos;
        private System.Windows.Forms.ListView lvwListaCorreos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CategoriaCorreos;
    }
}