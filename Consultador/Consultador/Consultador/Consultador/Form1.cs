using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.Devices;

namespace Consultador
{
    public partial class Form1 : Form
    {
        String inicio = "SELECT * FROM ***Nombre de la base de datos*** ";
        String where = "Where ";
        String yName = " Nombre = [";
        String yApellido = "] && Apellido [";
        String yPAM = "] && PAM [";
        String yDNI = "] && DNI [";
        string ruta_origen = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\";
        string ruta_destino = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\log\";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------CONSULTA DATOS DE CLIENTES-----------------------
            if (dni.Text == "") {
                yDNI = "";
            }
            if (pam.Text == "")
            {
                yPAM = "";
            }
            if (name.Text != "") { 
                select_consulta.Text = inicio + where + yName + name.Text + yApellido + lastName.Text + yDNI + dni.Text + yPAM + pam.Text + "];";
                TextWriter Escribe = new StreamWriter("Consulta " + dni.Text + name.Text);
                Escribe.WriteLine(select_consulta.Text);
                Escribe.Close();
                ruta_origen = ruta_origen + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                ruta_destino = ruta_destino + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                yApellido = "] && Apellido [";
                yPAM = "] && PAM [";
                yDNI = "] && DNI [";
                //File.Move(ruta_origen, ruta_destino);

                if (lastName.Text != "")
                {
                    select_consulta.Text = inicio + where + yName + name.Text + yApellido + lastName.Text + yDNI + dni.Text + yPAM + pam.Text + "];";
                    Escribe = new StreamWriter("Consulta " + dni.Text + name.Text);
                    Escribe.WriteLine(select_consulta.Text);
                    Escribe.Close();
                    ruta_origen = ruta_origen + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                    ruta_destino = ruta_destino + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                    yApellido = "] && Apellido [";
                    yPAM = "] && PAM [";
                    yDNI = "] && DNI [";
                    //File.Move(ruta_origen, ruta_destino);
                }
                else
                {
                    select_consulta.Text = "";
                    MessageBox.Show("EL CAMPO APELLIDO NO PUEDE ESTAR EN BLANCO");
                    yApellido = "] && Apellido [";
                    yPAM = "] && PAM [";
                    yDNI = "] && DNI [";
                }

            }
            else
            {
                select_consulta.Text = "";
                MessageBox.Show("EL CAMPO NOMBRE NO PUEDE ESTAR EN BLANCO");
                yApellido = "] && Apellido [";
                yPAM = "] && PAM [";
                yDNI = "] && DNI [";
            }
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Consulta_Click(object sender, EventArgs e)
        {

        }

        private void chance_suc_Click(object sender, EventArgs e)
        {
            
            Computer mycomputer = new Computer();
            
            if ((name_emp.Text == "") || (last_emp.Text == "") || (new_suc.Text == "") || (act_suc.Text == ""))
            {
                text_camb_suc.Text = "NO PUEDEN QUEDAR CAMPOS EN BLANCO PARA REALIZAR ESTA ACCION.";
            }
            else
            {
                text_camb_suc.Text = "UPDATE " + "Nombre de la tabla " + "SET " + "Nombre de la columna de la sucursal nueva = " + "[" + new_suc.Text + "]" + " WHERE Nombre = " + "[" + name_emp.Text + "]" + " && Apellido = " + "[" + last_emp.Text + "]" + " && sucursal = " + act_suc.Text + ";";
                TextWriter Escribe = new StreamWriter("update sucursal " + last_emp.Text + name_emp.Text + ".txt");
                Escribe.WriteLine(text_camb_suc.Text);
                Escribe.Close();
                ruta_origen = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\" + "update sucursal " + last_emp.Text + name_emp.Text + ".txt";
                ruta_destino = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\log\" + "update sucursal " + last_emp.Text + name_emp.Text + ".txt";

                File.Move(ruta_origen, ruta_destino);
            }
        }

        private void name_emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_cred.Checked == true)
            {
                rad_deb.Checked = false;
            }
        }

        private void rad_deb_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_deb.Checked == true)
            {
                rad_cred.Checked = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void select_consulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (name_combo.Text == "Agustin")
            {
                last_ic.Text = "Sosa";
                ci_ic.Text = "4.715.804-2";
            }
            else if (name_combo.Text == "Alejandro")
            {
                last_ic.Text = "Benitez";
                ci_ic.Text = "1.111.111-1";
            }
            else if (name_combo.Text == "Andres")
            {
                last_ic.Text = "Mourigan";
                ci_ic.Text = "2.222.222-2";
            }
            else if (name_combo.Text == "Jose")
            {
                last_ic.Text = "Peralta";
                ci_ic.Text = "3.333.333-3";
            }
            else if (name_combo.Text == "Mauricio")
            {
                last_ic.Text = "Luzardo";
                ci_ic.Text = "4.444.444-4";
            }
            else if (name_combo.Text == "William")
            {
                last_ic.Text = "Ortega";
                ci_ic.Text = "5.555.555-5";
            }
        }

        private void cargar_tar_Click(object sender, EventArgs e)
        { 
            add_tarj.Text = "UPDATE Nombre de la tabla " + "SET " + " Nombre de la columna " + "[" + cant_tar.Text + "]" + " WHERE Nombre =" + name_combo.Text + " && Apellido = " + "["+ last_ic.Text+ "] "+ " && Cedula = "+ ci_ic.Text + ";";
        }

        private void act_suc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void text_camb_suc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ruta_destino);
        }
    }
}
