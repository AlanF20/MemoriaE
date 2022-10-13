using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MemoriaE
{
    public partial class Form1 : Form
    {
        MemoriaE miAsignacion = new MemoriaE();
        int posi = 41;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            miAsignacion.TamañoDeMemoria = int.Parse(txtTamañoMemoria.Text);
            miAsignacion.TamañoDelSistemaOperativo = int.Parse(txtTamañoSistemaOperativo.Text);
            if (miAsignacion.TamañoDelSistemaOperativo > (miAsignacion.TamañoDeMemoria * .30))
            {
                MessageBox.Show("Tamaño del Sistema Operativo mayor al 30%", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblMemoriaLibre.Text = (miAsignacion.TamañoDeMemoria - miAsignacion.TamañoDelSistemaOperativo).ToString();
            }
            txtTamañoMemoria.Text = "";
            txtTamañoSistemaOperativo.Text = "";
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            Graphics formGraphics = CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(41, 271, miAsignacion.TamañoDeMemoria, 100));
            formGraphics.Dispose();
            SolidBrush myBrush2 = new SolidBrush(Color.Green);
            Graphics formGraphics2 = CreateGraphics();
            formGraphics2.FillRectangle(myBrush2, new Rectangle(41, 271, miAsignacion.TamañoDelSistemaOperativo, 100));
            formGraphics2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            int MemoriaDisponible = int.Parse(lblMemoriaLibre.Text);
            miAsignacion.TamañoParticion = int.Parse(txtTamañoParticion.Text);
                if (miAsignacion.TamañoParticion > MemoriaDisponible)
                {
                    MessageBox.Show("Tamaño de partición mayor a la memoria disponible ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblMemoriaLibre.Text = (MemoriaDisponible - miAsignacion.TamañoParticion).ToString();
                }
                txtTamañoParticion.Text = "";
                SolidBrush myBrush2 = new SolidBrush(Color.FromArgb(ran.Next(250), ran.Next(250), ran.Next(250)));
                Graphics formGraphics2 = CreateGraphics();
                formGraphics2.FillRectangle(myBrush2, new Rectangle((posi + miAsignacion.TamañoDelSistemaOperativo), 271, miAsignacion.TamañoParticion, 100));
                formGraphics2.Dispose();
                posi = posi + miAsignacion.TamañoParticion;
            }
        }
    }
}
