namespace ProyectoLI
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBorrarHistorial = new System.Windows.Forms.Button();
            this.dataGVBuscarHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBuscarHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarHistorial
            // 
            this.btnBorrarHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarHistorial.BackgroundImage")));
            this.btnBorrarHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnBorrarHistorial.Location = new System.Drawing.Point(494, 546);
            this.btnBorrarHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarHistorial.Name = "btnBorrarHistorial";
            this.btnBorrarHistorial.Size = new System.Drawing.Size(154, 53);
            this.btnBorrarHistorial.TabIndex = 8;
            this.btnBorrarHistorial.Text = "Borrar historial";
            this.btnBorrarHistorial.UseVisualStyleBackColor = false;
            this.btnBorrarHistorial.Click += new System.EventHandler(this.btnBorrarHistorial_Click);
            // 
            // dataGVBuscarHistorial
            // 
            this.dataGVBuscarHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGVBuscarHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVBuscarHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVBuscarHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(11)))));
            this.dataGVBuscarHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGVBuscarHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVBuscarHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVBuscarHistorial.ColumnHeadersHeight = 30;
            this.dataGVBuscarHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVBuscarHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVBuscarHistorial.EnableHeadersVisualStyles = false;
            this.dataGVBuscarHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(11)))));
            this.dataGVBuscarHistorial.Location = new System.Drawing.Point(183, 58);
            this.dataGVBuscarHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.dataGVBuscarHistorial.Name = "dataGVBuscarHistorial";
            this.dataGVBuscarHistorial.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVBuscarHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVBuscarHistorial.RowHeadersVisible = false;
            this.dataGVBuscarHistorial.RowTemplate.Height = 24;
            this.dataGVBuscarHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVBuscarHistorial.Size = new System.Drawing.Size(761, 467);
            this.dataGVBuscarHistorial.TabIndex = 6;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.Controls.Add(this.btnBorrarHistorial);
            this.Controls.Add(this.dataGVBuscarHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBuscarHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarHistorial;
        private System.Windows.Forms.DataGridView dataGVBuscarHistorial;
    }
}