namespace Consultador
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
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.select_consulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(56, 106);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 26);
            this.name.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(56, 188);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(148, 26);
            this.lastName.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(56, 262);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(148, 26);
            this.dni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento";
            // 
            // pam
            // 
            this.pam.Location = new System.Drawing.Point(56, 334);
            this.pam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pam.Name = "pam";
            this.pam.Size = new System.Drawing.Size(148, 26);
            this.pam.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pam";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(510, 334);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(142, 46);
            this.generate.TabIndex = 14;
            this.generate.Text = "Generar txt";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Copiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // select_consulta
            // 
            this.select_consulta.Location = new System.Drawing.Point(56, 411);
            this.select_consulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.select_consulta.Multiline = true;
            this.select_consulta.Name = "select_consulta";
            this.select_consulta.Size = new System.Drawing.Size(1106, 219);
            this.select_consulta.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Informacion a traer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.select_consulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Consultas Base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox select_consulta;
        private System.Windows.Forms.Label label5;
    }
}

