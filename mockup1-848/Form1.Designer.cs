
namespace mockup1_848
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
            this.cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opcionesElegir = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(334, 112);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(200, 20);
            this.cedula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(232, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula";
            // 
            // opcionesElegir
            // 
            this.opcionesElegir.FormattingEnabled = true;
            this.opcionesElegir.Items.AddRange(new object[] {
            "CELULAR",
            "COMPUTADOR",
            "TABLET",
            "TELEVISOR",
            "PORTATIL"});
            this.opcionesElegir.Location = new System.Drawing.Point(237, 147);
            this.opcionesElegir.Name = "opcionesElegir";
            this.opcionesElegir.Size = new System.Drawing.Size(297, 21);
            this.opcionesElegir.TabIndex = 6;
            this.opcionesElegir.Text = "Tipo de equipo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(334, 60);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(200, 20);
            this.nombre.TabIndex = 7;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(334, 86);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(200, 20);
            this.telefono.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(232, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Costo de reparación";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(357, 384);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(177, 20);
            this.costo.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(237, 283);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(297, 95);
            this.descripcion.TabIndex = 18;
            this.descripcion.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.opcionesElegir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox opcionesElegir;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox descripcion;
    }
}

