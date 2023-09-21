using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ07
{
    internal class Reais
    {
        //atributos
        private double vdolar;
        private double cdolar;
        private double reais;


        //metodos 
        public void setVdolar(double p)
        {
            vdolar = p;
        }

        public void setCdolar(double p)
        {
            cdolar = p;
        }


        public double getVdolar()
        {
            return vdolar;
        }

        public double getCdolar()
        {
            return cdolar;
        }


        public double getReais()
        {
            return reais;
        }


        public void calcularReais()
        {
            reais = vdolar * cdolar;
        }
    }
}
    
