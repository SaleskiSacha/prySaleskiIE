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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.mrcBusqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcCambiar = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.mrcDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcBusqueda.SuspendLayout();
            this.mrcCambiar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDgv
            // 
            this.mrcDgv.Controls.Add(this.dgvMostrar);
            this.mrcDgv.Location = new System.Drawing.Point(243, 12);
            this.mrcDgv.Name = "mrcDgv";
            this.mrcDgv.Size = new System.Drawing.Size(769, 573);
            this.mrcDgv.TabIndex = 0;
            this.mrcDgv.TabStop = false;
            this.mrcDgv.Text = "Datos Socios";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(6, 19);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(757, 548);
            this.dgvMostrar.TabIndex = 2;
            // 
            // mrcBusqueda
            // 
            this.mrcBusqueda.Controls.Add(this.label1);
            this.mrcBusqueda.Controls.Add(this.txtID);
            this.mrcBusqueda.Controls.Add(this.btnBuscar);
            this.mrcBusqueda.Location = new System.Drawing.Point(12, 12);
            this.mrcBusqueda.Name = "mrcBusqueda";
            this.mrcBusqueda.Size = new System.Drawing.Size(225, 143);
            this.mrcBusqueda.TabIndex = 1;
            this.mrcBusqueda.TabStop = false;
            this.mrcBusqueda.Text = "Búsqueda Rápida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Numero de ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(156, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(119, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 29);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 556);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mrcCambiar
            // 
            this.mrcCambiar.Controls.Add(this.btnCambiar);
            this.mrcCambiar.Controls.Add(this.lblID);
            this.mrcCambiar.Controls.Add(this.txtID2);
            this.mrcCambiar.Location = new System.Drawing.Point(12, 185);
            this.mrcCambiar.Name = "mrcCambiar";
            this.mrcCambiar.Size = new System.Drawing.Size(225, 143);
            this.mrcCambiar.TabIndex = 3;
            this.mrcCambiar.TabStop = false;
            this.mrcCambiar.Text = "Cambiar estado";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(119, 98);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(100, 29);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Ingrese Numero de ID";
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(156, 46);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(63, 20);
            this.txtID2.TabIndex = 1;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 597);
            this.Controls.Add(this.mrcCambiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcBusqueda);
            this.Controls.Add(this.mrcDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            this.mrcDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.mrcBusqueda.ResumeLayout(false);
            this.mrcBusqueda.PerformLayout();
            this.mrcCambiar.ResumeLayout(false);
            this.mrcCambiar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDgv;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox mrcBusqueda;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox mrcCambiar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label1;
    }
}