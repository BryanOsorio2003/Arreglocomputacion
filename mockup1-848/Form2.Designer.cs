
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
            this.finalizado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.groupBox5.Controls.Add(this.finalizado);
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
            // finalizado
            // 
            this.finalizado.BackColor = System.Drawing.Color.Lime;
            this.finalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.finalizado.Location = new System.Drawing.Point(6, 40);
            this.finalizado.Name = "finalizado";
            this.finalizado.Size = new System.Drawing.Size(144, 34);
            this.finalizado.TabIndex = 0;
            this.finalizado.Text = "FINALIZADO ";
            this.finalizado.UseVisualStyleBackColor = false;
            this.finalizado.Click += new System.EventHandler(this.finalizado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Vladimir Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1039, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "BUSCAR";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Vladimir Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.datos.Location = new System.Drawing.Point(4, 49);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.Size = new System.Drawing.Size(1102, 382);
            this.datos.TabIndex = 14;
            this.datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 499);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button pendiente;
        private System.Windows.Forms.Button finalizado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datos;
    }
}