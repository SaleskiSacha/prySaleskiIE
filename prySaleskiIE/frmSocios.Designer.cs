namespace prySaleskiIE
{
    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            this.mrcDgv = new System.Windows.Forms.GroupBox();
            this.mrcBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIngresarID = new System.Windows.Forms.Label();
            this.mrcDgv.SuspendLayout();
            this.mrcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDgv
            // 
            this.mrcDgv.Controls.Add(this.dgvMostrar);
            this.mrcDgv.Location = new System.Drawing.Point(243, 12);
            this.mrcDgv.Name = "mrcDgv";
            this.mrcDgv.Size = new System.Drawing.Size(636, 573);
            this.mrcDgv.TabIndex = 0;
            this.mrcDgv.TabStop = false;
            this.mrcDgv.Text = "Datos Socios";
            // 
            // mrcBusqueda
            // 
            this.mrcBusqueda.Controls.Add(this.lblIngresarID);
            this.mrcBusqueda.Controls.Add(this.txtID);
            this.mrcBusqueda.Controls.Add(this.btnBuscar);
            this.mrcBusqueda.Location = new System.Drawing.Point(12, 12);
            this.mrcBusqueda.Name = "mrcBusqueda";
            this.mrcBusqueda.Size = new System.Drawing.Size(225, 529);
            this.mrcBusqueda.TabIndex = 1;
            this.mrcBusqueda.TabStop = false;
            this.mrcBusqueda.Text = "Busqueda Rapida";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(0, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 29);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 556);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(6, 19);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(624, 548);
            this.dgvMostrar.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(119, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblIngresarID
            // 
            this.lblIngresarID.AutoSize = true;
            this.lblIngresarID.Location = new System.Drawing.Point(6, 45);
            this.lblIngresarID.Name = "lblIngresarID";
            this.lblIngresarID.Size = new System.Drawing.Size(108, 13);
            this.lblIngresarID.TabIndex = 2;
            this.lblIngresarID.Text = "Ingrese Identificacion";
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 597);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcBusqueda);
            this.Controls.Add(this.mrcDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            this.mrcDgv.ResumeLayout(false);
            this.mrcBusqueda.ResumeLayout(false);
            this.mrcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDgv;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox mrcBusqueda;
        private System.Windows.Forms.Label lblIngresarID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
    }
}