
namespace mockup1_848
{
    partial class Form2
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pendiente = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox5.Controls.Add(this.pendiente);
            this.groupBox5.Controls.Add(this.Eliminar);
            this.groupBox5.Location = new System.Drawing.Point(1112, 49);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 209);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // pendiente
            // 
            this.pendiente.BackColor = System.Drawing.Color.Yellow;
            this.pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.pendiente.Location = new System.Drawing.Point(6, 116);
            this.pendiente.Name = "pendiente";
            this.pendiente.Size = new System.Drawing.Size(144, 34);
            this.pendiente.TabIndex = 2;
            this.pendiente.Text = "MODIFICAR";
            this.pendiente.UseVisualStyleBackColor = false;
            this.pendiente.Click += new System.EventHandler(this.pendiente_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Eliminar.Location = new System.Drawing.Point(6, 40);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(144, 34);
            this.Eliminar.TabIndex = 0;
            this.Eliminar.Text = "FINALIZADO ";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.finalizado_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1039, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "REGISTRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datos
            // 
            this.datos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datos.Location = new System.Drawing.Point(4, 49);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(1102, 382);
            this.datos.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 499);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button pendiente;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datos;
    }
}