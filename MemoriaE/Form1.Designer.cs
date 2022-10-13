
namespace MemoriaE
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
            this.txtTamañoMemoria = new System.Windows.Forms.TextBox();
            this.txtTamañoSistemaOperativo = new System.Windows.Forms.TextBox();
            this.lblMemoriaLibre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTamañoParticion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTamañoMemoria
            // 
            this.txtTamañoMemoria.Location = new System.Drawing.Point(165, 19);
            this.txtTamañoMemoria.Name = "txtTamañoMemoria";
            this.txtTamañoMemoria.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoMemoria.TabIndex = 2;
            // 
            // txtTamañoSistemaOperativo
            // 
            this.txtTamañoSistemaOperativo.Location = new System.Drawing.Point(165, 50);
            this.txtTamañoSistemaOperativo.Name = "txtTamañoSistemaOperativo";
            this.txtTamañoSistemaOperativo.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoSistemaOperativo.TabIndex = 3;
            // 
            // lblMemoriaLibre
            // 
            this.lblMemoriaLibre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMemoriaLibre.Enabled = false;
            this.lblMemoriaLibre.Location = new System.Drawing.Point(128, 136);
            this.lblMemoriaLibre.Name = "lblMemoriaLibre";
            this.lblMemoriaLibre.Size = new System.Drawing.Size(100, 21);
            this.lblMemoriaLibre.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(305, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 51);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Capturar tamaños";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Capturar particion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTamañoParticion
            // 
            this.txtTamañoParticion.Location = new System.Drawing.Point(128, 104);
            this.txtTamañoParticion.Name = "txtTamañoParticion";
            this.txtTamañoParticion.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoParticion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tamaño de la memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tamaño sistema operativo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tamaño particion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Memoria libre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamañoParticion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMemoriaLibre);
            this.Controls.Add(this.txtTamañoSistemaOperativo);
            this.Controls.Add(this.txtTamañoMemoria);
            this.Name = "Form1";
            this.Text = "Memoria estatica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTamañoMemoria;
        private System.Windows.Forms.TextBox txtTamañoSistemaOperativo;
        private System.Windows.Forms.Label lblMemoriaLibre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTamañoParticion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

