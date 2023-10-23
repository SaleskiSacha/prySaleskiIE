namespace prySaleskiIE
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcEliminar = new System.Windows.Forms.GroupBox();
            this.btnArchivoEliminar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.mrcEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 233);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 24);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mrcEliminar
            // 
            this.mrcEliminar.Controls.Add(this.lblRuta);
            this.mrcEliminar.Controls.Add(this.btnEliminar);
            this.mrcEliminar.Controls.Add(this.btnArchivoEliminar);
            this.mrcEliminar.Location = new System.Drawing.Point(12, 0);
            this.mrcEliminar.Name = "mrcEliminar";
            this.mrcEliminar.Size = new System.Drawing.Size(447, 216);
            this.mrcEliminar.TabIndex = 2;
            this.mrcEliminar.TabStop = false;
            this.mrcEliminar.Text = "ELIMINAR";
            // 
            // btnArchivoEliminar
            // 
            this.btnArchivoEliminar.Location = new System.Drawing.Point(32, 34);
            this.btnArchivoEliminar.Name = "btnArchivoEliminar";
            this.btnArchivoEliminar.Size = new System.Drawing.Size(135, 34);
            this.btnArchivoEliminar.TabIndex = 3;
            this.btnArchivoEliminar.Text = "Seleccionar Archivo";
            this.btnArchivoEliminar.UseVisualStyleBackColor = true;
            this.btnArchivoEliminar.Click += new System.EventHandler(this.btnArchivoEliminar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(32, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(29, 83);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(112, 13);
            this.lblRuta.TabIndex = 5;
            this.lblRuta.Text = "Archivo seleccionado:";
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 275);
            this.Controls.Add(this.mrcEliminar);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminar";
            this.Text = "Eliminar un Proveedor";
            this.mrcEliminar.ResumeLayout(false);
            this.mrcEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox mrcEliminar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnArchivoEliminar;
    }
}