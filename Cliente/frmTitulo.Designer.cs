
namespace Cliente
{
    partial class frmTitulo
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
            this.gbControlTitulos = new System.Windows.Forms.GroupBox();
            this.txtNombreTitulo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbtnEliminarTitulo = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnEditarTitulo = new System.Windows.Forms.RadioButton();
            this.rbtnAgregarTitulo = new System.Windows.Forms.RadioButton();
            this.gbListaTitulos = new System.Windows.Forms.GroupBox();
            this.lvwListaTitulos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titulos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControlTitulos.SuspendLayout();
            this.gbListaTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(342, 394);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 40);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbControlTitulos
            // 
            this.gbControlTitulos.Controls.Add(this.txtNombreTitulo);
            this.gbControlTitulos.Controls.Add(this.lblNombre);
            this.gbControlTitulos.Controls.Add(this.rbtnEliminarTitulo);
            this.gbControlTitulos.Controls.Add(this.btnEliminar);
            this.gbControlTitulos.Controls.Add(this.btnGuardar);
            this.gbControlTitulos.Controls.Add(this.rbtnEditarTitulo);
            this.gbControlTitulos.Controls.Add(this.rbtnAgregarTitulo);
            this.gbControlTitulos.Location = new System.Drawing.Point(12, 67);
            this.gbControlTitulos.Name = "gbControlTitulos";
            this.gbControlTitulos.Size = new System.Drawing.Size(346, 266);
            this.gbControlTitulos.TabIndex = 13;
            this.gbControlTitulos.TabStop = false;
            this.gbControlTitulos.Text = "Control Titulos";
            // 
            // txtNombreTitulo
            // 
            this.txtNombreTitulo.Location = new System.Drawing.Point(79, 147);
            this.txtNombreTitulo.Name = "txtNombreTitulo";
            this.txtNombreTitulo.Size = new System.Drawing.Size(240, 22);
            this.txtNombreTitulo.TabIndex = 6;
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
            // rbtnEliminarTitulo
            // 
            this.rbtnEliminarTitulo.AutoSize = true;
            this.rbtnEliminarTitulo.Location = new System.Drawing.Point(6, 86);
            this.rbtnEliminarTitulo.Name = "rbtnEliminarTitulo";
            this.rbtnEliminarTitulo.Size = new System.Drawing.Size(118, 21);
            this.rbtnEliminarTitulo.TabIndex = 4;
            this.rbtnEliminarTitulo.TabStop = true;
            this.rbtnEliminarTitulo.Text = "Eliminar Titulo";
            this.rbtnEliminarTitulo.UseVisualStyleBackColor = true;
            this.rbtnEliminarTitulo.Click += new System.EventHandler(this.Eliminar_Click);
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
            // rbtnEditarTitulo
            // 
            this.rbtnEditarTitulo.AutoSize = true;
            this.rbtnEditarTitulo.Location = new System.Drawing.Point(6, 59);
            this.rbtnEditarTitulo.Name = "rbtnEditarTitulo";
            this.rbtnEditarTitulo.Size = new System.Drawing.Size(105, 21);
            this.rbtnEditarTitulo.TabIndex = 1;
            this.rbtnEditarTitulo.TabStop = true;
            this.rbtnEditarTitulo.Text = "Editar Titulo";
            this.rbtnEditarTitulo.UseVisualStyleBackColor = true;
            this.rbtnEditarTitulo.Click += new System.EventHandler(this.Editar_Click);
            // 
            // rbtnAgregarTitulo
            // 
            this.rbtnAgregarTitulo.AutoSize = true;
            this.rbtnAgregarTitulo.Location = new System.Drawing.Point(6, 31);
            this.rbtnAgregarTitulo.Name = "rbtnAgregarTitulo";
            this.rbtnAgregarTitulo.Size = new System.Drawing.Size(119, 21);
            this.rbtnAgregarTitulo.TabIndex = 0;
            this.rbtnAgregarTitulo.TabStop = true;
            this.rbtnAgregarTitulo.Text = "Agregar Titulo";
            this.rbtnAgregarTitulo.UseVisualStyleBackColor = true;
            this.rbtnAgregarTitulo.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // gbListaTitulos
            // 
            this.gbListaTitulos.Controls.Add(this.lvwListaTitulos);
            this.gbListaTitulos.Location = new System.Drawing.Point(364, 17);
            this.gbListaTitulos.Name = "gbListaTitulos";
            this.gbListaTitulos.Size = new System.Drawing.Size(424, 354);
            this.gbListaTitulos.TabIndex = 12;
            this.gbListaTitulos.TabStop = false;
            this.gbListaTitulos.Text = "Lista Titulos";
            // 
            // lvwListaTitulos
            // 
            this.lvwListaTitulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Titulos});
            this.lvwListaTitulos.FullRowSelect = true;
            this.lvwListaTitulos.GridLines = true;
            this.lvwListaTitulos.HideSelection = false;
            this.lvwListaTitulos.Location = new System.Drawing.Point(6, 22);
            this.lvwListaTitulos.Name = "lvwListaTitulos";
            this.lvwListaTitulos.Size = new System.Drawing.Size(412, 322);
            this.lvwListaTitulos.TabIndex = 0;
            this.lvwListaTitulos.UseCompatibleStateImageBehavior = false;
            this.lvwListaTitulos.View = System.Windows.Forms.View.Details;
            this.lvwListaTitulos.SelectedIndexChanged += new System.EventHandler(this.lvwListaTitulos_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // Titulos
            // 
            this.Titulos.Text = "Titulos";
            this.Titulos.Width = 164;
            // 
            // frmTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbControlTitulos);
            this.Controls.Add(this.gbListaTitulos);
            this.Name = "frmTitulo";
            this.Text = "Titulos";
            this.Load += new System.EventHandler(this.frmTitulo_Load);
            this.gbControlTitulos.ResumeLayout(false);
            this.gbControlTitulos.PerformLayout();
            this.gbListaTitulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbControlTitulos;
        private System.Windows.Forms.TextBox txtNombreTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnEliminarTitulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnEditarTitulo;
        private System.Windows.Forms.RadioButton rbtnAgregarTitulo;
        private System.Windows.Forms.GroupBox gbListaTitulos;
        private System.Windows.Forms.ListView lvwListaTitulos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Titulos;
    }
}