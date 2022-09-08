
namespace Cliente
{
    partial class frmInicio
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
            this.lblNombreCompania = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnOrganizaciones = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.btnTitulo = new System.Windows.Forms.Button();
            this.btnCategoriaCorreo = new System.Windows.Forms.Button();
            this.btnProvincias = new System.Windows.Forms.Button();
            this.btnGrupoCostos = new System.Windows.Forms.Button();
            this.btnDeclarar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCompania
            // 
            this.lblNombreCompania.AutoSize = true;
            this.lblNombreCompania.Font = new System.Drawing.Font("SansSerif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblNombreCompania.Location = new System.Drawing.Point(291, 21);
            this.lblNombreCompania.Name = "lblNombreCompania";
            this.lblNombreCompania.Size = new System.Drawing.Size(204, 28);
            this.lblNombreCompania.TabIndex = 0;
            this.lblNombreCompania.Text = "Facturadeuna.co";
            this.lblNombreCompania.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnDocumentos);
            this.panel1.Controls.Add(this.btnCargos);
            this.panel1.Controls.Add(this.btnOrganizaciones);
            this.panel1.Controls.Add(this.btnContactos);
            this.panel1.Controls.Add(this.btnTitulo);
            this.panel1.Controls.Add(this.btnCategoriaCorreo);
            this.panel1.Controls.Add(this.btnProvincias);
            this.panel1.Controls.Add(this.btnGrupoCostos);
            this.panel1.Controls.Add(this.btnDeclarar);
            this.panel1.Location = new System.Drawing.Point(30, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 344);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(319, 262);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 38);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Location = new System.Drawing.Point(31, 86);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(134, 46);
            this.btnDocumentos.TabIndex = 8;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = true;
            // 
            // btnCargos
            // 
            this.btnCargos.Location = new System.Drawing.Point(306, 16);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(134, 46);
            this.btnCargos.TabIndex = 7;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnOrganizaciones
            // 
            this.btnOrganizaciones.Location = new System.Drawing.Point(575, 155);
            this.btnOrganizaciones.Name = "btnOrganizaciones";
            this.btnOrganizaciones.Size = new System.Drawing.Size(134, 46);
            this.btnOrganizaciones.TabIndex = 6;
            this.btnOrganizaciones.Text = "Organizaciones";
            this.btnOrganizaciones.UseVisualStyleBackColor = true;
            this.btnOrganizaciones.Click += new System.EventHandler(this.btnOrganizaciones_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Location = new System.Drawing.Point(575, 86);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(134, 46);
            this.btnContactos.TabIndex = 5;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnTitulo
            // 
            this.btnTitulo.Location = new System.Drawing.Point(575, 16);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(134, 46);
            this.btnTitulo.TabIndex = 4;
            this.btnTitulo.Text = "Titulo";
            this.btnTitulo.UseVisualStyleBackColor = true;
            this.btnTitulo.Click += new System.EventHandler(this.btnTitulo_Click);
            // 
            // btnCategoriaCorreo
            // 
            this.btnCategoriaCorreo.Location = new System.Drawing.Point(306, 86);
            this.btnCategoriaCorreo.Name = "btnCategoriaCorreo";
            this.btnCategoriaCorreo.Size = new System.Drawing.Size(134, 46);
            this.btnCategoriaCorreo.TabIndex = 3;
            this.btnCategoriaCorreo.Text = "Categoria de Correo";
            this.btnCategoriaCorreo.UseVisualStyleBackColor = true;
            this.btnCategoriaCorreo.Click += new System.EventHandler(this.btnCategoriaCorreo_Click);
            // 
            // btnProvincias
            // 
            this.btnProvincias.Location = new System.Drawing.Point(31, 155);
            this.btnProvincias.Name = "btnProvincias";
            this.btnProvincias.Size = new System.Drawing.Size(134, 46);
            this.btnProvincias.TabIndex = 2;
            this.btnProvincias.Text = "Provincias";
            this.btnProvincias.UseVisualStyleBackColor = true;
            this.btnProvincias.Click += new System.EventHandler(this.btnProvincias_Click);
            // 
            // btnGrupoCostos
            // 
            this.btnGrupoCostos.Location = new System.Drawing.Point(306, 155);
            this.btnGrupoCostos.Name = "btnGrupoCostos";
            this.btnGrupoCostos.Size = new System.Drawing.Size(134, 46);
            this.btnGrupoCostos.TabIndex = 1;
            this.btnGrupoCostos.Text = "Grupo Costos";
            this.btnGrupoCostos.UseVisualStyleBackColor = true;
            this.btnGrupoCostos.Click += new System.EventHandler(this.btnGrupoCostos_Click);
            // 
            // btnDeclarar
            // 
            this.btnDeclarar.Location = new System.Drawing.Point(31, 16);
            this.btnDeclarar.Name = "btnDeclarar";
            this.btnDeclarar.Size = new System.Drawing.Size(134, 46);
            this.btnDeclarar.TabIndex = 0;
            this.btnDeclarar.Text = "Declarar";
            this.btnDeclarar.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreCompania);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCompania;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnOrganizaciones;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.Button btnCategoriaCorreo;
        private System.Windows.Forms.Button btnProvincias;
        private System.Windows.Forms.Button btnGrupoCostos;
        private System.Windows.Forms.Button btnDeclarar;
    }
}

