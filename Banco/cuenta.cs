using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class cuenta
    {
        protected double monto;
        private double fondos;

        public abstract void Insercion(int monto);
        public abstract void Extraccion(int monto, TipodeExtraccion tipo);

        public enum TipodeExtraccion{CajeroHumano=1,CajeroAutomatico=2};

        public cuenta(double f){
            this.fondos = f;
        }

        public double getFondos(){
            return this.fondos;
        }
        
        

    public class CuentaCorrientePesos : cuenta {

    public override void Insercion(int monto){
        this.fondos += monto;
    }
    public override void Extraccion(int monto, TipodeExtraccion tipo){
        if(this.fondos - monto < 5000) {
            Console.WriteLine("Fondos insuficientes.");
        } else {
            if(tipo == TipodeExtraccion.CajeroHumano){
                this.fondos -= monto;
            } else {
                if(monto > 20000) Console.WriteLine("No se puede extraer");
                else this.fondos -= monto;
            }
        }
    }
    
}
public class CuentaDolares : cuenta {

    public override void Insercion(int monto){
        this.fondos += monto;
    }
    public override void Extraccion(int monto, TipodeExtraccion tipo){
        if(monto > this.fondos) {
            Console.WriteLine("Fondos insuficientes.");
        } else {
            if(tipo == TipodeExtraccion.CajeroHumano){
                this.fondos -= monto;
            } else {
                if(monto > 200) Console.WriteLine("");
                 else this.fondos -= monto;
            }
        }
    }
}
/*/
public class CajaAhorroPesos : cuenta {
    public override void Insercion(int monto){
        this.fondos += monto;
    }
    public override void Extraccion(int monto, TipodeExtraccion tipo){
        if(monto > this.fondos) {
            Console.WriteLine(" Fondos insuficientes.");
        } else {
            if(tipo == TipodeExtraccion.CajeroHumano){
                this.fondo -= monto;
            } else {
                if(monto > 10000) Console.WriteLine("No se puede extraer ."); 
                else this.fondos -= monto;
            }
        }
    }
}
}
}



       