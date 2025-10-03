namespace ProyectoLI
{
    partial class frmEliminarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarPerfil));
            this.btnBorrarCuenta = new System.Windows.Forms.Button();
            this.contra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbMostrarConAct = new System.Windows.Forms.PictureBox();
            this.pbOcultarConAct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConAct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarCuenta
            // 
            this.btnBorrarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarCuenta.BackgroundImage")));
            this.btnBorrarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnBorrarCuenta.Location = new System.Drawing.Point(459, 537);
            this.btnBorrarCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarCuenta.Name = "btnBorrarCuenta";
            this.btnBorrarCuenta.Size = new System.Drawing.Size(166, 48);
            this.btnBorrarCuenta.TabIndex = 16;
            this.btnBorrarCuenta.Text = "Borrar cuenta";
            this.btnBorrarCuenta.UseVisualStyleBackColor = false;
            this.btnBorrarCuenta.Click += new System.EventHandler(this.btnBorrarCuenta_Click);
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.SystemColors.Window;
            this.contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.Color.Black;
            this.contra.Location = new System.Drawing.Point(504, 377);
            this.contra.Margin = new System.Windows.Forms.Padding(2);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(269, 28);
            this.contra.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(321, 376);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(196, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 194);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(350, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = "¿Eliminar perfil?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(504, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(24)))));
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(34, 33);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(11)))));
            this.btnMin.Location = new System.Drawing.Point(965, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 30);
            this.btnMin.TabIndex = 36;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(11)))));
            this.btnCerrar.Location = new System.Drawing.Point(1012, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 29);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbMostrarConAct
            // 
            this.pbMostrarConAct.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrarConAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMostrarConAct.BackgroundImage")));
            this.pbMostrarConAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMostrarConAct.Location = new System.Drawing.Point(782, 362);
            this.pbMostrarConAct.Name = "pbMostrarConAct";
            this.pbMostrarConAct.Size = new System.Drawing.Size(48, 56);
            this.pbMostrarConAct.TabIndex = 39;
            this.pbMostrarConAct.TabStop = false;
            this.pbMostrarConAct.Click += new System.EventHandler(this.pbMostrarConAct_Click);
            // 
            // pbOcultarConAct
            // 
            this.pbOcultarConAct.BackColor = System.Drawing.Color.Transparent;
            this.pbOcultarConAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOcultarConAct.BackgroundImage")));
            this.pbOcultarConAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOcultarConAct.Enabled = false;
            this.pbOcultarConAct.Location = new System.Drawing.Point(782, 362);
            this.pbOcultarConAct.Name = "pbOcultarConAct";
            this.pbOcultarConAct.Size = new System.Drawing.Size(48, 56);
            this.pbOcultarConAct.TabIndex = 38;
            this.pbOcultarConAct.TabStop = false;
            this.pbOcultarConAct.Visible = false;
            this.pbOcultarConAct.Click += new System.EventHandler(this.pbOcultarConAct_Click);
            // 
            // frmEliminarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.pbMostrarConAct);
            this.Controls.Add(this.pbOcultarConAct);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrarCuenta);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarPerfil";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEliminarPerfil_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarConAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrarCuenta;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbMostrarConAct;
        private System.Windows.Forms.PictureBox pbOcultarConAct;
    }
}