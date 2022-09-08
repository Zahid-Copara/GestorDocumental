
namespace Cliente
{
    partial class frmProvincias
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
            this.gbListaProvincia = new System.Windows.Forms.GroupBox();
            this.lvwListaProvincias = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provincia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControlProvincia = new System.Windows.Forms.GroupBox();
            this.rbtnAgregarProvincia = new System.Windows.Forms.RadioButton();
            this.rbtnEditarProvincia = new System.Windows.Forms.RadioButton();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rbtnEliminarProvincia = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.gbListaProvincia.SuspendLayout();
            this.gbControlProvincia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaProvincia
            // 
            this.gbListaProvincia.Controls.Add(this.lvwListaProvincias);
            this.gbListaProvincia.Location = new System.Drawing.Point(364, 12);
            this.gbListaProvincia.Name = "gbListaProvincia";
            this.gbListaProvincia.Size = new System.Drawing.Size(424, 354);
            this.gbListaProvincia.TabIndex = 0;
            this.gbListaProvincia.TabStop = false;
            this.gbListaProvincia.Text = "Lista Provincias";
            // 
            // lvwListaProvincias
            // 
            this.lvwListaProvincias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Provincia});
            this.lvwListaProvincias.FullRowSelect = true;
            this.lvwListaProvincias.GridLines = true;
            this.lvwListaProvincias.HideSelection = false;
            this.lvwListaProvincias.Location = new System.Drawing.Point(6, 22);
            this.lvwListaProvincias.Name = "lvwListaProvincias";
            this.lvwListaProvincias.Size = new System.Drawing.Size(412, 322);
            this.lvwListaProvincias.TabIndex = 0;
            this.lvwListaProvincias.UseCompatibleStateImageBehavior = false;
            this.lvwListaProvincias.View = System.Windows.Forms.View.Details;
            this.lvwListaProvincias.SelectedIndexChanged += new System.EventHandler(this.lvwListaProvincias_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // Provincia
            // 
            this.Provincia.Text = "Provincia";
            this.Provincia.Width = 164;
            // 
            // gbControlProvincia
            // 
            this.gbControlProvincia.Controls.Add(this.txtNombreProvincia);
            this.gbControlProvincia.Controls.Add(this.lblNombre);
            this.gbControlProvincia.Controls.Add(this.rbtnEliminarProvincia);
            this.gbControlProvincia.Controls.Add(this.btnEliminar);
            this.gbControlProvincia.Controls.Add(this.btnGuardar);
            this.gbControlProvincia.Controls.Add(this.rbtnEditarProvincia);
            this.gbControlProvincia.Controls.Add(this.rbtnAgregarProvincia);
            this.gbControlProvincia.Location = new System.Drawing.Point(12, 62);
            this.gbControlProvincia.Name = "gbControlProvincia";
            this.gbControlProvincia.Size = new System.Drawing.Size(346, 266);
            this.gbControlProvincia.TabIndex = 1;
            this.gbControlProvincia.TabStop = false;
            this.gbControlProvincia.Text = "Control Provincias";
            // 
            // rbtnAgregarProvincia
            // 
            this.rbtnAgregarProvincia.AutoSize = true;
            this.rbtnAgregarProvincia.Location = new System.Drawing.Point(6, 31);
            this.rbtnAgregarProvincia.Name = "rbtnAgregarProvincia";
            this.rbtnAgregarProvincia.Size = new System.Drawing.Size(142, 21);
            this.rbtnAgregarProvincia.TabIndex = 0;
            this.rbtnAgregarProvincia.TabStop = true;
            this.rbtnAgregarProvincia.Text = "Agregar Provincia";
            this.rbtnAgregarProvincia.UseVisualStyleBackColor = true;
            this.rbtnAgregarProvincia.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // rbtnEditarProvincia
            // 
            this.rbtnEditarProvincia.AutoSize = true;
            this.rbtnEditarProvincia.Location = new System.Drawing.Point(6, 59);
            this.rbtnEditarProvincia.Name = "rbtnEditarProvincia";
            this.rbtnEditarProvincia.Size = new System.Drawing.Size(128, 21);
            this.rbtnEditarProvincia.TabIndex = 1;
            this.rbtnEditarProvincia.TabStop = true;
            this.rbtnEditarProvincia.Text = "Editar Provincia";
            this.rbtnEditarProvincia.UseVisualStyleBackColor = true;
            this.rbtnEditarProvincia.Click += new System.EventHandler(this.Editar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(342, 389);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 40);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            // rbtnEliminarProvincia
            // 
            this.rbtnEliminarProvincia.AutoSize = true;
            this.rbtnEliminarProvincia.Location = new System.Drawing.Point(6, 86);
            this.rbtnEliminarProvincia.Name = "rbtnEliminarProvincia";
            this.rbtnEliminarProvincia.Size = new System.Drawing.Size(141, 21);
            this.rbtnEliminarProvincia.TabIndex = 4;
            this.rbtnEliminarProvincia.TabStop = true;
            this.rbtnEliminarProvincia.Text = "Eliminar Provincia";
            this.rbtnEliminarProvincia.UseVisualStyleBackColor = true;
            this.rbtnEliminarProvincia.Click += new System.EventHandler(this.Eliminar_Click);
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
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Location = new System.Drawing.Point(79, 147);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(240, 22);
            this.txtNombreProvincia.TabIndex = 6;
            // 
            // frmProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbControlProvincia);
            this.Controls.Add(this.gbListaProvincia);
            this.Name = "frmProvincias";
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.frmProvincias_Load);
            this.gbListaProvincia.ResumeLayout(false);
            this.gbControlProvincia.ResumeLayout(false);
            this.gbControlProvincia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaProvincia;
        private System.Windows.Forms.ListView lvwListaProvincias;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Provincia;
        private System.Windows.Forms.GroupBox gbControlProvincia;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnEliminarProvincia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnEditarProvincia;
        private System.Windows.Forms.RadioButton rbtnAgregarProvincia;
        private System.Windows.Forms.Button btnRegresar;
    }
}