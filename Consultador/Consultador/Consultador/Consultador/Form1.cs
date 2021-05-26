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
        String where = "Where";
        String yName = " Nombre = [";
        String yApellido = "] && Apellido [";
        String yPAM = "] && PAM [";
        String yDNI = "] && DNI [";
        string ruta_origen = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\";
        string ruta_destino = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\log\";

        private object Button1_Click(object sender, EventArgs e)
        {
            //-----------------------CONSULTA DATOS DE CLIENTES-----------------------
            select_consulta.Text = String.Empty;
            if (dni.Text == String.Empty) {
                yDNI = String.Empty;
            }
            if (pam.Text == String.Empty)
            {
                yPAM = String.Empty;
            }
            if (!String.IsNullOrEmpty(name.Text)) {
                select_consulta.Text = inicio + where + yName + name.Text + yApellido + lastName.Text + (String.IsNullOrEmpty(dni.Text) String.Empty? String.Empty: yDNI)  dni.Text + (String.IsNullOrEmpty(pam.Text)  Empty: yPAM) + pam.Text + "];";
                TextWriter Escribe = new StreamWriter("Consulta " + dni.Text + name.Text);
                Escribe.WriteLine(select_consulta.Text);
                Escribe.Close();
                ruta_origen = ruta_origen + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                ruta_destino = ruta_destino + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
              
                //File.Move(ruta_origen, ruta_destino);

                if (lastName.Text != "")
                {
                    select_consulta.Text = inicio + where + yName + name.Text + yApellido + lastName.Text + (String.IsNullOrEmpty(dni.Text) ? String.Empty : yDNI) + dni.Text + (String.IsNullOrEmpty(pam.Text) ? String.Empty : yPAM) + pam.Text + "];";
                    Escribe = new StreamWriter("Consulta " + dni.Text + name.Text);
                    Escribe.WriteLine(select_consulta.Text);
                    Escribe.Close();
                    ruta_origen = ruta_origen + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                    ruta_destino = ruta_destino + "consulta cliente " + name.Text + " " + lastName.Text + ".txt";
                    //File.Move(ruta_origen, ruta_destino);
                }
                else
                {
                    MessageBox.Show("EL CAMPO APELLIDO NO PUEDE ESTAR EN BLANCO");
                }

            }
            else
            {
                MessageBox.Show("EL CAMPO NOMBRE NO PUEDE ESTAR EN BLANCO");
            }
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
                //ruta_origen = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\" + "update sucursal " + last_emp.Text + name_emp.Text + ".txt";
                //ruta_destino = @"C:\Users\sosaa\OneDrive\Escritorio\Consultador\Consultador\Consultador\Consultador\Consultador\bin\Debug\log\" + "update sucursal " + last_emp.Text + name_emp.Text + ".txt";

                File.Move(ruta_origen, ruta_destino);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rad_deb.Checked = rad_cred.Checked ? false : true;
        }

        private void rad_deb_CheckedChanged(object sender, EventArgs e)
        {
            rad_cred.Checked = rad_deb.Checked ? false : true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ruta_destino);
        }
    }
}
