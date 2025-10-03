namespace ProyectoLI
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnModificarContra = new System.Windows.Forms.Button();
            this.btnCambioContra = new System.Windows.Forms.Button();
            this.pbOcultarConAct = new System.Windows.Forms.PictureBox();
            this.pbOcultarConNue = new System.Windows.Forms.PictureBox();
            this.pbMostrarConAct = new System.Windows.Forms.PictureBox();
            this.pbMostrarConNue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConNue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConNue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(133)))));
            this.lblPerfil.Location = new System.Drawing.Point(388, 40);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(265, 37);
            this.lblPerfil.TabIndex = 14;
            this.lblPerfil.Text = "Perfil de usuario";
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarDatos.BackgroundImage")));
            this.btnModificarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarDatos.FlatAppearance.BorderSize = 0;
            this.btnModificarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatos.ForeColor = System.Drawing.Color.White;
            this.btnModificarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDatos.Image")));
            this.btnModificarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDatos.Location = new System.Drawing.Point(330, 469);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(270, 45);
            this.btnModificarDatos.TabIndex = 10;
            this.btnModificarDatos.Text = "Modificar datos";
            this.btnModificarDatos.UseVisualStyleBackColor = false;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.Location = new System.Drawing.Point(475, 380);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.MaxLength = 20;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(275, 24);
            this.txtTipo.TabIndex = 9;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(475, 321);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaxLength = 20;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(275, 24);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(235, 375);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(212, 29);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Contraseña nueva:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(235, 316);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(164, 29);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id del usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(475, 257);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(275, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(475, 194);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(275, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(235, 252);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(219, 29);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo del usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(235, 189);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(773, 150);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(246, 53);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Realizar cambios";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(629, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 116);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "15";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUsuario.Location = new System.Drawing.Point(475, 139);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.MaxLength = 30;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(275, 24);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(235, 134);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(226, 29);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // btnModificarContra
            // 
            this.btnModificarContra.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarContra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarContra.BackgroundImage")));
            this.btnModificarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarContra.FlatAppearance.BorderSize = 0;
            this.btnModificarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModificarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarContra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarContra.ForeColor = System.Drawing.Color.White;
            this.btnModificarContra.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarContra.Image")));
            this.btnModificarContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarContra.Location = new System.Drawing.Point(330, 543);
            this.btnModificarContra.Name = "btnModificarContra";
            this.btnModificarContra.Size = new System.Drawing.Size(270, 42);
            this.btnModificarContra.TabIndex = 11;
            this.btnModificarContra.Text = "Modificar contraseña";
            this.btnModificarContra.UseVisualStyleBackColor = false;
            this.btnModificarContra.Click += new System.EventHandler(this.btnModificarContra_Click);
            // 
            // btnCambioContra
            // 
            this.btnCambioContra.BackColor = System.Drawing.Color.Transparent;
            this.btnCambioContra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambioContra.BackgroundImage")));
            this.btnCambioContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambioContra.FlatAppearance.BorderSize = 0;
            this.btnCambioContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCambioContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioContra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioContra.ForeColor = System.Drawing.Color.White;
            this.btnCambioContra.Image = ((System.Drawing.Image)(resources.GetObject("btnCambioContra.Image")));
            this.btnCambioContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambioContra.Location = new System.Drawing.Point(773, 231);
            this.btnCambioContra.Name = "btnCambioContra";
            this.btnCambioContra.Size = new System.Drawing.Size(246, 53);
            this.btnCambioContra.TabIndex = 13;
            this.btnCambioContra.Text = "Cambiar contraseña";
            this.btnCambioContra.UseVisualStyleBackColor = false;
            this.btnCambioContra.Visible = false;
            this.btnCambioContra.Click += new System.EventHandler(this.btnCambioContra_Click);
            // 
            // pbOcultarConAct
            // 
            this.pbOcultarConAct.BackColor = System.Drawing.Color.Transparent;
            this.pbOcultarConAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOcultarConAct.BackgroundImage")));
            this.pbOcultarConAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOcultarConAct.Enabled = false;
            this.pbOcultarConAct.Location = new System.Drawing.Point(755, 306);
            this.pbOcultarConAct.Name = "pbOcultarConAct";
            this.pbOcultarConAct.Size = new System.Drawing.Size(48, 56);
            this.pbOcultarConAct.TabIndex = 23;
            this.pbOcultarConAct.TabStop = false;
            this.pbOcultarConAct.Visible = false;
            this.pbOcultarConAct.Click += new System.EventHandler(this.pbOcultarConAct_Click);
            // 
            // pbOcultarConNue
            // 
            this.pbOcultarConNue.BackColor = System.Drawing.Color.Transparent;
            this.pbOcultarConNue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOcultarConNue.BackgroundImage")));
            this.pbOcultarConNue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOcultarConNue.Enabled = false;
            this.pbOcultarConNue.Location = new System.Drawing.Point(755, 368);
            this.pbOcultarConNue.Name = "pbOcultarConNue";
            this.pbOcultarConNue.Size = new System.Drawing.Size(48, 51);
            this.pbOcultarConNue.TabIndex = 24;
            this.pbOcultarConNue.TabStop = false;
            this.pbOcultarConNue.Visible = false;
            this.pbOcultarConNue.Click += new System.EventHandler(this.pbOcultarConNue_Click);
            // 
            // pbMostrarConAct
            // 
            this.pbMostrarConAct.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrarConAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMostrarConAct.BackgroundImage")));
            this.pbMostrarConAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMostrarConAct.Enabled = false;
            this.pbMostrarConAct.Location = new System.Drawing.Point(755, 306);
            this.pbMostrarConAct.Name = "pbMostrarConAct";
            this.pbMostrarConAct.Size = new System.Drawing.Size(48, 56);
            this.pbMostrarConAct.TabIndex = 25;
            this.pbMostrarConAct.TabStop = false;
            this.pbMostrarConAct.Visible = false;
            this.pbMostrarConAct.Click += new System.EventHandler(this.pbMostrarConAct_Click);
            // 
            // pbMostrarConNue
            // 
            this.pbMostrarConNue.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrarConNue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMostrarConNue.BackgroundImage")));
            this.pbMostrarConNue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMostrarConNue.Enabled = false;
            this.pbMostrarConNue.Location = new System.Drawing.Point(755, 368);
            this.pbMostrarConNue.Name = "pbMostrarConNue";
            this.pbMostrarConNue.Size = new System.Drawing.Size(48, 51);
            this.pbMostrarConNue.TabIndex = 26;
            this.pbMostrarConNue.TabStop = false;
            this.pbMostrarConNue.Visible = false;
            this.pbMostrarConNue.Click += new System.EventHandler(this.pbMostrarConNue_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.pbMostrarConNue);
            this.Controls.Add(this.pbMostrarConAct);
            this.Controls.Add(this.pbOcultarConNue);
            this.Controls.Add(this.pbOcultarConAct);
            this.Controls.Add(this.btnCambioContra);
            this.Controls.Add(this.btnModificarContra);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificarDatos);
            this.Controls.Add(this.lblPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConNue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConNue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnModificarContra;
        private System.Windows.Forms.Button btnCambioContra;
        private System.Windows.Forms.PictureBox pbOcultarConAct;
        private System.Windows.Forms.PictureBox pbOcultarConNue;
        private System.Windows.Forms.PictureBox pbMostrarConAct;
        private System.Windows.Forms.PictureBox pbMostrarConNue;
    }
}