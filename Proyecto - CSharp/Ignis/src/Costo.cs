using System;

namespace Ignis 
{   
    public class Costo 
    {
        public Costo() 
        {
            this.costoHoraBasico = 0;
            this.costoHoraAvanzado = 0;
        }

        private int costoHoraBasico;
        public int CostoHoraBasico 
        {
            get => this.costoHoraBasico;
            protected set {}
        }

        public void ModificarCostoHoraBasico(int nuevoCosto) 
        {
            this.costoHoraBasico = nuevoCosto;
        }

        private int costoHoraAvanzado;
        public int CostoHoraAvanzado 
        {
            get => this.costoHoraAvanzado;
            protected set {}
        }

        public void ModificarCostoHoraAvanzado(int nuevoCosto) 
        {
            this.costoHoraAvanzado = nuevoCosto;
        }

    }
}
