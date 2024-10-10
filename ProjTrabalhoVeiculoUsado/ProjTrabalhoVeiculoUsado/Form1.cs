using ProjTrabalhoVeiculoUsado.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjTrabalhoVeiculoUsado
{
    public partial class Form1 : Form
    {
        VeiculoUsado m_veiculoUsado = new VeiculoUsado();

        CaminhaoUsado m_CaminhaoUsado = new CaminhaoUsado();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVeiculoUsado_Click(object sender, EventArgs e)
        {
            m_veiculoUsado.Modelo = "Sedan";
            m_veiculoUsado.AnoFab = 2023;
            m_veiculoUsado.Valor = 97000.00f;
            m_veiculoUsado.Imprimir();



        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {

            m_CaminhaoUsado.Modelo = "truck";
            m_CaminhaoUsado.AnoFab = 1997;
            m_CaminhaoUsado.Valor = 697000.00f;
            m_CaminhaoUsado.Capacidade = 2700;
            m_CaminhaoUsado.NroEixos = 6;
            m_CaminhaoUsado.Imprimir();


        }

        private void btnCalcularDepreciação_Click(object sender, EventArgs e)
        {
            m_veiculoUsado.calcularDepreciacao(500.76f, 0.10f);
        }

        private void btnCalcularDepreciaçãoCaminhão_Click(object sender, EventArgs e)
        {
            m_CaminhaoUsado.calcularDepreciacao(1500.76f, 0.30f);
        }
    }
}
