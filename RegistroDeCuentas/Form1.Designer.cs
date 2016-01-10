namespace RegistroDeCuentas
{
    partial class Form1
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
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CuentaIdlabel = new System.Windows.Forms.Label();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.CuentaIdtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(58, 201);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(140, 201);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 1;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(221, 201);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(221, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CuentaIdlabel
            // 
            this.CuentaIdlabel.AutoSize = true;
            this.CuentaIdlabel.Location = new System.Drawing.Point(58, 35);
            this.CuentaIdlabel.Name = "CuentaIdlabel";
            this.CuentaIdlabel.Size = new System.Drawing.Size(52, 13);
            this.CuentaIdlabel.TabIndex = 4;
            this.CuentaIdlabel.Text = "Cuenta id";
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(58, 80);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(46, 13);
            this.Balancelabel.TabIndex = 5;
            this.Balancelabel.Text = "Balance";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(58, 121);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 6;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(140, 121);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(156, 64);
            this.DescripcionrichTextBox.TabIndex = 7;
            this.DescripcionrichTextBox.Text = "";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(140, 77);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(156, 20);
            this.BalancetextBox.TabIndex = 8;
            // 
            // CuentaIdtextBox
            // 
            this.CuentaIdtextBox.Location = new System.Drawing.Point(140, 32);
            this.CuentaIdtextBox.Name = "CuentaIdtextBox";
            this.CuentaIdtextBox.Size = new System.Drawing.Size(75, 20);
            this.CuentaIdtextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.CuentaIdtextBox);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.Balancelabel);
            this.Controls.Add(this.CuentaIdlabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "Form1";
            this.Text = "Registro de Cuentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label CuentaIdlabel;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.TextBox CuentaIdtextBox;
    }
}

