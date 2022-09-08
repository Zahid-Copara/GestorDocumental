
namespace Cliente
{
    partial class frmGrupoCostos
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
            this.gbControlGrupoCostos = new System.Windows.Forms.GroupBox();
            this.txtNombreGrupoCosto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbtnEliminarGrupoCosto = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnEditarGrupoCosto = new System.Windows.Forms.RadioButton();
            this.rbtnAgregarGrupoCosto = new System.Windows.Forms.RadioButton();
            this.gbListaGrupoCostos = new System.Windows.Forms.GroupBox();
            this.lvwListaGrupoCostos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrupoCostos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbControlGrupoCostos.SuspendLayout();
            this.gbListaGrupoCostos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(342, 394);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 40);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbControlGrupoCostos
            // 
            this.gbControlGrupoCostos.Controls.Add(this.txtNombreGrupoCosto);
            this.gbControlGrupoCostos.Controls.Add(this.lblNombre);
            this.gbControlGrupoCostos.Controls.Add(this.rbtnEliminarGrupoCosto);
            this.gbControlGrupoCostos.Controls.Add(this.btnEliminar);
            this.gbControlGrupoCostos.Controls.Add(this.btnGuardar);
            this.gbControlGrupoCostos.Controls.Add(this.rbtnEditarGrupoCosto);
            this.gbControlGrupoCostos.Controls.Add(this.rbtnAgregarGrupoCosto);
            this.gbControlGrupoCostos.Location = new System.Drawing.Point(12, 67);
            this.gbControlGrupoCostos.Name = "gbControlGrupoCostos";
            this.gbControlGrupoCostos.Size = new System.Drawing.Size(346, 266);
            this.gbControlGrupoCostos.TabIndex = 10;
            this.gbControlGrupoCostos.TabStop = false;
            this.gbControlGrupoCostos.Text = "Control Grupo Costos";
            // 
            // txtNombreGrupoCosto
            // 
            this.txtNombreGrupoCosto.Location = new System.Drawing.Point(79, 147);
            this.txtNombreGrupoCosto.Name = "txtNombreGrupoCosto";
            this.txtNombreGrupoCosto.Size = new System.Drawing.Size(240, 22);
            this.txtNombreGrupoCosto.TabIndex = 6;
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
            // rbtnEliminarGrupoCosto
            // 
            this.rbtnEliminarGrupoCosto.AutoSize = true;
            this.rbtnEliminarGrupoCosto.Location = new System.Drawing.Point(6, 86);
            this.rbtnEliminarGrupoCosto.Name = "rbtnEliminarGrupoCosto";
            this.rbtnEliminarGrupoCosto.Size = new System.Drawing.Size(163, 21);
            this.rbtnEliminarGrupoCosto.TabIndex = 4;
            this.rbtnEliminarGrupoCosto.TabStop = true;
            this.rbtnEliminarGrupoCosto.Text = "Eliminar Grupo Costo";
            this.rbtnEliminarGrupoCosto.UseVisualStyleBackColor = true;
            this.rbtnEliminarGrupoCosto.Click += new System.EventHandler(this.Eliminar_Click);
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
            // rbtnEditarGrupoCosto
            // 
            this.rbtnEditarGrupoCosto.AutoSize = true;
            this.rbtnEditarGrupoCosto.Location = new System.Drawing.Point(6, 59);
            this.rbtnEditarGrupoCosto.Name = "rbtnEditarGrupoCosto";
            this.rbtnEditarGrupoCosto.Size = new System.Drawing.Size(150, 21);
            this.rbtnEditarGrupoCosto.TabIndex = 1;
            this.rbtnEditarGrupoCosto.TabStop = true;
            this.rbtnEditarGrupoCosto.Text = "Editar Grupo Costo";
            this.rbtnEditarGrupoCosto.UseVisualStyleBackColor = true;
            this.rbtnEditarGrupoCosto.Click += new System.EventHandler(this.Editar_Click);
            // 
            // rbtnAgregarGrupoCosto
            // 
            this.rbtnAgregarGrupoCosto.AutoSize = true;
            this.rbtnAgregarGrupoCosto.Location = new System.Drawing.Point(6, 31);
            this.rbtnAgregarGrupoCosto.Name = "rbtnAgregarGrupoCosto";
            this.rbtnAgregarGrupoCosto.Size = new System.Drawing.Size(164, 21);
            this.rbtnAgregarGrupoCosto.TabIndex = 0;
            this.rbtnAgregarGrupoCosto.TabStop = true;
            this.rbtnAgregarGrupoCosto.Text = "Agregar Grupo Costo";
            this.rbtnAgregarGrupoCosto.UseVisualStyleBackColor = true;
            this.rbtnAgregarGrupoCosto.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // gbListaGrupoCostos
            // 
            this.gbListaGrupoCostos.Controls.Add(this.lvwListaGrupoCostos);
            this.gbListaGrupoCostos.Location = new System.Drawing.Point(364, 17);
            this.gbListaGrupoCostos.Name = "gbListaGrupoCostos";
            this.gbListaGrupoCostos.Size = new System.Drawing.Size(424, 354);
            this.gbListaGrupoCostos.TabIndex = 9;
            this.gbListaGrupoCostos.TabStop = false;
            this.gbListaGrupoCostos.Text = "Lista Grupo Costos";
            // 
            // lvwListaGrupoCostos
            // 
            this.lvwListaGrupoCostos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.GrupoCostos});
            this.lvwListaGrupoCostos.FullRowSelect = true;
            this.lvwListaGrupoCostos.GridLines = true;
            this.lvwListaGrupoCostos.HideSelection = false;
            this.lvwListaGrupoCostos.Location = new System.Drawing.Point(6, 22);
            this.lvwListaGrupoCostos.Name = "lvwListaGrupoCostos";
            this.lvwListaGrupoCostos.Size = new System.Drawing.Size(412, 322);
            this.lvwListaGrupoCostos.TabIndex = 0;
            this.lvwListaGrupoCostos.UseCompatibleStateImageBehavior = false;
            this.lvwListaGrupoCostos.View = System.Windows.Forms.View.Details;
            this.lvwListaGrupoCostos.SelectedIndexChanged += new System.EventHandler(this.lvwListaGrupoCostos_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // GrupoCostos
            // 
            this.GrupoCostos.Text = "Grupo Costos";
            this.GrupoCostos.Width = 164;
            // 
            // frmGrupoCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbControlGrupoCostos);
            this.Controls.Add(this.gbListaGrupoCostos);
            this.Name = "frmGrupoCostos";
            this.Text = "Grupo Costos";
            this.Load += new System.EventHandler(this.frmGrupoCostos_Load);
            this.gbControlGrupoCostos.ResumeLayout(false);
            this.gbControlGrupoCostos.PerformLayout();
            this.gbListaGrupoCostos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gbControlGrupoCostos;
        private System.Windows.Forms.TextBox txtNombreGrupoCosto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbtnEliminarGrupoCosto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnEditarGrupoCosto;
        private System.Windows.Forms.RadioButton rbtnAgregarGrupoCosto;
        private System.Windows.Forms.GroupBox gbListaGrupoCostos;
        private System.Windows.Forms.ListView lvwListaGrupoCostos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader GrupoCostos;
    }
}