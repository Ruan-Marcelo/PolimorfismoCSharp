using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTrabalhoVeiculoUsado.Classes
{
    internal class VeiculoUsado
    {
        //Atributos 
        protected string modelo;
        protected int anoFab;
        protected float valor;

        //Construtuores
        public VeiculoUsado()
        {

        }
        public VeiculoUsado(string modelo, int anoFab, float valor)
        {
            this.modelo = modelo;
            this.anoFab = anoFab;
            this.valor = valor;

        }
        //Propriedades

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int AnoFab 
        {
            get { return anoFab; }
            set { anoFab = value; }
        }
        public float Valor
        { 
            get { return valor; }
            set { valor = value; }
        }

        //Métodos

        public virtual float calcularDepreciacao(float vlr1, float porcetagem)
        {
            //float resultado;

           

            if(valor < 0)
            {
                Console.WriteLine($"Seu carro deu PT");
            }
            else
            {
                valor = (valor - (valor * porcetagem)) - vlr1;

                Console.WriteLine($"Valor  do caminhão após a Depreciação: {valor}");

                return valor;
            }
            return valor;
        }

        public virtual void Imprimir()
        {

            Console.WriteLine($"Modelo Veiculo: {modelo}");
            Console.WriteLine($"Ano Fabricação: {anoFab}");
            Console.WriteLine($"Valor Veiculo: R${valor}");
        }


    }
}
