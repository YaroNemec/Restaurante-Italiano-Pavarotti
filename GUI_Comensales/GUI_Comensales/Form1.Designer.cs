﻿
namespace GUI_Comensales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Platos = new System.Windows.Forms.PictureBox();
            this.Btn_Postres = new System.Windows.Forms.PictureBox();
            this.Btn_Bebidas = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Platos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Postres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Bebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Platos
            // 
            this.Btn_Platos.BackColor = System.Drawing.Color.Black;
            this.Btn_Platos.BackgroundImage = global::GUI_Comensales.Properties.Resources.Platos;
            this.Btn_Platos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Platos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Btn_Platos.Location = new System.Drawing.Point(448, 92);
            this.Btn_Platos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Platos.Name = "Btn_Platos";
            this.Btn_Platos.Size = new System.Drawing.Size(143, 136);
            this.Btn_Platos.TabIndex = 0;
            this.Btn_Platos.TabStop = false;
            this.Btn_Platos.Click += new System.EventHandler(this.Btn_Platos_Click);
            // 
            // Btn_Postres
            // 
            this.Btn_Postres.BackColor = System.Drawing.Color.Black;
            this.Btn_Postres.Location = new System.Drawing.Point(156, 136);
            this.Btn_Postres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Postres.Name = "Btn_Postres";
            this.Btn_Postres.Size = new System.Drawing.Size(149, 135);
            this.Btn_Postres.TabIndex = 1;
            this.Btn_Postres.TabStop = false;
            this.Btn_Postres.Click += new System.EventHandler(this.Btn_Postres_Click);
            // 
            // Btn_Bebidas
            // 
            this.Btn_Bebidas.BackColor = System.Drawing.Color.Black;
            this.Btn_Bebidas.Location = new System.Drawing.Point(261, 59);
            this.Btn_Bebidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Bebidas.Name = "Btn_Bebidas";
            this.Btn_Bebidas.Size = new System.Drawing.Size(146, 135);
            this.Btn_Bebidas.TabIndex = 2;
            this.Btn_Bebidas.TabStop = false;
            this.Btn_Bebidas.Click += new System.EventHandler(this.Btn_Bebidas_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GUI_Comensales.Properties.Resources.TorreDePitzaJaJa;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 67);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pavarotti";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 67);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(522, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 67);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(61, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.PanelPrincipal.Controls.Add(this.Btn_Platos);
            this.PanelPrincipal.Controls.Add(this.Btn_Postres);
            this.PanelPrincipal.Controls.Add(this.Btn_Bebidas);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 67);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(672, 322);
            this.PanelPrincipal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GUI_Comensales.Properties.Resources.FondoDeMenús;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 389);
            this.ControlBox = false;
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Platos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Postres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Bebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Btn_Platos;
        private System.Windows.Forms.PictureBox Btn_Postres;
        private System.Windows.Forms.PictureBox Btn_Bebidas;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelPrincipal;
    }
}

