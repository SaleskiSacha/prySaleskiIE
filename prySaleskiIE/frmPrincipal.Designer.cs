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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.SOCIOS = new System.Windows.Forms.ToolStripMenuItem();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.barraDeEstado = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mnsPrincipal.SuspendLayout();
            this.barraDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDatos,
            this.tsmEditar,
            this.toolStripMenuItem1,
            this.tsmResultado,
            this.SOCIOS});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(638, 29);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            this.mnsPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsPrincipal_ItemClicked);
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
            this.tsmPrincipal.Size = new System.Drawing.Size(70, 22);
            // 
            // tsmEditar
            // 
            this.tsmEditar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmEditar.Name = "tsmEditar";
            this.tsmEditar.Size = new System.Drawing.Size(55, 25);
            this.tsmEditar.Text = "ABM";
            this.tsmEditar.Click += new System.EventHandler(this.tsmEditar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 25);
            this.toolStripMenuItem1.Text = "Registro de Proveedor";
            // 
            // tsmResultado
            // 
            this.tsmResultado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsmResultado.Name = "tsmResultado";
            this.tsmResultado.Size = new System.Drawing.Size(177, 25);
            this.tsmResultado.Text = "Eliminar un Proveedor";
            this.tsmResultado.Click += new System.EventHandler(this.tsmResultado_Click);
            // 
            // SOCIOS
            // 
            this.SOCIOS.Name = "SOCIOS";
            this.SOCIOS.Size = new System.Drawing.Size(60, 25);
            this.SOCIOS.Text = "SOCIOS";
            this.SOCIOS.Click += new System.EventHandler(this.SOCIOS_Click_1);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // barraDeEstado
            // 
            this.barraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUsuarioTS});
            this.barraDeEstado.Location = new System.Drawing.Point(0, 505);
            this.barraDeEstado.Name = "barraDeEstado";
            this.barraDeEstado.Size = new System.Drawing.Size(638, 22);
            this.barraDeEstado.TabIndex = 14;
            this.barraDeEstado.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 17);
            this.lblStatus.Text = "BD: ";
            // 
            // lblUsuarioTS
            // 
            this.lblUsuarioTS.Name = "lblUsuarioTS";
            this.lblUsuarioTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuarioTS.Size = new System.Drawing.Size(0, 17);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(24, 109);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 15;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 138);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 16;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySaleskiIE.Properties.Resources.pngtree_insurance_logo_vector_image_80269;
            this.ClientSize = new System.Drawing.Size(638, 527);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.barraDeEstado);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.barraDeEstado.ResumeLayout(false);
            this.barraDeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmResultado;
        private System.Windows.Forms.ToolStripMenuItem tsmEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SOCIOS;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.StatusStrip barraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioTS;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}