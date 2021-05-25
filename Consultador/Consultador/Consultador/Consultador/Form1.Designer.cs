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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.pam = new System.Windows.Forms.TextBox();
            this.select_consulta = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_camb_suc = new System.Windows.Forms.TextBox();
            this.chance_suc = new System.Windows.Forms.Button();
            this.new_suc = new System.Windows.Forms.TextBox();
            this.act_suc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.last_emp = new System.Windows.Forms.TextBox();
            this.name_emp = new System.Windows.Forms.TextBox();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.cargar_tar = new System.Windows.Forms.Button();
            this.add_tarj = new System.Windows.Forms.TextBox();
            this.rad_cred = new System.Windows.Forms.RadioButton();
            this.rad_deb = new System.Windows.Forms.RadioButton();
            this.cant_tar = new System.Windows.Forms.TextBox();
            this.ci_ic = new System.Windows.Forms.TextBox();
            this.last_ic = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pam);
            this.tabPage2.Controls.Add(this.select_consulta);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.lastName);
            this.tabPage2.Controls.Add(this.dni);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.generate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(768, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Consulta";
            // 
            // pam
            // 
            this.pam.Location = new System.Drawing.Point(16, 179);
            this.pam.Name = "pam";
            this.pam.Size = new System.Drawing.Size(222, 20);
            this.pam.TabIndex = 12;
            // 
            // select_consulta
            // 
            this.select_consulta.Location = new System.Drawing.Point(16, 221);
            this.select_consulta.Multiline = true;
            this.select_consulta.Name = "select_consulta";
            this.select_consulta.Size = new System.Drawing.Size(732, 71);
            this.select_consulta.TabIndex = 16;
            this.select_consulta.TextChanged += new System.EventHandler(this.select_consulta_TextChanged);
            // 
            // name
            // 
            this.name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name.Location = new System.Drawing.Point(16, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastName.Location = new System.Drawing.Point(16, 78);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 1;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(16, 126);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Abrir capeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(370, 173);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(95, 30);
            this.generate.TabIndex = 14;
            this.generate.Text = "Generar txt";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Consulta);
            this.tabPage1.Controls.Add(this.text_camb_suc);
            this.tabPage1.Controls.Add(this.chance_suc);
            this.tabPage1.Controls.Add(this.new_suc);
            this.tabPage1.Controls.Add(this.act_suc);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.last_emp);
            this.tabPage1.Controls.Add(this.name_emp);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(768, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleados banco";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // text_camb_suc
            // 
            this.text_camb_suc.Location = new System.Drawing.Point(16, 221);
            this.text_camb_suc.Multiline = true;
            this.text_camb_suc.Name = "text_camb_suc";
            this.text_camb_suc.Size = new System.Drawing.Size(732, 71);
            this.text_camb_suc.TabIndex = 9;
            this.text_camb_suc.TextChanged += new System.EventHandler(this.text_camb_suc_TextChanged);
            // 
            // chance_suc
            // 
            this.chance_suc.Location = new System.Drawing.Point(382, 30);
            this.chance_suc.Name = "chance_suc";
            this.chance_suc.Size = new System.Drawing.Size(75, 23);
            this.chance_suc.TabIndex = 8;
            this.chance_suc.Text = "Cambiar";
            this.chance_suc.UseVisualStyleBackColor = true;
            this.chance_suc.Click += new System.EventHandler(this.chance_suc_Click);
            // 
            // new_suc
            // 
            this.new_suc.Location = new System.Drawing.Point(203, 101);
            this.new_suc.Name = "new_suc";
            this.new_suc.Size = new System.Drawing.Size(100, 20);
            this.new_suc.TabIndex = 7;
            // 
            // act_suc
            // 
            this.act_suc.Location = new System.Drawing.Point(203, 33);
            this.act_suc.Name = "act_suc";
            this.act_suc.Size = new System.Drawing.Size(100, 20);
            this.act_suc.TabIndex = 6;
            this.act_suc.TextChanged += new System.EventHandler(this.act_suc_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sucursal Nueva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sucursal Actual ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Apellido Empleado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Empleado";
            // 
            // last_emp
            // 
            this.last_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.last_emp.Location = new System.Drawing.Point(15, 101);
            this.last_emp.Name = "last_emp";
            this.last_emp.Size = new System.Drawing.Size(100, 20);
            this.last_emp.TabIndex = 1;
            // 
            // name_emp
            // 
            this.name_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name_emp.Location = new System.Drawing.Point(15, 33);
            this.name_emp.Name = "name_emp";
            this.name_emp.Size = new System.Drawing.Size(100, 20);
            this.name_emp.TabIndex = 0;
            this.name_emp.TextChanged += new System.EventHandler(this.name_emp_TextChanged);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.ItemSize = new System.Drawing.Size(140, 30);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Drawing.Point(16, 3);
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(776, 345);
            this.tab1.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.name_combo);
            this.tabPage3.Controls.Add(this.cargar_tar);
            this.tabPage3.Controls.Add(this.add_tarj);
            this.tabPage3.Controls.Add(this.rad_cred);
            this.tabPage3.Controls.Add(this.rad_deb);
            this.tabPage3.Controls.Add(this.cant_tar);
            this.tabPage3.Controls.Add(this.ci_ic);
            this.tabPage3.Controls.Add(this.last_ic);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Agregar ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // name_combo
            // 
            this.name_combo.DisplayMember = "(ninguno)";
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Items.AddRange(new object[] {
            "Agustin",
            "Alejandro",
            "Andres",
            "Jose",
            "Mauricio",
            "William"});
            this.name_combo.Location = new System.Drawing.Point(15, 44);
            this.name_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(100, 21);
            this.name_combo.TabIndex = 12;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.name_combo_SelectedIndexChanged);
            // 
            // cargar_tar
            // 
            this.cargar_tar.Location = new System.Drawing.Point(603, 65);
            this.cargar_tar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cargar_tar.Name = "cargar_tar";
            this.cargar_tar.Size = new System.Drawing.Size(95, 30);
            this.cargar_tar.TabIndex = 11;
            this.cargar_tar.Text = "Cargar";
            this.cargar_tar.UseVisualStyleBackColor = true;
            this.cargar_tar.Click += new System.EventHandler(this.cargar_tar_Click);
            // 
            // add_tarj
            // 
            this.add_tarj.Location = new System.Drawing.Point(16, 221);
            this.add_tarj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_tarj.Multiline = true;
            this.add_tarj.Name = "add_tarj";
            this.add_tarj.Size = new System.Drawing.Size(732, 71);
            this.add_tarj.TabIndex = 10;
            // 
            // rad_cred
            // 
            this.rad_cred.AutoSize = true;
            this.rad_cred.Location = new System.Drawing.Point(485, 104);
            this.rad_cred.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rad_cred.Name = "rad_cred";
            this.rad_cred.Size = new System.Drawing.Size(58, 17);
            this.rad_cred.TabIndex = 9;
            this.rad_cred.Text = "Credito";
            this.rad_cred.UseVisualStyleBackColor = true;
            this.rad_cred.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rad_deb
            // 
            this.rad_deb.AutoSize = true;
            this.rad_deb.Checked = true;
            this.rad_deb.Location = new System.Drawing.Point(485, 46);
            this.rad_deb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rad_deb.Name = "rad_deb";
            this.rad_deb.Size = new System.Drawing.Size(56, 17);
            this.rad_deb.TabIndex = 8;
            this.rad_deb.TabStop = true;
            this.rad_deb.Text = "Debito";
            this.rad_deb.UseVisualStyleBackColor = true;
            this.rad_deb.CheckedChanged += new System.EventHandler(this.rad_deb_CheckedChanged);
            // 
            // cant_tar
            // 
            this.cant_tar.AutoCompleteCustomSource.AddRange(new string[] {
            "10"});
            this.cant_tar.Location = new System.Drawing.Point(107, 103);
            this.cant_tar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cant_tar.Name = "cant_tar";
            this.cant_tar.Size = new System.Drawing.Size(100, 20);
            this.cant_tar.TabIndex = 7;
            this.cant_tar.Text = "10";
            this.cant_tar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ci_ic
            // 
            this.ci_ic.Location = new System.Drawing.Point(15, 103);
            this.ci_ic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ci_ic.Name = "ci_ic";
            this.ci_ic.Size = new System.Drawing.Size(100, 20);
            this.ci_ic.TabIndex = 6;
            this.ci_ic.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // last_ic
            // 
            this.last_ic.Location = new System.Drawing.Point(107, 44);
            this.last_ic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.last_ic.Name = "last_ic";
            this.last_ic.Size = new System.Drawing.Size(100, 20);
            this.last_ic.TabIndex = 5;
            this.last_ic.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cantidad";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cedula";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Apellido";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Consulta
            // 
            this.Consulta.AutoSize = true;
            this.Consulta.Location = new System.Drawing.Point(16, 202);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(51, 13);
            this.Consulta.TabIndex = 10;
            this.Consulta.Text = "Consulta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Consulta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Consultas Base de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pam;
        private System.Windows.Forms.TextBox select_consulta;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox text_camb_suc;
        private System.Windows.Forms.Button chance_suc;
        private System.Windows.Forms.TextBox new_suc;
        private System.Windows.Forms.TextBox act_suc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox last_emp;
        private System.Windows.Forms.TextBox name_emp;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.RadioButton rad_cred;
        private System.Windows.Forms.RadioButton rad_deb;
        private System.Windows.Forms.TextBox cant_tar;
        private System.Windows.Forms.TextBox ci_ic;
        private System.Windows.Forms.TextBox last_ic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_tarj;
        private System.Windows.Forms.Button cargar_tar;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.Label Consulta;
        private System.Windows.Forms.Label label14;
    }
}

