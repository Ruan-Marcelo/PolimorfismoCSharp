using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTrabalhoVeiculoUsado.Classes
{
    internal class CaminhaoUsado : VeiculoUsado
    {
        //Attributos 
        private int capacidade;
        private int nroEixos;

        //Construtores
        public CaminhaoUsado()
        {

        }
        public CaminhaoUsado(int capacidade, int nroEixos, string modelo, int anoFab, float valor)
        {
            this.capacidade = capacidade;
            this.nroEixos = nroEixos;

            //Atributos herdado do Veiculos Usados
            this.modelo = modelo;
            this.anoFab = anoFab;
            this.valor = valor;
        }

        //Propriedades
        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }
        public int NroEixos
        {
            get { return nroEixos; }
            set { nroEixos = value; }
        }

        //Métodos
        public override float calcularDepreciacao(float vlr1, float porcetagem)
        {
            //float resultado;


            if (valor < 0)
            {
                Console.WriteLine($"Seu carro deu PT");
            }
            else
            {
                valor = (valor - (valor * porcetagem)) - vlr1;

                Console.WriteLine($"Valor  do caminhão após a Depreciação: {valor}");

            }
            return valor;

        }
        public virtual void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine($"Capaciade: {capacidade}Kg");
            Console.WriteLine($"Número de Eixos: {nroEixos}");

        }
    }
}
