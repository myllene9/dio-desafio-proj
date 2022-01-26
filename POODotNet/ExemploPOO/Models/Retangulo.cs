using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas ( double comp, double larg)
        {
            if (comp > 0 && larg > 0)
            {
                this.comprimento = comp;
                this.largura = larg;
                valido = true;
            } else {
                System.Console.WriteLine("Valores Inválidos!");
            }
            
        }

        public double ObterArea()
        {
            if (valido)
            {
                return comprimento * largura;
            } else {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
            
        }
    }
}