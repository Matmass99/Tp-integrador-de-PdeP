using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    public class clasePirata{
/* Supuestamente soon las listas pero no se si se declaran asi 
        private ArrayList _Items;
        
        public ArrayList Items{

            get {return _Items;}
            set {_Items = value;}
        }
*/

        public int nivelEbriedad { get;  }

        public int nivelEbriedad;

        public int cantidadMonedas { get; }
        
        public int cantidadMonedas;

        public bool tiene(unItem) {
		   
            return items.contains(unItem);
	    
        }

        public int cantidadItems() {
		   
            return items.size();
	
        }

        public bool pasadoDeGrog() {
		    
            return nivelEbriedad >= 90;
	    
        }

        public  tomarGrog() {
		
            nivelEbriedad += 5;

		    self.gastarMoneda();
	    
        }

        public  gastarMoneda() {
		    
            self.validarGastarMonedas();
		    
            cantidadMonedas--;
	
        }

        public validarGastarMonedas() {
		    if (cantidadMonedas == 0) {
			    throw new TripulanteException(message = 'Cantidad de monedas insuficientes... insert coin!');
		    }
	    }
    
        public bool podesSaquear(unaVictima) {
		
            return unaVictima.sosSaqueablePor(self);
	
        }

        public int cantidadInvitadosPara(unBarco) {
		    
            return unBarco.cantidadInvitadosPor(self);
	    
        }

        public bool fuisteInvitadoPor(unTripulante) { 
		    
            return invitante.equals(unTripulante);
	
        }
    }

    public class PirataEspiaDeLaCorona : Pirata {
	    
        override public bool pasadoDeGrog() {
		    
            return false;

	}

	    override public bool podesSaquear(unaVictima) {
		    
            return super(unaVictima) && self.tiene('permiso de la corona');
	
    }	
}
    public class TripulanteException : Exception {}
}
/*/* Esto no tengo idea de como se declara, y es lo que falta declarar en la clase.
class Pirata {
	
	const property items = []
	
	var invitante

}
*/