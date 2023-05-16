using OrientacaoAObjetos.Dia2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjeto.WindowsForms1
{
    public partial class Tela01 : Form
    {
        public Tela01()
        {
            InitializeComponent();
        }

        private void txtVazio_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado();
            MessageBox.Show(segurado.Teste());
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Samuel");
            MessageBox.Show(segurado.Nome);      
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(01);
            MessageBox.Show(segurado.Id.ToString()); 
        }
        private void txtNomeCpf_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("samuel", "123.456.789-10");
            MessageBox.Show(segurado.Nome);
            MessageBox.Show(segurado.CPF.ToString());
        }
    }
}
