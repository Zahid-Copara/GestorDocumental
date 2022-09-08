
namespace Cliente
{
    partial class frmCargos
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
            this.gbControlCargo = new System.Windows.Forms.GroupBox();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbtnEliminarCargo = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnEditarCargo = new System.Windows.Forms.RadioButton();
            this.rbtnAgregarCargo = new System.Windows.Forms.RadioButton();
            this.gbListaCargos = new System.Windows.Forms.GroupBox();
            this.lvwListaCargos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cargos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControlCargo.SuspendLayout();
            this.gbListaCargos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(342, 394);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 40);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbControlCargo
            // 
            this.gbControlCargo.Controls.Add(this.txtNombreCargo);
            this.gbControlCargo.Controls.Add(this.lblNombre);
            this.gbControlCargo.Controls.Add(this.rbtnEliminarCargo);
            this.gbControlCargo.Controls.Add(this.btnEliminar);
            this.gbControlCargo.Controls.Add(this.btnGuardar);
            this.gbControlCargo.Controls.Add(this.rbtnEditarCargo);
            this.gbControlCargo.Controls.Add(this.rbtnAgregarCargo);
            this.gbControlCargo.Location = new System.Drawing.Point(12, 67);
            this.gbControlCargo.Name = "gbControlCargo";
            this.gbControlCargo.Size = new System.Drawing.Size(346, 266);
            this.gbControlCargo.TabIndex = 4;
            this.gbControlCargo.TabStop = false;
            this.gbControlCargo.Text = "Control Cargos";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(79, 147);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(240, 22);
            this.txtNombreCargo.TabIndex = 6;
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
            // rbtnEliminarCargo
            // 
            this.rbtnEliminarCargo.AutoSize = true;
            this.rbtnEliminarCargo.Location = new System.Drawing.Point(6, 86);
            this.rbtnEliminarCargo.Name = "rbtnEliminarCargo";
            this.rbtnEliminarCargo.Size = new System.Drawing.Size(121, 21);
            this.rbtnEliminarCargo.TabIndex = 4;
            this.rbtnEliminarCargo.TabStop = true;
            this.rbtnEliminarCargo.Text = "Eliminar Cargo";
            this.rbtnEliminarCargo.UseVisualStyleBackColor = true;
            this.rbtnEliminarCargo.Click += new System.EventHandler(this.Eliminar_Click);
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
            // rbtnEditarCargo
            // 
            this.rbtnEditarCargo.AutoSize = true;
            this.rbtnEditarCargo.Location = new System.Drawing.Point(6, 59);
            this.rbtnEditarCargo.Name = "rbtnEditarCargo";
            this.rbtnEditarCargo.Size = new System.Drawing.Size(108, 21);
            this.rbtnEditarCargo.TabIndex = 1;
            this.rbtnEditarCargo.TabStop = true;
            this.rbtnEditarCargo.Text = "Editar Cargo";
            this.rbtnEditarCargo.UseVisualStyleBackColor = true;
            this.rbtnEditarCargo.Click += new System.EventHandler(this.Editar_Click);
            // 
            // rbtnAgregarCargo
            // 
            this.rbtnAgregarCargo.AutoSize = true;
            this.rbtnAgregarCargo.Location = new System.Drawing.Point(6, 31);
            this.rbtnAgregarCargo.Name = "rbtnAgregarCargo";
            this.rbtnAgregarCargo.Size = new System.Drawing.Size(122, 21);
            this.rbtnAgregarCargo.TabIndex = 0;
            this.rbtnAgregarCargo.TabStop = true;
            this.rbtnAgregarCargo.Text = "Agregar Cargo";
            this.rbtnAgregarCargo.UseVisualStyleBackColor = true;
            this.rbtnAgregarCargo.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // gbListaCargos
            // 
            this.gbListaCargos.Controls.Add(this.lvwListaCargos);
            this.gbListaCargos.Location = new System.Drawing.Point(364, 17);
            this.gbListaCargos.Name = "gbListaCargos";
            this.gbListaCargos.Size = new System.Drawing.Size(424, 354);
            this.gbListaCargos.TabIndex = 3;
            this.gbListaCargos.TabStop = false;
            this.gbListaCargos.Text = "Lista Cargos";
            // 
            // lvwListaCargos
            // 
            this.lvwListaCargos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Cargos});
            this.lvwListaCargos.FullRowSelect = true;
            this.lvwListaCargos.GridLines = true;
            this.lvwListaCargos.HideSelection = false;
            this.lvwListaCargos.Location = new System.Drawing.Point(6, 22);
            this.lvwListaCargos.Name = "lvwListaCargos";
            this.lvwListaCargos.Size = new System.Drawing.Size(412, 322);
            this.lvwListaCargos.TabIndex = 0;
            this.lvwListaCargos.UseCompatibleStateImageBehavior = false;
            this.lvwListaCargos.View = System.Windows.Forms.View.Details;
            this.lvwListaCargos.SelectedIndexChanged += new System.EventHandler(this.lvwListaCargos_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // Cargos
            // 
            this.Cargos.Text = "Cargos";
            this.Cargos.Width = 164;
            // 
            // frmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbControlCargo);
            this.Controls.Add(this.gbListaCargos);
            this.Name = "frmCargos";
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.frmCargos_Load);
            this.gbControlCargo.ResumeLayout(false);
            this.gbControlCargo.PerformLayout();
            this.gbListaCargos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbControlCargo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnEliminarCargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnEditarCargo;
        private System.Windows.Forms.RadioButton rbtnAgregarCargo;
        private System.Windows.Forms.GroupBox gbListaCargos;
        private System.Windows.Forms.ListView lvwListaCargos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Cargos;
    }
}