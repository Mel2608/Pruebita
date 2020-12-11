using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BL2;
using TO2;

namespace Prueba
{
    public partial class Form1 : Form
    {

        public static String id_Actual = "";
        public static String accion = "";
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            accion = "Insertar";
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLPersona bl = new BLPersona();
            gridPersonas.DataSource = bl.listaPersonas();
        }

        private void gridPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            accion = "Actualizar";
            String idActualizar = gridPersonas.SelectedCells[0].Value.ToString();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            accion = "Consultar";
            String idConsultar = gridPersonas.SelectedCells[0].Value.ToString();
            id_Actual = idConsultar;

            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
