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

namespace Consultador
{
    public partial class Form1 : Form
    {
        String inicio = "SELECTO * FROM ***Nombre de la base de datos*** WHERE ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select_consulta.Text = inicio + name.Text + " " +lastName.Text + " " + dni.Text + " " + pam.Text + ";";
            TextWriter Escribe = new StreamWriter("Consulta" + dni.Text + name.Text);
            Escribe.WriteLine(select_consulta.Text);
            Escribe.Close();

        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
