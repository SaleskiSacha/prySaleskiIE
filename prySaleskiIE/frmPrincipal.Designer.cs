﻿namespace prySaleskiIE
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDatos,
            this.tsmResultado,
            this.tsmConsulta});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(636, 29);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // tsmDatos
            // 
            this.tsmDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrincipal});
            this.tsmDatos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmDatos.Name = "tsmDatos";
            this.tsmDatos.Size = new System.Drawing.Size(153, 25);
            this.tsmDatos.Text = "Datos Proveedores";
            this.tsmDatos.Click += new System.EventHandler(this.tsmDatos_Click);
            // 
            // tsmPrincipal
            // 
            this.tsmPrincipal.Name = "tsmPrincipal";
            this.tsmPrincipal.Size = new System.Drawing.Size(180, 22);
            // 
            // tsmResultado
            // 
            this.tsmResultado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmResultado.Name = "tsmResultado";
            this.tsmResultado.Size = new System.Drawing.Size(177, 25);
            this.tsmResultado.Text = "Eliminar un Proveedor";
            this.tsmResultado.Click += new System.EventHandler(this.tsmResultado_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(177, 25);
            this.tsmConsulta.Text = "Registro de Proveedor";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySaleskiIE.Properties.Resources.pngtree_insurance_logo_vector_image_80269;
            this.ClientSize = new System.Drawing.Size(636, 527);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmResultado;
    }
}