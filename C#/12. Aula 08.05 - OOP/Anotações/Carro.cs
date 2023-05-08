using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotações
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private Motor m; //Relacinamento entre as classes

        public string Marca
        {
            get { 
                return marca; 
            } 
            set 
            {
                modelo = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (value > 0)
                {
                    ano = value;
                }
            }
        }

        public Motor Motor
        {
            get { return m; }
            set { m = value; }
        }

        public void LigarCarro()
        {
            if (!m.Ligado) // = if (m.Ligado == false) quer dizer que o motor não está ligado
            {
                m.LigarMotor();
                Console.WriteLine("O carro ligou.");
            }
            else
            {
                Console.WriteLine("O carro já está ligado!");
            }
        }
        public void DesligarCarro()
        {
            if (m.Ligado)
            {
                m.DesligarMotor();
                Console.WriteLine("O carro desligou");
            }
            else
            {
                Console.WriteLine("O carro já está desligado!");
            }
        }


    }
}
